using System;
using System.Numerics;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Nhom11_NT101.Q21.Algorithms.RSA
{
    internal class RSAService
    {
        // Lưu key pair sau khi generate
        private RSAParameters _publicKey;
        private RSAParameters _privateKey;

        // ───────────────────────────────────────────
        // 1. SINH CẶP KHÓA
        // keySize: 512 hoặc 1024 (bits)
        // ───────────────────────────────────────────
        public void GenerateKeyPair(int keySize)
        {
            using (var rsa = new RSACryptoServiceProvider(keySize))
            {
                rsa.PersistKeyInCsp = false;
                _publicKey = rsa.ExportParameters(false); // chỉ public
                _privateKey = rsa.ExportParameters(true);  // có cả private
            }
        }

        // ───────────────────────────────────────────
        // 2. LẤY KEY DẠNG XML (để hiển thị lên UI)
        // ───────────────────────────────────────────
        public string GetPublicKeyXml()
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportParameters(_publicKey);
                return rsa.ToXmlString(false); // false = chỉ public
            }
        }

        public string GetPrivateKeyXml()
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportParameters(_privateKey);
                return rsa.ToXmlString(true); // true = có private
            }
        }

        // ───────────────────────────────────────────
        // 3. EXPORT KEY RA FILE .XML (có mã hóa PIN)
        // ───────────────────────────────────────────
        public void ExportPublicKey(string filePath)
        {
            string xml = GetPublicKeyXml();
            System.IO.File.WriteAllText(filePath, xml, Encoding.UTF8);
        }

        public void ExportPrivateKey(string filePath, string pin)
        {
            string xml = GetPrivateKeyXml();

            // Nếu có PIN thì mã hóa nội dung trước khi lưu
            if (!string.IsNullOrEmpty(pin))
            {
                xml = EncryptWithPin(xml, pin);
            }

            System.IO.File.WriteAllText(filePath, xml, Encoding.UTF8);
        }

        // ───────────────────────────────────────────
        // 4. IMPORT KEY TỪ FILE .XML
        // ───────────────────────────────────────────
        public RSAParameters ImportKeyFromFile(string filePath, string pin = "")
        {
            string content = System.IO.File.ReadAllText(filePath, Encoding.UTF8);

            // Nếu có PIN thì giải mã nội dung trước
            if (!string.IsNullOrEmpty(pin))
            {
                content = DecryptWithPin(content, pin);
            }

            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(content);
                // Thử lấy private key, nếu lỗi thì là public key
                try { return rsa.ExportParameters(true); }
                catch { return rsa.ExportParameters(false); }
            }
        }

        // ───────────────────────────────────────────
        // 5. MÃ HÓA VĂN BẢN
        // keyXml: nội dung XML của Public Key
        // ───────────────────────────────────────────
        public string Encrypt(string plainText, string keyXml)
        {
            if (string.IsNullOrEmpty(plainText))
                throw new ArgumentException("Plaintext không được rỗng.");

            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.PersistKeyInCsp = false;
                rsa.FromXmlString(keyXml);

                byte[] dataBytes = Encoding.UTF8.GetBytes(plainText);
                // true = dùng OAEP padding (an toàn hơn)
                byte[] encryptedBytes = rsa.Encrypt(dataBytes, true);

                // Convert sang Base64 để dễ hiển thị
                return Convert.ToBase64String(encryptedBytes);
            }
        }

        // ───────────────────────────────────────────
        // 6. GIẢI MÃ VĂN BẢN
        // keyXml: nội dung XML của Private Key
        // ───────────────────────────────────────────
        public string Decrypt(string cipherText, string keyXml, string pin = "")
        {
            if (string.IsNullOrEmpty(cipherText))
                throw new ArgumentException("Ciphertext không được rỗng.");

            // Nếu keyXml là đường dẫn file thì đọc file
            string resolvedKey = keyXml;
            if (System.IO.File.Exists(keyXml))
            {
                resolvedKey = System.IO.File.ReadAllText(keyXml, Encoding.UTF8);
                if (!string.IsNullOrEmpty(pin))
                    resolvedKey = DecryptWithPin(resolvedKey, pin);
            }

            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.PersistKeyInCsp = false;
                rsa.FromXmlString(resolvedKey);

                byte[] cipherBytes = Convert.FromBase64String(cipherText);
                byte[] decryptedBytes = rsa.Decrypt(cipherBytes, true);

                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }

        // ───────────────────────────────────────────
        // 7. MÃ HÓA/GIẢI MÃ FILE
        // ───────────────────────────────────────────
        public string EncryptFile(string filePath, string keyXml)
        {
            string content = System.IO.File.ReadAllText(filePath, Encoding.UTF8);
            return Encrypt(content, keyXml);
        }

        public string DecryptFile(string filePath, string keyXml, string pin = "")
        {
            string content = System.IO.File.ReadAllText(filePath, Encoding.UTF8);
            return Decrypt(content, keyXml, pin);
        }

        // ───────────────────────────────────────────
        // HELPER: Mã hóa / giải mã string bằng PIN
        // (dùng AES để bảo vệ private key khi export)
        // ───────────────────────────────────────────
        private string EncryptWithPin(string plainText, string pin)
        {
            using (var aes = Aes.Create())
            {
                var key = GetAesKeyFromPin(pin);
                aes.Key = key;
                aes.GenerateIV();

                using (var encryptor = aes.CreateEncryptor())
                {
                    byte[] data = Encoding.UTF8.GetBytes(plainText);
                    byte[] encrypted = encryptor.TransformFinalBlock(data, 0, data.Length);

                    // Ghép IV + ciphertext rồi encode Base64
                    byte[] result = new byte[aes.IV.Length + encrypted.Length];
                    Buffer.BlockCopy(aes.IV, 0, result, 0, aes.IV.Length);
                    Buffer.BlockCopy(encrypted, 0, result, aes.IV.Length, encrypted.Length);
                    return Convert.ToBase64String(result);
                }
            }
        }

        private string DecryptWithPin(string cipherText, string pin)
        {
            byte[] combined = Convert.FromBase64String(cipherText);

            using (var aes = Aes.Create())
            {
                byte[] iv = new byte[16];
                byte[] data = new byte[combined.Length - 16];
                Buffer.BlockCopy(combined, 0, iv, 0, 16);
                Buffer.BlockCopy(combined, 16, data, 0, data.Length);

                aes.Key = GetAesKeyFromPin(pin);
                aes.IV = iv;

                using (var decryptor = aes.CreateDecryptor())
                {
                    byte[] decrypted = decryptor.TransformFinalBlock(data, 0, data.Length);
                    return Encoding.UTF8.GetString(decrypted);
                }
            }
        }

        private byte[] GetAesKeyFromPin(string pin)
        {
            // Dùng SHA256 để tạo key 32 bytes từ PIN bất kỳ
            using (var sha = SHA256.Create())
            {
                return sha.ComputeHash(Encoding.UTF8.GetBytes(pin));
            }
        }
    }
}
