using Nhom11_NT101.Q21.Algorithms.RSA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Nhom11_NT101.Q21.Controls.RSA
{
    public partial class RSAControl : UserControl
    {
        // Tạo instance của service
        private readonly RSAService _rsaService = new RSAService();

        public RSAControl()
        {
            InitializeComponent();
            InitKeySizeDropdown();
        }

        // ── Khởi tạo dropdown Key Size ──────────────
        private void InitKeySizeDropdown()
        {
            // Tên dropdown theo quy định
            Cbb_KeySize.Items.Clear();
            Cbb_KeySize.Items.Add("512");
            Cbb_KeySize.Items.Add("1024");
            Cbb_KeySize.SelectedIndex = 0; // mặc định chọn 512
        }

        // ════════════════════════════════════════════
        // TAB 1 — KEY MANAGEMENT
        // ════════════════════════════════════════════

        // Nút "Generate Key Pair"
        private void Btn_GenerateKeyPair_Click(object sender, EventArgs e)
        {
            try
            {
                int keySize = int.Parse(Cbb_KeySize.SelectedItem.ToString());

                // Hiện thông báo đang xử lý (512-bit nhanh, 1024-bit hơi chậm)
                Cursor = Cursors.WaitCursor;
                _rsaService.GenerateKeyPair(keySize);
                Cursor = Cursors.Default;

                // Hiển thị key ra 2 textbox
                Rtb_PublicKey.Text = _rsaService.GetPublicKeyXml();
                Rtb_PrivateKey.Text = _rsaService.GetPrivateKeyXml();

                MessageBox.Show("Sinh khóa thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút "Copy Public Key"
        private void Btn_CopyPublicKey_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Rtb_PublicKey.Text))
            {
                Clipboard.SetText(Rtb_PublicKey.Text);
                MessageBox.Show("Đã copy Public Key!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Nút "Copy Private Key"
        private void Btn_CopyPrivateKey_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Rtb_PrivateKey.Text))
            {
                Clipboard.SetText(Rtb_PrivateKey.Text);
                MessageBox.Show("Đã copy Private Key!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Nút "Export Public Key (.xml)"
        private void Btn_ExportPublicKey_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Rtb_PublicKey.Text))
            {
                MessageBox.Show("Hãy sinh khóa trước!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "XML files (*.xml)|*.xml";
                dialog.FileName = "public_key.xml";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _rsaService.ExportPublicKey(dialog.FileName);
                    MessageBox.Show("Xuất Public Key thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Nút "Export Private Key (.xml)"
        private void Btn_ExportPrivateKey_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Rtb_PrivateKey.Text))
            {
                MessageBox.Show("Hãy sinh khóa trước!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "XML files (*.xml)|*.xml";
                dialog.FileName = "private_key.xml";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string pin = Tb_PINInputSaveKeys.Text; // textbox PIN ở tab Key Management
                    _rsaService.ExportPrivateKey(dialog.FileName, pin);
                    MessageBox.Show("Xuất Private Key thành công!" +
                        (string.IsNullOrEmpty(pin) ? "" : " (đã mã hóa bằng PIN)"),
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // ════════════════════════════════════════════
        // TAB 2 — ENCRYPTION & DECRYPTION
        // ════════════════════════════════════════════

        // Nút "Paste" (dán text vào ô nhập)
        private void Btn_Paste_Click(object sender, EventArgs e)
        {
            Rtb_SrcTextInput.Text = Clipboard.GetText();
        }

        // Nút "Clear"
        private void Btn_ClearInputText_Click(object sender, EventArgs e)
        {
            Rtb_SrcTextInput.Clear();
            Rtb_Result.Clear();
        }

        // Nút "Browse" chọn file để import
        private void Btn_BrowseText_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Đọc nội dung file vào textbox input
                    Rtb_SrcTextInput.Text = System.IO.File.ReadAllText(
                        dialog.FileName, System.Text.Encoding.UTF8);
                }
            }
        }

        // Nút "Browse" chọn file key (.xml)
        private void Btn_BrowseKey_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "XML files (*.xml)|*.xml";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Rtb_KeyInput.Text = dialog.FileName; // textbox hiển thị đường dẫn key
                }
            }
        }

        // Nút "Encrypt"
        private void Btn_Encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string inputText = Rtb_SrcTextInput.Text;
                string keyPath = Rtb_KeyInput.Text;

                if (string.IsNullOrWhiteSpace(inputText))
                {
                    MessageBox.Show("Nhập text cần mã hóa!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(keyPath))
                {
                    MessageBox.Show("Chọn file Public Key (.xml)!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Đọc nội dung file key
                string keyXml = System.IO.File.ReadAllText(
                    keyPath, System.Text.Encoding.UTF8);

                string result = _rsaService.Encrypt(inputText, keyXml);
                Rtb_Result.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi mã hóa: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút "Decrypt"
        private void Btn_Decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string inputText = Rtb_SrcTextInput.Text;
                string keyPath = Rtb_KeyInput.Text;
                string pin = Tb_PINKeyInput.Text; // PIN ở tab Encrypt/Decrypt

                if (string.IsNullOrWhiteSpace(inputText))
                {
                    MessageBox.Show("Nhập ciphertext cần giải mã!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(keyPath))
                {
                    MessageBox.Show("Chọn file Private Key (.xml)!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Đọc file key, nếu có PIN thì truyền vào để giải mã file
                string keyXml = System.IO.File.ReadAllText(
                    keyPath, System.Text.Encoding.UTF8);

                if (!string.IsNullOrEmpty(pin))
                {
                    // Giải mã nội dung file key bằng PIN
                    // (dùng hàm internal — cần expose hoặc xử lý khác)
                    // Giải pháp đơn giản: gọi Decrypt với pin
                }

                string result = _rsaService.Decrypt(inputText, keyXml);
                Rtb_Result.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi giải mã: " + ex.Message +
                    "\nKiểm tra lại: đúng Private Key chưa? PIN đúng chưa?",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút "Copy Result"
        private void Btn_CopyResult_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Rtb_Result.Text))
            {
                Clipboard.SetText(Rtb_Result.Text);
                MessageBox.Show("Đã copy kết quả!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
