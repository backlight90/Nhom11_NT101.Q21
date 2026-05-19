namespace Nhom11_NT101.Q21.Controls.PlayFair
{
    partial class PlayFairControl
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
            Btn_Encrypt = new Button();
            Rtb_Result = new RichTextBox();
            Lbl_Result = new Label();
            Btn_Decrypt = new Button();
            Gb_KeyInput = new GroupBox();
            Gb_KeyMatrix = new GroupBox();
            Lbl_M53 = new Label();
            Lbl_M54 = new Label();
            Lbl_M55 = new Label();
            Lbl_M52 = new Label();
            Lbl_M51 = new Label();
            Lbl_M43 = new Label();
            Lbl_M44 = new Label();
            Lbl_M45 = new Label();
            Lbl_M42 = new Label();
            Lbl_M41 = new Label();
            Lbl_M33 = new Label();
            Lbl_M34 = new Label();
            Lbl_M35 = new Label();
            Lbl_M32 = new Label();
            Lbl_M31 = new Label();
            Lbl_M23 = new Label();
            Lbl_M24 = new Label();
            Lbl_M25 = new Label();
            Lbl_M22 = new Label();
            Lbl_M21 = new Label();
            Lbl_M13 = new Label();
            Lbl_M14 = new Label();
            Lbl_M15 = new Label();
            Lbl_M12 = new Label();
            Lbl_M11 = new Label();
            Btn_CopyResult = new Button();
            Gb_TextInput = new GroupBox();
            Btn_BrowseText = new Button();
            Lbl_ImportFileSrc = new Label();
            Btn_ClearInputText = new Button();
            Lbl_SrcTextInput = new Label();
            Btn_Paste = new Button();
            Rtb_SrcTextInput = new RichTextBox();
            Gb_KeyInput.SuspendLayout();
            Gb_KeyMatrix.SuspendLayout();
            Gb_TextInput.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_Encrypt
            // 
            Btn_Encrypt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Encrypt.Location = new Point(303, 847);
            Btn_Encrypt.Name = "Btn_Encrypt";
            Btn_Encrypt.Size = new Size(285, 71);
            Btn_Encrypt.TabIndex = 46;
            Btn_Encrypt.Text = "Encrypt";
            Btn_Encrypt.UseVisualStyleBackColor = true;
            // 
            // Rtb_Result
            // 
            Rtb_Result.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Rtb_Result.Location = new Point(33, 654);
            Rtb_Result.Name = "Rtb_Result";
            Rtb_Result.ReadOnly = true;
            Rtb_Result.Size = new Size(1217, 148);
            Rtb_Result.TabIndex = 51;
            Rtb_Result.Text = "";
            // 
            // Lbl_Result
            // 
            Lbl_Result.AutoSize = true;
            Lbl_Result.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Result.Location = new Point(33, 595);
            Lbl_Result.Name = "Lbl_Result";
            Lbl_Result.Size = new Size(99, 40);
            Lbl_Result.TabIndex = 50;
            Lbl_Result.Text = "Result:";
            // 
            // Btn_Decrypt
            // 
            Btn_Decrypt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Decrypt.Location = new Point(690, 847);
            Btn_Decrypt.Name = "Btn_Decrypt";
            Btn_Decrypt.Size = new Size(285, 71);
            Btn_Decrypt.TabIndex = 53;
            Btn_Decrypt.Text = "Decrypt";
            Btn_Decrypt.UseVisualStyleBackColor = true;
            // 
            // Gb_KeyInput
            // 
            Gb_KeyInput.Controls.Add(Gb_KeyMatrix);
            Gb_KeyInput.Location = new Point(628, 31);
            Gb_KeyInput.Name = "Gb_KeyInput";
            Gb_KeyInput.Size = new Size(622, 518);
            Gb_KeyInput.TabIndex = 57;
            Gb_KeyInput.TabStop = false;
            Gb_KeyInput.Text = "Key Input";
            // 
            // Gb_KeyMatrix
            // 
            Gb_KeyMatrix.Controls.Add(Lbl_M53);
            Gb_KeyMatrix.Controls.Add(Lbl_M54);
            Gb_KeyMatrix.Controls.Add(Lbl_M55);
            Gb_KeyMatrix.Controls.Add(Lbl_M52);
            Gb_KeyMatrix.Controls.Add(Lbl_M51);
            Gb_KeyMatrix.Controls.Add(Lbl_M43);
            Gb_KeyMatrix.Controls.Add(Lbl_M44);
            Gb_KeyMatrix.Controls.Add(Lbl_M45);
            Gb_KeyMatrix.Controls.Add(Lbl_M42);
            Gb_KeyMatrix.Controls.Add(Lbl_M41);
            Gb_KeyMatrix.Controls.Add(Lbl_M33);
            Gb_KeyMatrix.Controls.Add(Lbl_M34);
            Gb_KeyMatrix.Controls.Add(Lbl_M35);
            Gb_KeyMatrix.Controls.Add(Lbl_M32);
            Gb_KeyMatrix.Controls.Add(Lbl_M31);
            Gb_KeyMatrix.Controls.Add(Lbl_M23);
            Gb_KeyMatrix.Controls.Add(Lbl_M24);
            Gb_KeyMatrix.Controls.Add(Lbl_M25);
            Gb_KeyMatrix.Controls.Add(Lbl_M22);
            Gb_KeyMatrix.Controls.Add(Lbl_M21);
            Gb_KeyMatrix.Controls.Add(Lbl_M13);
            Gb_KeyMatrix.Controls.Add(Lbl_M14);
            Gb_KeyMatrix.Controls.Add(Lbl_M15);
            Gb_KeyMatrix.Controls.Add(Lbl_M12);
            Gb_KeyMatrix.Controls.Add(Lbl_M11);
            Gb_KeyMatrix.Location = new Point(116, 116);
            Gb_KeyMatrix.Name = "Gb_KeyMatrix";
            Gb_KeyMatrix.Size = new Size(416, 376);
            Gb_KeyMatrix.TabIndex = 45;
            Gb_KeyMatrix.TabStop = false;
            Gb_KeyMatrix.Text = "Key Matrix";
            // 
            // Lbl_M53
            // 
            Lbl_M53.AutoSize = true;
            Lbl_M53.Font = new Font("Segoe UI", 9F);
            Lbl_M53.Location = new Point(191, 324);
            Lbl_M53.Name = "Lbl_M53";
            Lbl_M53.Size = new Size(29, 32);
            Lbl_M53.TabIndex = 64;
            Lbl_M53.Text = "A";
            // 
            // Lbl_M54
            // 
            Lbl_M54.AutoSize = true;
            Lbl_M54.Font = new Font("Segoe UI", 9F);
            Lbl_M54.Location = new Point(268, 324);
            Lbl_M54.Name = "Lbl_M54";
            Lbl_M54.Size = new Size(29, 32);
            Lbl_M54.TabIndex = 63;
            Lbl_M54.Text = "A";
            // 
            // Lbl_M55
            // 
            Lbl_M55.AutoSize = true;
            Lbl_M55.Font = new Font("Segoe UI", 9F);
            Lbl_M55.Location = new Point(343, 324);
            Lbl_M55.Name = "Lbl_M55";
            Lbl_M55.Size = new Size(29, 32);
            Lbl_M55.TabIndex = 62;
            Lbl_M55.Text = "A";
            // 
            // Lbl_M52
            // 
            Lbl_M52.AutoSize = true;
            Lbl_M52.Font = new Font("Segoe UI", 9F);
            Lbl_M52.Location = new Point(112, 324);
            Lbl_M52.Name = "Lbl_M52";
            Lbl_M52.Size = new Size(29, 32);
            Lbl_M52.TabIndex = 61;
            Lbl_M52.Text = "A";
            // 
            // Lbl_M51
            // 
            Lbl_M51.AutoSize = true;
            Lbl_M51.Font = new Font("Segoe UI", 9F);
            Lbl_M51.Location = new Point(41, 324);
            Lbl_M51.Name = "Lbl_M51";
            Lbl_M51.Size = new Size(29, 32);
            Lbl_M51.TabIndex = 60;
            Lbl_M51.Text = "A";
            // 
            // Lbl_M43
            // 
            Lbl_M43.AutoSize = true;
            Lbl_M43.Font = new Font("Segoe UI", 9F);
            Lbl_M43.Location = new Point(191, 254);
            Lbl_M43.Name = "Lbl_M43";
            Lbl_M43.Size = new Size(29, 32);
            Lbl_M43.TabIndex = 59;
            Lbl_M43.Text = "A";
            // 
            // Lbl_M44
            // 
            Lbl_M44.AutoSize = true;
            Lbl_M44.Font = new Font("Segoe UI", 9F);
            Lbl_M44.Location = new Point(268, 254);
            Lbl_M44.Name = "Lbl_M44";
            Lbl_M44.Size = new Size(29, 32);
            Lbl_M44.TabIndex = 58;
            Lbl_M44.Text = "A";
            // 
            // Lbl_M45
            // 
            Lbl_M45.AutoSize = true;
            Lbl_M45.Font = new Font("Segoe UI", 9F);
            Lbl_M45.Location = new Point(343, 254);
            Lbl_M45.Name = "Lbl_M45";
            Lbl_M45.Size = new Size(29, 32);
            Lbl_M45.TabIndex = 57;
            Lbl_M45.Text = "A";
            // 
            // Lbl_M42
            // 
            Lbl_M42.AutoSize = true;
            Lbl_M42.Font = new Font("Segoe UI", 9F);
            Lbl_M42.Location = new Point(112, 254);
            Lbl_M42.Name = "Lbl_M42";
            Lbl_M42.Size = new Size(29, 32);
            Lbl_M42.TabIndex = 56;
            Lbl_M42.Text = "A";
            // 
            // Lbl_M41
            // 
            Lbl_M41.AutoSize = true;
            Lbl_M41.Font = new Font("Segoe UI", 9F);
            Lbl_M41.Location = new Point(41, 254);
            Lbl_M41.Name = "Lbl_M41";
            Lbl_M41.Size = new Size(29, 32);
            Lbl_M41.TabIndex = 55;
            Lbl_M41.Text = "A";
            // 
            // Lbl_M33
            // 
            Lbl_M33.AutoSize = true;
            Lbl_M33.Font = new Font("Segoe UI", 9F);
            Lbl_M33.Location = new Point(191, 189);
            Lbl_M33.Name = "Lbl_M33";
            Lbl_M33.Size = new Size(29, 32);
            Lbl_M33.TabIndex = 54;
            Lbl_M33.Text = "A";
            // 
            // Lbl_M34
            // 
            Lbl_M34.AutoSize = true;
            Lbl_M34.Font = new Font("Segoe UI", 9F);
            Lbl_M34.Location = new Point(268, 189);
            Lbl_M34.Name = "Lbl_M34";
            Lbl_M34.Size = new Size(29, 32);
            Lbl_M34.TabIndex = 53;
            Lbl_M34.Text = "A";
            // 
            // Lbl_M35
            // 
            Lbl_M35.AutoSize = true;
            Lbl_M35.Font = new Font("Segoe UI", 9F);
            Lbl_M35.Location = new Point(343, 189);
            Lbl_M35.Name = "Lbl_M35";
            Lbl_M35.Size = new Size(29, 32);
            Lbl_M35.TabIndex = 52;
            Lbl_M35.Text = "A";
            // 
            // Lbl_M32
            // 
            Lbl_M32.AutoSize = true;
            Lbl_M32.Font = new Font("Segoe UI", 9F);
            Lbl_M32.Location = new Point(112, 189);
            Lbl_M32.Name = "Lbl_M32";
            Lbl_M32.Size = new Size(29, 32);
            Lbl_M32.TabIndex = 51;
            Lbl_M32.Text = "A";
            // 
            // Lbl_M31
            // 
            Lbl_M31.AutoSize = true;
            Lbl_M31.Font = new Font("Segoe UI", 9F);
            Lbl_M31.Location = new Point(41, 189);
            Lbl_M31.Name = "Lbl_M31";
            Lbl_M31.Size = new Size(29, 32);
            Lbl_M31.TabIndex = 50;
            Lbl_M31.Text = "A";
            // 
            // Lbl_M23
            // 
            Lbl_M23.AutoSize = true;
            Lbl_M23.Font = new Font("Segoe UI", 9F);
            Lbl_M23.Location = new Point(191, 122);
            Lbl_M23.Name = "Lbl_M23";
            Lbl_M23.Size = new Size(29, 32);
            Lbl_M23.TabIndex = 49;
            Lbl_M23.Text = "A";
            // 
            // Lbl_M24
            // 
            Lbl_M24.AutoSize = true;
            Lbl_M24.Font = new Font("Segoe UI", 9F);
            Lbl_M24.Location = new Point(268, 122);
            Lbl_M24.Name = "Lbl_M24";
            Lbl_M24.Size = new Size(29, 32);
            Lbl_M24.TabIndex = 48;
            Lbl_M24.Text = "A";
            // 
            // Lbl_M25
            // 
            Lbl_M25.AutoSize = true;
            Lbl_M25.Font = new Font("Segoe UI", 9F);
            Lbl_M25.Location = new Point(343, 122);
            Lbl_M25.Name = "Lbl_M25";
            Lbl_M25.Size = new Size(29, 32);
            Lbl_M25.TabIndex = 47;
            Lbl_M25.Text = "A";
            // 
            // Lbl_M22
            // 
            Lbl_M22.AutoSize = true;
            Lbl_M22.Font = new Font("Segoe UI", 9F);
            Lbl_M22.Location = new Point(112, 122);
            Lbl_M22.Name = "Lbl_M22";
            Lbl_M22.Size = new Size(29, 32);
            Lbl_M22.TabIndex = 46;
            Lbl_M22.Text = "A";
            // 
            // Lbl_M21
            // 
            Lbl_M21.AutoSize = true;
            Lbl_M21.Font = new Font("Segoe UI", 9F);
            Lbl_M21.Location = new Point(41, 122);
            Lbl_M21.Name = "Lbl_M21";
            Lbl_M21.Size = new Size(29, 32);
            Lbl_M21.TabIndex = 45;
            Lbl_M21.Text = "A";
            // 
            // Lbl_M13
            // 
            Lbl_M13.AutoSize = true;
            Lbl_M13.Font = new Font("Segoe UI", 9F);
            Lbl_M13.Location = new Point(191, 52);
            Lbl_M13.Name = "Lbl_M13";
            Lbl_M13.Size = new Size(29, 32);
            Lbl_M13.TabIndex = 44;
            Lbl_M13.Text = "A";
            // 
            // Lbl_M14
            // 
            Lbl_M14.AutoSize = true;
            Lbl_M14.Font = new Font("Segoe UI", 9F);
            Lbl_M14.Location = new Point(268, 52);
            Lbl_M14.Name = "Lbl_M14";
            Lbl_M14.Size = new Size(29, 32);
            Lbl_M14.TabIndex = 43;
            Lbl_M14.Text = "A";
            // 
            // Lbl_M15
            // 
            Lbl_M15.AutoSize = true;
            Lbl_M15.Font = new Font("Segoe UI", 9F);
            Lbl_M15.Location = new Point(343, 52);
            Lbl_M15.Name = "Lbl_M15";
            Lbl_M15.Size = new Size(29, 32);
            Lbl_M15.TabIndex = 42;
            Lbl_M15.Text = "A";
            // 
            // Lbl_M12
            // 
            Lbl_M12.AutoSize = true;
            Lbl_M12.Font = new Font("Segoe UI", 9F);
            Lbl_M12.Location = new Point(112, 52);
            Lbl_M12.Name = "Lbl_M12";
            Lbl_M12.Size = new Size(29, 32);
            Lbl_M12.TabIndex = 41;
            Lbl_M12.Text = "A";
            // 
            // Lbl_M11
            // 
            Lbl_M11.AutoSize = true;
            Lbl_M11.Font = new Font("Segoe UI", 9F);
            Lbl_M11.Location = new Point(41, 52);
            Lbl_M11.Name = "Lbl_M11";
            Lbl_M11.Size = new Size(29, 32);
            Lbl_M11.TabIndex = 40;
            Lbl_M11.Text = "A";
            // 
            // Btn_CopyResult
            // 
            Btn_CopyResult.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_CopyResult.Location = new Point(539, 594);
            Btn_CopyResult.Name = "Btn_CopyResult";
            Btn_CopyResult.Size = new Size(187, 46);
            Btn_CopyResult.TabIndex = 60;
            Btn_CopyResult.Text = "Copy Result";
            Btn_CopyResult.UseVisualStyleBackColor = true;
            // 
            // Gb_TextInput
            // 
            Gb_TextInput.Controls.Add(Btn_BrowseText);
            Gb_TextInput.Controls.Add(Lbl_ImportFileSrc);
            Gb_TextInput.Controls.Add(Btn_ClearInputText);
            Gb_TextInput.Controls.Add(Lbl_SrcTextInput);
            Gb_TextInput.Controls.Add(Btn_Paste);
            Gb_TextInput.Controls.Add(Rtb_SrcTextInput);
            Gb_TextInput.Location = new Point(33, 36);
            Gb_TextInput.Name = "Gb_TextInput";
            Gb_TextInput.Size = new Size(520, 397);
            Gb_TextInput.TabIndex = 61;
            Gb_TextInput.TabStop = false;
            Gb_TextInput.Text = "Text Input";
            // 
            // Btn_BrowseText
            // 
            Btn_BrowseText.Font = new Font("Segoe UI", 9F);
            Btn_BrowseText.Location = new Point(188, 329);
            Btn_BrowseText.Name = "Btn_BrowseText";
            Btn_BrowseText.Size = new Size(135, 46);
            Btn_BrowseText.TabIndex = 61;
            Btn_BrowseText.Text = "Browse";
            Btn_BrowseText.UseVisualStyleBackColor = true;
            // 
            // Lbl_ImportFileSrc
            // 
            Lbl_ImportFileSrc.AutoSize = true;
            Lbl_ImportFileSrc.Font = new Font("Segoe UI", 9F);
            Lbl_ImportFileSrc.Location = new Point(35, 336);
            Lbl_ImportFileSrc.Name = "Lbl_ImportFileSrc";
            Lbl_ImportFileSrc.Size = new Size(130, 32);
            Lbl_ImportFileSrc.TabIndex = 60;
            Lbl_ImportFileSrc.Text = "Import file:";
            // 
            // Btn_ClearInputText
            // 
            Btn_ClearInputText.Font = new Font("Segoe UI", 9F);
            Btn_ClearInputText.Location = new Point(360, 42);
            Btn_ClearInputText.Name = "Btn_ClearInputText";
            Btn_ClearInputText.Size = new Size(135, 46);
            Btn_ClearInputText.TabIndex = 59;
            Btn_ClearInputText.Text = "Clear";
            Btn_ClearInputText.UseVisualStyleBackColor = true;
            // 
            // Lbl_SrcTextInput
            // 
            Lbl_SrcTextInput.AutoSize = true;
            Lbl_SrcTextInput.Font = new Font("Segoe UI", 9F);
            Lbl_SrcTextInput.Location = new Point(35, 48);
            Lbl_SrcTextInput.Name = "Lbl_SrcTextInput";
            Lbl_SrcTextInput.Size = new Size(121, 32);
            Lbl_SrcTextInput.TabIndex = 58;
            Lbl_SrcTextInput.Text = "Enter text:";
            // 
            // Btn_Paste
            // 
            Btn_Paste.Font = new Font("Segoe UI", 9F);
            Btn_Paste.Location = new Point(201, 42);
            Btn_Paste.Name = "Btn_Paste";
            Btn_Paste.Size = new Size(135, 46);
            Btn_Paste.TabIndex = 57;
            Btn_Paste.Text = "Paste";
            Btn_Paste.UseVisualStyleBackColor = true;
            // 
            // Rtb_SrcTextInput
            // 
            Rtb_SrcTextInput.Font = new Font("Segoe UI", 9F);
            Rtb_SrcTextInput.Location = new Point(35, 97);
            Rtb_SrcTextInput.Name = "Rtb_SrcTextInput";
            Rtb_SrcTextInput.Size = new Size(460, 199);
            Rtb_SrcTextInput.TabIndex = 56;
            Rtb_SrcTextInput.Text = "";
            // 
            // PlayFairControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Gb_TextInput);
            Controls.Add(Btn_CopyResult);
            Controls.Add(Gb_KeyInput);
            Controls.Add(Btn_Decrypt);
            Controls.Add(Rtb_Result);
            Controls.Add(Lbl_Result);
            Controls.Add(Btn_Encrypt);
            Name = "PlayFairControl";
            Size = new Size(1300, 1000);
            Gb_KeyInput.ResumeLayout(false);
            Gb_KeyMatrix.ResumeLayout(false);
            Gb_KeyMatrix.PerformLayout();
            Gb_TextInput.ResumeLayout(false);
            Gb_TextInput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBrowse;
        private Label lblFileSrc;
        private Button btnClearInputText;
        private Button Btn_Encrypt;
        private Label lblInputSrcText;
        private Label txtInputKey;
        private Button btnPaste;
        private RichTextBox rtbInputSrcText;
        private TextBox textBox1;
        private RichTextBox Rtb_Result;
        private Label Lbl_Result;
        private Button Btn_Decrypt;
        private GroupBox Gb_KeyInput;
        private GroupBox Gb_KeyMatrix;
        private Label Lbl_M53;
        private Label Lbl_M54;
        private Label Lbl_M55;
        private Label Lbl_M52;
        private Label Lbl_M51;
        private Label Lbl_M43;
        private Label Lbl_M44;
        private Label Lbl_M45;
        private Label Lbl_M42;
        private Label Lbl_M41;
        private Label Lbl_M33;
        private Label Lbl_M34;
        private Label Lbl_M35;
        private Label Lbl_M32;
        private Label Lbl_M31;
        private Label Lbl_M23;
        private Label Lbl_M24;
        private Label Lbl_M25;
        private Label Lbl_M22;
        private Label Lbl_M21;
        private Label Lbl_M13;
        private Label Lbl_M14;
        private Label Lbl_M15;
        private Label Lbl_M12;
        private Label Lbl_M11;
        private Button Btn_CopyResult;
        private GroupBox Gb_TextInput;
        private Button Btn_BrowseText;
        private Label Lbl_ImportFileSrc;
        private Button Btn_ClearInputText;
        private Label Lbl_SrcTextInput;
        private Button Btn_Paste;
        private RichTextBox Rtb_SrcTextInput;
    }
}
