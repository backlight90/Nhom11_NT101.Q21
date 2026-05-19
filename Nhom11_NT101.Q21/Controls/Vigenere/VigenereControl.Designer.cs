namespace Nhom11_NT101.Q21.Controls.Vigenere
{
    partial class VigenereControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Btn_Browse = new Button();
            Lbl_FileSrc = new Label();
            Btn_ClearInputText = new Button();
            Btn_Decrypt = new Button();
            Btn_Encrypt = new Button();
            Btn_Copy = new Button();
            Rtb_Result = new RichTextBox();
            Lbl_Result = new Label();
            Lbl_SrcTextInput = new Label();
            Lbl_KeyInput = new Label();
            Btn_Paste = new Button();
            Rtb_SrcTextInput = new RichTextBox();
            Tb_KeyInput = new TextBox();
            SuspendLayout();
            // 
            // Btn_Browse
            // 
            Btn_Browse.Font = new Font("Segoe UI", 10.875F);
            Btn_Browse.Location = new Point(223, 693);
            Btn_Browse.Name = "Btn_Browse";
            Btn_Browse.Size = new Size(137, 46);
            Btn_Browse.TabIndex = 31;
            Btn_Browse.Text = "Browse";
            Btn_Browse.UseVisualStyleBackColor = true;
            // 
            // Lbl_FileSrc
            // 
            Lbl_FileSrc.AutoSize = true;
            Lbl_FileSrc.Font = new Font("Segoe UI", 10.875F);
            Lbl_FileSrc.Location = new Point(49, 693);
            Lbl_FileSrc.Name = "Lbl_FileSrc";
            Lbl_FileSrc.Size = new Size(156, 40);
            Lbl_FileSrc.TabIndex = 30;
            Lbl_FileSrc.Text = "Import file:";
            // 
            // Btn_ClearInputText
            // 
            Btn_ClearInputText.Font = new Font("Segoe UI", 10.875F);
            Btn_ClearInputText.Location = new Point(464, 151);
            Btn_ClearInputText.Name = "Btn_ClearInputText";
            Btn_ClearInputText.Size = new Size(137, 46);
            Btn_ClearInputText.TabIndex = 29;
            Btn_ClearInputText.Text = "Clear";
            Btn_ClearInputText.UseVisualStyleBackColor = true;
            // 
            // Btn_Decrypt
            // 
            Btn_Decrypt.Font = new Font("Segoe UI", 10.875F);
            Btn_Decrypt.Location = new Point(672, 805);
            Btn_Decrypt.Name = "Btn_Decrypt";
            Btn_Decrypt.Size = new Size(285, 71);
            Btn_Decrypt.TabIndex = 28;
            Btn_Decrypt.Text = "Decrypt";
            Btn_Decrypt.UseVisualStyleBackColor = true;
            // 
            // Btn_Encrypt
            // 
            Btn_Encrypt.Font = new Font("Segoe UI", 10.875F);
            Btn_Encrypt.Location = new Point(316, 805);
            Btn_Encrypt.Name = "Btn_Encrypt";
            Btn_Encrypt.Size = new Size(285, 71);
            Btn_Encrypt.TabIndex = 27;
            Btn_Encrypt.Text = "Encrypt";
            Btn_Encrypt.UseVisualStyleBackColor = true;
            // 
            // Btn_Copy
            // 
            Btn_Copy.Font = new Font("Segoe UI", 10.875F);
            Btn_Copy.Location = new Point(1114, 148);
            Btn_Copy.Name = "Btn_Copy";
            Btn_Copy.Size = new Size(137, 46);
            Btn_Copy.TabIndex = 26;
            Btn_Copy.Text = "Copy";
            Btn_Copy.UseVisualStyleBackColor = true;
            // 
            // Rtb_Result
            // 
            Rtb_Result.Font = new Font("Segoe UI", 10.875F);
            Rtb_Result.Location = new Point(699, 214);
            Rtb_Result.Name = "Rtb_Result";
            Rtb_Result.ReadOnly = true;
            Rtb_Result.Size = new Size(552, 444);
            Rtb_Result.TabIndex = 25;
            Rtb_Result.Text = "";
            // 
            // Lbl_Result
            // 
            Lbl_Result.AutoSize = true;
            Lbl_Result.Font = new Font("Segoe UI", 10.875F);
            Lbl_Result.Location = new Point(699, 151);
            Lbl_Result.Name = "Lbl_Result";
            Lbl_Result.Size = new Size(99, 40);
            Lbl_Result.TabIndex = 24;
            Lbl_Result.Text = "Result:";
            // 
            // Lbl_SrcTextInput
            // 
            Lbl_SrcTextInput.AutoSize = true;
            Lbl_SrcTextInput.Font = new Font("Segoe UI", 10.875F);
            Lbl_SrcTextInput.Location = new Point(49, 151);
            Lbl_SrcTextInput.Name = "Lbl_SrcTextInput";
            Lbl_SrcTextInput.Size = new Size(145, 40);
            Lbl_SrcTextInput.TabIndex = 23;
            Lbl_SrcTextInput.Text = "Enter text:";
            // 
            // Lbl_KeyInput
            // 
            Lbl_KeyInput.AutoSize = true;
            Lbl_KeyInput.Font = new Font("Segoe UI", 10.875F);
            Lbl_KeyInput.Location = new Point(45, 50);
            Lbl_KeyInput.Name = "Lbl_KeyInput";
            Lbl_KeyInput.Size = new Size(140, 40);
            Lbl_KeyInput.TabIndex = 22;
            Lbl_KeyInput.Text = "Enter key:";
            // 
            // Btn_Paste
            // 
            Btn_Paste.Font = new Font("Segoe UI", 10.875F);
            Btn_Paste.Location = new Point(305, 151);
            Btn_Paste.Name = "Btn_Paste";
            Btn_Paste.Size = new Size(137, 46);
            Btn_Paste.TabIndex = 21;
            Btn_Paste.Text = "Paste";
            Btn_Paste.UseVisualStyleBackColor = true;
            // 
            // Rtb_SrcTextInput
            // 
            Rtb_SrcTextInput.Font = new Font("Segoe UI", 10.875F);
            Rtb_SrcTextInput.Location = new Point(49, 214);
            Rtb_SrcTextInput.Name = "Rtb_SrcTextInput";
            Rtb_SrcTextInput.Size = new Size(552, 444);
            Rtb_SrcTextInput.TabIndex = 19;
            Rtb_SrcTextInput.Text = "";
            // 
            // Tb_KeyInput
            // 
            Tb_KeyInput.Font = new Font("Segoe UI", 10.875F);
            Tb_KeyInput.Location = new Point(191, 47);
            Tb_KeyInput.Multiline = true;
            Tb_KeyInput.Name = "Tb_KeyInput";
            Tb_KeyInput.Size = new Size(1060, 64);
            Tb_KeyInput.TabIndex = 18;
            // 
            // VigenereControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Btn_Browse);
            Controls.Add(Lbl_FileSrc);
            Controls.Add(Btn_ClearInputText);
            Controls.Add(Btn_Decrypt);
            Controls.Add(Btn_Encrypt);
            Controls.Add(Btn_Copy);
            Controls.Add(Rtb_Result);
            Controls.Add(Lbl_Result);
            Controls.Add(Lbl_SrcTextInput);
            Controls.Add(Lbl_KeyInput);
            Controls.Add(Btn_Paste);
            Controls.Add(Rtb_SrcTextInput);
            Controls.Add(Tb_KeyInput);
            Name = "VigenereControl";
            Size = new Size(1300, 1000);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Browse;
        private Label Lbl_FileSrc;
        private Button Btn_ClearInputText;
        private Button Btn_Decrypt;
        private Button Btn_Encrypt;
        private Button Btn_Copy;
        private RichTextBox Rtb_Result;
        private Label Lbl_Result;
        private Label Lbl_SrcTextInput;
        private Label Lbl_KeyInput;
        private Button Btn_Paste;
        private RichTextBox Rtb_SrcTextInput;
        private TextBox Tb_KeyInput;
    }
}
