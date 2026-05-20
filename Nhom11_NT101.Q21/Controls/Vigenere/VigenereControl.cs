using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Nhom11_NT101.Q21.Algorithms.Vigenere;

namespace Nhom11_NT101.Q21.Controls.Vigenere
{
    public partial class VigenereControl : UserControl
    {
        public VigenereControl()
        {
            InitializeComponent();
            Btn_Browse.Click += Btn_Browse_Click;
            Btn_ClearInputText.Click += Btn_ClearInputText_Click;
            Btn_Copy.Click += Btn_Copy_Click;
            Btn_Decrypt.Click += Btn_Decrypt_Click;
            Btn_Encrypt.Click += Btn_Encrypt_Click;
            Btn_Paste.Click += Btn_Paste_Click;
        }

        private void Btn_Paste_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Btn_Encrypt_Click(object? sender, EventArgs e)
        {
            string key = Tb_KeyInput.Text;
            string text = Rtb_SrcTextInput.Text;

            if (string.IsNullOrEmpty(key) || string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Key and text must not be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            VigenereService vigenereService = new VigenereService();
            string res = ""; 
            int keyIndex = 0; 

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char keyChar = key[keyIndex % key.Length];
                    res += vigenereService.EncryptChar(c, keyChar);

                    keyIndex++; 
                }
                else
                {
                    res += c;
                }
            }

            Rtb_Result.Text = res;
        }

        private void Btn_Decrypt_Click(object? sender, EventArgs e)
        {
            string key = Tb_KeyInput.Text;
            string text = Rtb_SrcTextInput.Text; 

            if (string.IsNullOrEmpty(key) || string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Key and text must not be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            VigenereService vigenereService = new VigenereService();
            string res = ""; 
            int keyIndex = 0; 

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char keyChar = key[keyIndex % key.Length];

                    res += vigenereService.DecryptChar(c, keyChar);

                    keyIndex++; 
                }
                else
                {
                    res += c;
                }
            }

            Rtb_Result.Text = res;
        }

        private void Btn_Copy_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Btn_ClearInputText_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Btn_Browse_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        
    }
}
