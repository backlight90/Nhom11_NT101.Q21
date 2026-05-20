using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Nhom11_NT101.Q21.Algorithms.PlayFair
{
    internal class PlayFairService
    {
        private char[,] keyMatrix;

        public PlayFairService(string key)
        {
            GenerateKeyMatrix(key);
        }

        private void GenerateKeyMatrix(string key)
        {
            keyMatrix = new char[5, 5];
            string alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ"; // J is usually omitted in PlayFair
            string parsedKey = Regex.Replace(key.ToUpper(), @"[^A-Z]", "").Replace("J", "I"); // Remove non-alphabetic characters
            string fullString = parsedKey + alphabet;

            HashSet<char> usedChars = new HashSet<char>();
            string uniqueChars = "";

            foreach (char c in fullString)
            {
                if (!usedChars.Contains(c))
                {
                    usedChars.Add(c);
                    uniqueChars += c;
                }
            }

            int index = 0;
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    keyMatrix[row, col] = uniqueChars[index++];
                }
            }
        }

        private string PrepareText(string text)
        {
            text = Regex.Replace(text.ToUpper(), @"[^A-Z]", "").Replace("J", "I"); // Remove non-alphabetic characters
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i += 2)
            {
                sb.Append(text[i]);
                if (i + 1 < text.Length)
                {
                    if (text[i] == text[i + 1])
                    {
                        sb.Append('X'); // Insert 'X' between duplicate letters
                        i--;
                    }
                    else
                    {
                        sb.Append(text[i + 1]);
                    }
                }
            }

            if (sb.Length % 2 != 0)
            {
                sb.Append('X'); // Pad with 'X' if the length is odd
            }

            return sb.ToString();
        }

        private (int row, int col) FindPosition(char c)
        {
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    if (keyMatrix[row, col] == c)
                    {
                        return (row, col);
                    }
                }
            }
            return (-1, -1); // Not found
        }
        public string Encrypt(string plaintext)
        {
            string preparedText = PrepareText(plaintext);
            StringBuilder ciphertext = new StringBuilder();
            for (int i = 0; i < preparedText.Length; i += 2)
            {
                char a = preparedText[i];
                char b = preparedText[i + 1];
                var posA = FindPosition(a);
                var posB = FindPosition(b);
                // Cùng hàng: Lấy ký tự bên phải (vòng lại nếu quá biên)
                if (posA.row == posB.row)
                {
                    ciphertext.Append(keyMatrix[posA.row, (posA.col + 1) % 5]);
                    ciphertext.Append(keyMatrix[posB.row, (posB.col + 1) % 5]);
                }
                // Cùng cột: Lấy ký tự bên dưới (vòng lại nếu quá biên)
                else if (posA.col == posB.col)
                {
                    ciphertext.Append(keyMatrix[(posA.row + 1) % 5, posA.col]);
                    ciphertext.Append(keyMatrix[(posB.row + 1) % 5, posB.col]);
                }
                // Khác hàng, khác cột (Hình chữ nhật)
                else
                {
                    ciphertext.Append(keyMatrix[posA.row, posB.col]);
                    ciphertext.Append(keyMatrix[posB.row, posA.col]);
                }
            }
            return ciphertext.ToString();
        }

        public string Decrypt(string ciphertext)
        {
            StringBuilder plaintext = new StringBuilder();
            for (int i = 0; i < ciphertext.Length; i += 2)
            {
                char a = ciphertext[i];
                char b = ciphertext[i + 1];
                var posA = FindPosition(a);
                var posB = FindPosition(b);
                // Cùng hàng: Lấy ký tự bên trái (vòng lại nếu quá biên)
                if (posA.row == posB.row)
                {
                    plaintext.Append(keyMatrix[posA.row, (posA.col + 4) % 5]); // +4 tương đương -1 trong modulo 5
                    plaintext.Append(keyMatrix[posB.row, (posB.col + 4) % 5]);
                }
                // Cùng cột: Lấy ký tự bên trên (vòng lại nếu quá biên)
                else if (posA.col == posB.col)
                {
                    plaintext.Append(keyMatrix[(posA.row + 4) % 5, posA.col]);
                    plaintext.Append(keyMatrix[(posB.row + 4) % 5, posB.col]);
                }
                // Khác hàng, khác cột (Hình chữ nhật)
                else
                {
                    plaintext.Append(keyMatrix[posA.row, posB.col]);
                    plaintext.Append(keyMatrix[posB.row, posA.col]);
                }
            }
            return plaintext.ToString();
        }
    }
}
