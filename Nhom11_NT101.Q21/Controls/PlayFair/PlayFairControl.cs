using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Nhom11_NT101.Q21.Controls.PlayFair
{
    public partial class PlayFairControl : UserControl
    {
        public PlayFairControl()
        {
            InitializeComponent();
        }

        private void Btn_CopyResult_Click(object sender, EventArgs e)
        {
            Rtb_Result.SelectAll();
            Clipboard.SetText(Rtb_Result.Text);
        }

        private void Btn_Paste_Click(object sender, EventArgs e)
        {
            string clipboardText = Clipboard.GetText();
            Rtb_SrcTextInput.Text = clipboardText;
        }

        private void Btn_ClearInputText_Click(object sender, EventArgs e)
        {
            Rtb_SrcTextInput.Clear();
        }

        private void Btn_BrowseText_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.xml)|*.xml|All Files (*.*)|*.*";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                try
                {
                    string fileContent = System.IO.File.ReadAllText(filePath);
                    Rtb_SrcTextInput.Text = fileContent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file: " + ex.Message);
                }
            }
        }

        private void Btn_Encrypt_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Decrypt_Click(object sender, EventArgs e)
        {

        }


    }
}

