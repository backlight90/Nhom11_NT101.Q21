namespace Nhom11_NT101.Q21.Controls.RSA
{
    partial class RSAControl
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
            TbCtrl_RSAControl = new TabControl();
            tabPage1 = new TabPage();
            Gb_ViewGeneratedKeys = new GroupBox();
            Btn_CopyPrivateKey = new Button();
            Rtb_PrivateKey = new RichTextBox();
            Lbl_PrivateKey = new Label();
            Btn_CopyPublicKey = new Button();
            Rtb_PublicKey = new RichTextBox();
            Lbl_PublicKey = new Label();
            Gb_SaveKeys = new GroupBox();
            Btn_ExportPrivateKey = new Button();
            Btn_ExportPublicKey = new Button();
            Tb_PINInputSaveKeys = new TextBox();
            Lbl_PIN = new Label();
            Gb_KeyPairGenerator = new GroupBox();
            Btn_GenerateKeyPair = new Button();
            Cbb_KeySize = new ComboBox();
            Lbl_KeySize = new Label();
            tabPage2 = new TabPage();
            Gb_TextInput = new GroupBox();
            Btn_BrowseText = new Button();
            Lbl_ImportFileSrc = new Label();
            Btn_ClearInputText = new Button();
            Lbl_SrcTextInput = new Label();
            Btn_Paste = new Button();
            Rtb_SrcTextInput = new RichTextBox();
            Btn_CopyResult = new Button();
            Rtb_Result = new RichTextBox();
            Lbl_Result = new Label();
            Gb_KeyInput = new GroupBox();
            Btn_Decrypt = new Button();
            Tb_PINKeyInput = new TextBox();
            Lbl_PINKeyInput = new Label();
            Rtb_KeyInput = new RichTextBox();
            Btn_BrowseKey = new Button();
            Btn_Encrypt = new Button();
            Lbl_KeyInput = new Label();
            TbCtrl_RSAControl.SuspendLayout();
            tabPage1.SuspendLayout();
            Gb_ViewGeneratedKeys.SuspendLayout();
            Gb_SaveKeys.SuspendLayout();
            Gb_KeyPairGenerator.SuspendLayout();
            tabPage2.SuspendLayout();
            Gb_TextInput.SuspendLayout();
            Gb_KeyInput.SuspendLayout();
            SuspendLayout();
            // 
            // TbCtrl_RSAControl
            // 
            TbCtrl_RSAControl.Controls.Add(tabPage1);
            TbCtrl_RSAControl.Controls.Add(tabPage2);
            TbCtrl_RSAControl.Dock = DockStyle.Fill;
            TbCtrl_RSAControl.Location = new Point(0, 0);
            TbCtrl_RSAControl.Name = "TbCtrl_RSAControl";
            TbCtrl_RSAControl.SelectedIndex = 0;
            TbCtrl_RSAControl.Size = new Size(1300, 1000);
            TbCtrl_RSAControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Gb_ViewGeneratedKeys);
            tabPage1.Controls.Add(Gb_SaveKeys);
            tabPage1.Controls.Add(Gb_KeyPairGenerator);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1284, 946);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Key Management";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Gb_ViewGeneratedKeys
            // 
            Gb_ViewGeneratedKeys.Controls.Add(Btn_CopyPrivateKey);
            Gb_ViewGeneratedKeys.Controls.Add(Rtb_PrivateKey);
            Gb_ViewGeneratedKeys.Controls.Add(Lbl_PrivateKey);
            Gb_ViewGeneratedKeys.Controls.Add(Btn_CopyPublicKey);
            Gb_ViewGeneratedKeys.Controls.Add(Rtb_PublicKey);
            Gb_ViewGeneratedKeys.Controls.Add(Lbl_PublicKey);
            Gb_ViewGeneratedKeys.Location = new Point(29, 360);
            Gb_ViewGeneratedKeys.Name = "Gb_ViewGeneratedKeys";
            Gb_ViewGeneratedKeys.Size = new Size(1212, 532);
            Gb_ViewGeneratedKeys.TabIndex = 2;
            Gb_ViewGeneratedKeys.TabStop = false;
            Gb_ViewGeneratedKeys.Text = "View Generated Keys (XML Format)";
            // 
            // Btn_CopyPrivateKey
            // 
            Btn_CopyPrivateKey.Location = new Point(977, 301);
            Btn_CopyPrivateKey.Name = "Btn_CopyPrivateKey";
            Btn_CopyPrivateKey.Size = new Size(215, 46);
            Btn_CopyPrivateKey.TabIndex = 7;
            Btn_CopyPrivateKey.Text = "Copy Private Key";
            Btn_CopyPrivateKey.UseVisualStyleBackColor = true;
            // 
            // Rtb_PrivateKey
            // 
            Rtb_PrivateKey.Location = new Point(24, 361);
            Rtb_PrivateKey.Name = "Rtb_PrivateKey";
            Rtb_PrivateKey.Size = new Size(1168, 115);
            Rtb_PrivateKey.TabIndex = 8;
            Rtb_PrivateKey.Text = "";
            // 
            // Lbl_PrivateKey
            // 
            Lbl_PrivateKey.AutoSize = true;
            Lbl_PrivateKey.Location = new Point(24, 315);
            Lbl_PrivateKey.Name = "Lbl_PrivateKey";
            Lbl_PrivateKey.Size = new Size(316, 32);
            Lbl_PrivateKey.TabIndex = 9;
            Lbl_PrivateKey.Text = "Private Key (For Decryption):";
            // 
            // Btn_CopyPublicKey
            // 
            Btn_CopyPublicKey.Location = new Point(977, 69);
            Btn_CopyPublicKey.Name = "Btn_CopyPublicKey";
            Btn_CopyPublicKey.Size = new Size(215, 46);
            Btn_CopyPublicKey.TabIndex = 3;
            Btn_CopyPublicKey.Text = "Copy Public Key";
            Btn_CopyPublicKey.UseVisualStyleBackColor = true;
            // 
            // Rtb_PublicKey
            // 
            Rtb_PublicKey.Location = new Point(24, 129);
            Rtb_PublicKey.Name = "Rtb_PublicKey";
            Rtb_PublicKey.Size = new Size(1168, 115);
            Rtb_PublicKey.TabIndex = 6;
            Rtb_PublicKey.Text = "";
            // 
            // Lbl_PublicKey
            // 
            Lbl_PublicKey.AutoSize = true;
            Lbl_PublicKey.Location = new Point(24, 83);
            Lbl_PublicKey.Name = "Lbl_PublicKey";
            Lbl_PublicKey.Size = new Size(304, 32);
            Lbl_PublicKey.TabIndex = 6;
            Lbl_PublicKey.Text = "Public Key (For Encryption):";
            // 
            // Gb_SaveKeys
            // 
            Gb_SaveKeys.Controls.Add(Btn_ExportPrivateKey);
            Gb_SaveKeys.Controls.Add(Btn_ExportPublicKey);
            Gb_SaveKeys.Controls.Add(Tb_PINInputSaveKeys);
            Gb_SaveKeys.Controls.Add(Lbl_PIN);
            Gb_SaveKeys.Location = new Point(550, 46);
            Gb_SaveKeys.Name = "Gb_SaveKeys";
            Gb_SaveKeys.Size = new Size(691, 260);
            Gb_SaveKeys.TabIndex = 1;
            Gb_SaveKeys.TabStop = false;
            Gb_SaveKeys.Text = "Save Keys to Files";
            // 
            // Btn_ExportPrivateKey
            // 
            Btn_ExportPrivateKey.Location = new Point(383, 154);
            Btn_ExportPrivateKey.Name = "Btn_ExportPrivateKey";
            Btn_ExportPrivateKey.Size = new Size(288, 46);
            Btn_ExportPrivateKey.TabIndex = 5;
            Btn_ExportPrivateKey.Text = "Export Private Key (.xml)";
            Btn_ExportPrivateKey.UseVisualStyleBackColor = true;
            // 
            // Btn_ExportPublicKey
            // 
            Btn_ExportPublicKey.Location = new Point(23, 154);
            Btn_ExportPublicKey.Name = "Btn_ExportPublicKey";
            Btn_ExportPublicKey.Size = new Size(288, 46);
            Btn_ExportPublicKey.TabIndex = 3;
            Btn_ExportPublicKey.Text = "Export Public Key (.xml)";
            Btn_ExportPublicKey.UseVisualStyleBackColor = true;
            // 
            // Tb_PINInputSaveKeys
            // 
            Tb_PINInputSaveKeys.Location = new Point(97, 53);
            Tb_PINInputSaveKeys.Name = "Tb_PINInputSaveKeys";
            Tb_PINInputSaveKeys.Size = new Size(357, 39);
            Tb_PINInputSaveKeys.TabIndex = 4;
            // 
            // Lbl_PIN
            // 
            Lbl_PIN.AutoSize = true;
            Lbl_PIN.Location = new Point(23, 56);
            Lbl_PIN.Name = "Lbl_PIN";
            Lbl_PIN.Size = new Size(56, 32);
            Lbl_PIN.TabIndex = 3;
            Lbl_PIN.Text = "PIN:";
            // 
            // Gb_KeyPairGenerator
            // 
            Gb_KeyPairGenerator.Controls.Add(Btn_GenerateKeyPair);
            Gb_KeyPairGenerator.Controls.Add(Cbb_KeySize);
            Gb_KeyPairGenerator.Controls.Add(Lbl_KeySize);
            Gb_KeyPairGenerator.Location = new Point(29, 37);
            Gb_KeyPairGenerator.Name = "Gb_KeyPairGenerator";
            Gb_KeyPairGenerator.Size = new Size(479, 269);
            Gb_KeyPairGenerator.TabIndex = 0;
            Gb_KeyPairGenerator.TabStop = false;
            Gb_KeyPairGenerator.Text = "Key Pair Generator";
            // 
            // Btn_GenerateKeyPair
            // 
            Btn_GenerateKeyPair.Location = new Point(24, 163);
            Btn_GenerateKeyPair.Name = "Btn_GenerateKeyPair";
            Btn_GenerateKeyPair.Size = new Size(288, 46);
            Btn_GenerateKeyPair.TabIndex = 2;
            Btn_GenerateKeyPair.Text = "Generate Key Pair";
            Btn_GenerateKeyPair.UseVisualStyleBackColor = true;
            // 
            // Cbb_KeySize
            // 
            Cbb_KeySize.FormattingEnabled = true;
            Cbb_KeySize.Items.AddRange(new object[] { "512", "1024" });
            Cbb_KeySize.Location = new Point(214, 65);
            Cbb_KeySize.Name = "Cbb_KeySize";
            Cbb_KeySize.Size = new Size(242, 40);
            Cbb_KeySize.TabIndex = 1;
            // 
            // Lbl_KeySize
            // 
            Lbl_KeySize.AutoSize = true;
            Lbl_KeySize.Location = new Point(24, 65);
            Lbl_KeySize.Name = "Lbl_KeySize";
            Lbl_KeySize.Size = new Size(167, 32);
            Lbl_KeySize.TabIndex = 0;
            Lbl_KeySize.Text = "Key Size (Bits):";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(Gb_TextInput);
            tabPage2.Controls.Add(Btn_CopyResult);
            tabPage2.Controls.Add(Rtb_Result);
            tabPage2.Controls.Add(Lbl_Result);
            tabPage2.Controls.Add(Gb_KeyInput);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1284, 946);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Encryption & Decryption";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Gb_TextInput
            // 
            Gb_TextInput.Controls.Add(Btn_BrowseText);
            Gb_TextInput.Controls.Add(Lbl_ImportFileSrc);
            Gb_TextInput.Controls.Add(Btn_ClearInputText);
            Gb_TextInput.Controls.Add(Lbl_SrcTextInput);
            Gb_TextInput.Controls.Add(Btn_Paste);
            Gb_TextInput.Controls.Add(Rtb_SrcTextInput);
            Gb_TextInput.Location = new Point(34, 38);
            Gb_TextInput.Name = "Gb_TextInput";
            Gb_TextInput.Size = new Size(520, 397);
            Gb_TextInput.TabIndex = 60;
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
            // Btn_CopyResult
            // 
            Btn_CopyResult.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_CopyResult.Location = new Point(1067, 478);
            Btn_CopyResult.Name = "Btn_CopyResult";
            Btn_CopyResult.Size = new Size(187, 46);
            Btn_CopyResult.TabIndex = 59;
            Btn_CopyResult.Text = "Copy Result";
            Btn_CopyResult.UseVisualStyleBackColor = true;
            // 
            // Rtb_Result
            // 
            Rtb_Result.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Rtb_Result.Location = new Point(34, 539);
            Rtb_Result.Name = "Rtb_Result";
            Rtb_Result.ReadOnly = true;
            Rtb_Result.Size = new Size(1229, 333);
            Rtb_Result.TabIndex = 58;
            Rtb_Result.Text = "";
            // 
            // Lbl_Result
            // 
            Lbl_Result.AutoSize = true;
            Lbl_Result.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Result.Location = new Point(34, 484);
            Lbl_Result.Name = "Lbl_Result";
            Lbl_Result.Size = new Size(99, 40);
            Lbl_Result.TabIndex = 57;
            Lbl_Result.Text = "Result:";
            // 
            // Gb_KeyInput
            // 
            Gb_KeyInput.Controls.Add(Btn_Decrypt);
            Gb_KeyInput.Controls.Add(Tb_PINKeyInput);
            Gb_KeyInput.Controls.Add(Lbl_PINKeyInput);
            Gb_KeyInput.Controls.Add(Rtb_KeyInput);
            Gb_KeyInput.Controls.Add(Btn_BrowseKey);
            Gb_KeyInput.Controls.Add(Btn_Encrypt);
            Gb_KeyInput.Controls.Add(Lbl_KeyInput);
            Gb_KeyInput.Location = new Point(610, 38);
            Gb_KeyInput.Name = "Gb_KeyInput";
            Gb_KeyInput.Size = new Size(653, 334);
            Gb_KeyInput.TabIndex = 56;
            Gb_KeyInput.TabStop = false;
            Gb_KeyInput.Text = "Key Input";
            // 
            // Btn_Decrypt
            // 
            Btn_Decrypt.Location = new Point(350, 260);
            Btn_Decrypt.Name = "Btn_Decrypt";
            Btn_Decrypt.Size = new Size(189, 46);
            Btn_Decrypt.TabIndex = 60;
            Btn_Decrypt.Text = "Decrypt";
            Btn_Decrypt.UseVisualStyleBackColor = true;
            // 
            // Tb_PINKeyInput
            // 
            Tb_PINKeyInput.Location = new Point(101, 147);
            Tb_PINKeyInput.Name = "Tb_PINKeyInput";
            Tb_PINKeyInput.Size = new Size(389, 39);
            Tb_PINKeyInput.TabIndex = 59;
            // 
            // Lbl_PINKeyInput
            // 
            Lbl_PINKeyInput.AutoSize = true;
            Lbl_PINKeyInput.Location = new Point(23, 150);
            Lbl_PINKeyInput.Name = "Lbl_PINKeyInput";
            Lbl_PINKeyInput.Size = new Size(56, 32);
            Lbl_PINKeyInput.TabIndex = 58;
            Lbl_PINKeyInput.Text = "PIN:";
            // 
            // Rtb_KeyInput
            // 
            Rtb_KeyInput.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Rtb_KeyInput.Location = new Point(101, 56);
            Rtb_KeyInput.Name = "Rtb_KeyInput";
            Rtb_KeyInput.Size = new Size(389, 48);
            Rtb_KeyInput.TabIndex = 57;
            Rtb_KeyInput.Text = "";
            // 
            // Btn_BrowseKey
            // 
            Btn_BrowseKey.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_BrowseKey.Location = new Point(507, 56);
            Btn_BrowseKey.Name = "Btn_BrowseKey";
            Btn_BrowseKey.Size = new Size(127, 46);
            Btn_BrowseKey.TabIndex = 57;
            Btn_BrowseKey.Text = "Browse";
            Btn_BrowseKey.UseVisualStyleBackColor = true;
            // 
            // Btn_Encrypt
            // 
            Btn_Encrypt.Location = new Point(101, 260);
            Btn_Encrypt.Name = "Btn_Encrypt";
            Btn_Encrypt.Size = new Size(189, 46);
            Btn_Encrypt.TabIndex = 3;
            Btn_Encrypt.Text = "Encrypt";
            Btn_Encrypt.UseVisualStyleBackColor = true;
            // 
            // Lbl_KeyInput
            // 
            Lbl_KeyInput.AutoSize = true;
            Lbl_KeyInput.Location = new Point(23, 56);
            Lbl_KeyInput.Name = "Lbl_KeyInput";
            Lbl_KeyInput.Size = new Size(58, 32);
            Lbl_KeyInput.TabIndex = 3;
            Lbl_KeyInput.Text = "Key:";
            // 
            // RSAControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TbCtrl_RSAControl);
            Name = "RSAControl";
            Size = new Size(1300, 1000);
            TbCtrl_RSAControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            Gb_ViewGeneratedKeys.ResumeLayout(false);
            Gb_ViewGeneratedKeys.PerformLayout();
            Gb_SaveKeys.ResumeLayout(false);
            Gb_SaveKeys.PerformLayout();
            Gb_KeyPairGenerator.ResumeLayout(false);
            Gb_KeyPairGenerator.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            Gb_TextInput.ResumeLayout(false);
            Gb_TextInput.PerformLayout();
            Gb_KeyInput.ResumeLayout(false);
            Gb_KeyInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TbCtrl_RSAControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox Gb_ViewGeneratedKeys;
        private GroupBox Gb_SaveKeys;
        private GroupBox Gb_KeyPairGenerator;
        private Button Btn_GenerateKeyPair;
        private ComboBox Cbb_KeySize;
        private Label Lbl_KeySize;
        private Button Btn_CopyPrivateKey;
        private RichTextBox Rtb_PrivateKey;
        private Label Lbl_PrivateKey;
        private Button Btn_CopyPublicKey;
        private RichTextBox Rtb_PublicKey;
        private Label Lbl_PublicKey;
        private Button Btn_ExportPrivateKey;
        private Button Btn_ExportPublicKey;
        private TextBox Tb_PINInputSaveKeys;
        private Label Lbl_PIN;
        private GroupBox Gb_KeyInput;
        private RichTextBox Rtb_KeyInput;
        private Button Btn_BrowseKey;
        private Button Btn_Encrypt;
        private Label Lbl_KeyInput;
        private Button Btn_Decrypt;
        private TextBox Tb_PINKeyInput;
        private Label Lbl_PINKeyInput;
        private Button Btn_CopyResult;
        private RichTextBox Rtb_Result;
        private Label Lbl_Result;
        private GroupBox Gb_TextInput;
        private Button Btn_BrowseText;
        private Label Lbl_ImportFileSrc;
        private Button Btn_ClearInputText;
        private Label Lbl_SrcTextInput;
        private Button Btn_Paste;
        private RichTextBox Rtb_SrcTextInput;
    }
}
