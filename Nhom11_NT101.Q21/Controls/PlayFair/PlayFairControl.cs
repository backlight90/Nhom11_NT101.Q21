using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Nhom11_NT101.Q21.Algorithms.PlayFair;
using System.Reflection;

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
            if (!string.IsNullOrEmpty(Rtb_Result.Text))
            {
                Clipboard.SetText(Rtb_Result.Text);
                MessageBox.Show("Đã sao chép kết quả vào Clipboard!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Paste_Click(object sender, EventArgs e)
        {
            string clipboardText = Clipboard.GetText();
            Rtb_SrcTextInput.Text = clipboardText;
        }

        private void Btn_ClearInputText_Click(object sender, EventArgs e)
        {
            Rtb_SrcTextInput.Clear();
            Rtb_Result.Clear();
        }

        private void Btn_BrowseText_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt|XML Files (*.xml)|*.xml|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                try
                {
                    string fileContent = System.IO.File.ReadAllText(filePath);
                    Rtb_SrcTextInput.Text = fileContent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Hàm hỗ trợ cập nhật Ma trận Khóa (Key Matrix) lên các Label tương ứng trên UI
        private void UpdateKeyMatrixUI(PlayFairService playFairService)
        {
            // Sử dụng Reflection để lấy trường dữ liệu private 'keyMatrix' từ PlayFairService
            FieldInfo fieldInfo = typeof(PlayFairService).GetField("keyMatrix", BindingFlags.NonPublic | BindingFlags.Instance);
            if (fieldInfo != null)
            {
                char[,] matrix = (char[,])fieldInfo.GetValue(playFairService);

                for (int row = 0; row < 5; row++)
                {
                    for (int col = 0; col < 5; col++)
                    {
                        // Tên của Label được đặt theo định dạng Lbl_M[Hàng][Cột] bắt đầu từ 1 đến 5 (Ví dụ: Lbl_M11, Lbl_M55)
                        string labelName = $"Lbl_M{row + 1}{col + 1}";

                        // Tìm kiếm control Label trong Gb_KeyMatrix
                        Control[] foundControls = Gb_KeyMatrix.Controls.Find(labelName, true);
                        if (foundControls.Length > 0 && foundControls[0] is Label lbl)
                        {
                            lbl.Text = matrix[row, col].ToString();
                        }
                    }
                }
            }
        }

        private void Btn_Encrypt_Click(object sender, EventArgs e)
        {
            string key = Rtb_KeyInput.Text.Trim();
            string plaintext = Rtb_SrcTextInput.Text.Trim();

            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Vui lòng nhập Khóa (Key) trước khi mã hóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(plaintext))
            {
                MessageBox.Show("Vui lòng nhập văn bản cần mã hóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Khởi tạo dịch vụ PlayFairService với khóa được cung cấp
                PlayFairService service = new PlayFairService(key);

                // Hiển thị ma trận khóa
                UpdateKeyMatrixUI(service);

                // Thực hiện mã hóa và trả kết quả lên ô Result
                string ciphertext = service.Encrypt(plaintext);
                Rtb_Result.Text = ciphertext;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình mã hóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Decrypt_Click(object sender, EventArgs e)
        {
            string key = Rtb_KeyInput.Text.Trim();
            string ciphertext = Rtb_SrcTextInput.Text.Trim();

            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Vui lòng nhập Khóa (Key) trước khi giải mã!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(ciphertext))
            {
                MessageBox.Show("Vui lòng nhập văn bản cần giải mã!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Khởi tạo dịch vụ PlayFairService với khóa được cung cấp
                PlayFairService service = new PlayFairService(key);

                // Hiển thị ma trận khóa lên giao diện
                UpdateKeyMatrixUI(service);

                // Thực hiện giải mã và hiển thị kết quả
                string plaintext = service.Decrypt(ciphertext);
                Rtb_Result.Text = plaintext;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình giải mã: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}