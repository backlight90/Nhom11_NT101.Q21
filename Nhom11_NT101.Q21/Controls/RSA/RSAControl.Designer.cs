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
            tabPage3 = new TabPage();
            Gb_SignatureTextInput = new GroupBox();
            Btn_BrowseSignatureText = new Button();
            Lbl_ImportFileSignature = new Label();
            Btn_ClearSignatureInputText = new Button();
            Lbl_SignatureTextInput = new Label();
            Btn_PasteSignature = new Button();
            Rtb_SignatureTextInput = new RichTextBox();
            Gb_SignatureKeyInput = new GroupBox();
            Btn_Verify = new Button();
            Btn_Sign = new Button();
            Rtb_SignatureKeyInput = new RichTextBox();
            Btn_BrowseSignatureKey = new Button();
            Lbl_SignatureKeyInput = new Label();
            Btn_CopySignatureResult = new Button();
            Rtb_SignatureResult = new RichTextBox();
            Lbl_SignatureResult = new Label();
            Rtb_SignatureInput = new RichTextBox();
            Lbl_SignatureInput = new Label();
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
            tabPage3.SuspendLayout();
            Gb_SignatureTextInput.SuspendLayout();
            Gb_SignatureKeyInput.SuspendLayout();
            SuspendLayout();
            // 
            // TbCtrl_RSAControl
            // 
            TbCtrl_RSAControl.Controls.Add(tabPage1);
            TbCtrl_RSAControl.Controls.Add(tabPage2);
            TbCtrl_RSAControl.Controls.Add(tabPage3);
            TbCtrl_RSAControl.Dock = DockStyle.Fill;
            TbCtrl_RSAControl.Location = new Point(0, 0);
            TbCtrl_RSAControl.Margin = new Padding(2, 1, 2, 1);
            TbCtrl_RSAControl.Name = "TbCtrl_RSAControl";
            TbCtrl_RSAControl.SelectedIndex = 0;
            TbCtrl_RSAControl.Size = new Size(700, 469);
            TbCtrl_RSAControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Gb_ViewGeneratedKeys);
            tabPage1.Controls.Add(Gb_SaveKeys);
            tabPage1.Controls.Add(Gb_KeyPairGenerator);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2, 1, 2, 1);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 1, 2, 1);
            tabPage1.Size = new Size(692, 441);
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
            Gb_ViewGeneratedKeys.Location = new Point(16, 169);
            Gb_ViewGeneratedKeys.Margin = new Padding(2, 1, 2, 1);
            Gb_ViewGeneratedKeys.Name = "Gb_ViewGeneratedKeys";
            Gb_ViewGeneratedKeys.Padding = new Padding(2, 1, 2, 1);
            Gb_ViewGeneratedKeys.Size = new Size(653, 249);
            Gb_ViewGeneratedKeys.TabIndex = 2;
            Gb_ViewGeneratedKeys.TabStop = false;
            Gb_ViewGeneratedKeys.Text = "View Generated Keys (XML Format)";
            // 
            // Btn_CopyPrivateKey
            // 
            Btn_CopyPrivateKey.Location = new Point(526, 141);
            Btn_CopyPrivateKey.Margin = new Padding(2, 1, 2, 1);
            Btn_CopyPrivateKey.Name = "Btn_CopyPrivateKey";
            Btn_CopyPrivateKey.Size = new Size(116, 22);
            Btn_CopyPrivateKey.TabIndex = 7;
            Btn_CopyPrivateKey.Text = "Copy Private Key";
            Btn_CopyPrivateKey.UseVisualStyleBackColor = true;
            Btn_CopyPrivateKey.Click += Btn_CopyPrivateKey_Click;
            // 
            // Rtb_PrivateKey
            // 
            Rtb_PrivateKey.Location = new Point(13, 169);
            Rtb_PrivateKey.Margin = new Padding(2, 1, 2, 1);
            Rtb_PrivateKey.Name = "Rtb_PrivateKey";
            Rtb_PrivateKey.Size = new Size(631, 56);
            Rtb_PrivateKey.TabIndex = 8;
            Rtb_PrivateKey.Text = "";
            // 
            // Lbl_PrivateKey
            // 
            Lbl_PrivateKey.AutoSize = true;
            Lbl_PrivateKey.Location = new Point(13, 148);
            Lbl_PrivateKey.Margin = new Padding(2, 0, 2, 0);
            Lbl_PrivateKey.Name = "Lbl_PrivateKey";
            Lbl_PrivateKey.Size = new Size(157, 15);
            Lbl_PrivateKey.TabIndex = 9;
            Lbl_PrivateKey.Text = "Private Key (For Decryption):";
            // 
            // Btn_CopyPublicKey
            // 
            Btn_CopyPublicKey.Location = new Point(526, 32);
            Btn_CopyPublicKey.Margin = new Padding(2, 1, 2, 1);
            Btn_CopyPublicKey.Name = "Btn_CopyPublicKey";
            Btn_CopyPublicKey.Size = new Size(116, 22);
            Btn_CopyPublicKey.TabIndex = 3;
            Btn_CopyPublicKey.Text = "Copy Public Key";
            Btn_CopyPublicKey.UseVisualStyleBackColor = true;
            Btn_CopyPublicKey.Click += Btn_CopyPublicKey_Click;
            // 
            // Rtb_PublicKey
            // 
            Rtb_PublicKey.Location = new Point(13, 60);
            Rtb_PublicKey.Margin = new Padding(2, 1, 2, 1);
            Rtb_PublicKey.Name = "Rtb_PublicKey";
            Rtb_PublicKey.Size = new Size(631, 56);
            Rtb_PublicKey.TabIndex = 6;
            Rtb_PublicKey.Text = "";
            // 
            // Lbl_PublicKey
            // 
            Lbl_PublicKey.AutoSize = true;
            Lbl_PublicKey.Location = new Point(13, 39);
            Lbl_PublicKey.Margin = new Padding(2, 0, 2, 0);
            Lbl_PublicKey.Name = "Lbl_PublicKey";
            Lbl_PublicKey.Size = new Size(153, 15);
            Lbl_PublicKey.TabIndex = 6;
            Lbl_PublicKey.Text = "Public Key (For Encryption):";
            // 
            // Gb_SaveKeys
            // 
            Gb_SaveKeys.Controls.Add(Btn_ExportPrivateKey);
            Gb_SaveKeys.Controls.Add(Btn_ExportPublicKey);
            Gb_SaveKeys.Controls.Add(Tb_PINInputSaveKeys);
            Gb_SaveKeys.Controls.Add(Lbl_PIN);
            Gb_SaveKeys.Location = new Point(296, 22);
            Gb_SaveKeys.Margin = new Padding(2, 1, 2, 1);
            Gb_SaveKeys.Name = "Gb_SaveKeys";
            Gb_SaveKeys.Padding = new Padding(2, 1, 2, 1);
            Gb_SaveKeys.Size = new Size(372, 122);
            Gb_SaveKeys.TabIndex = 1;
            Gb_SaveKeys.TabStop = false;
            Gb_SaveKeys.Text = "Save Keys to Files";
            // 
            // Btn_ExportPrivateKey
            // 
            Btn_ExportPrivateKey.Location = new Point(206, 72);
            Btn_ExportPrivateKey.Margin = new Padding(2, 1, 2, 1);
            Btn_ExportPrivateKey.Name = "Btn_ExportPrivateKey";
            Btn_ExportPrivateKey.Size = new Size(155, 22);
            Btn_ExportPrivateKey.TabIndex = 5;
            Btn_ExportPrivateKey.Text = "Export Private Key (.xml)";
            Btn_ExportPrivateKey.UseVisualStyleBackColor = true;
            Btn_ExportPrivateKey.Click += Btn_ExportPrivateKey_Click;
            // 
            // Btn_ExportPublicKey
            // 
            Btn_ExportPublicKey.Location = new Point(12, 72);
            Btn_ExportPublicKey.Margin = new Padding(2, 1, 2, 1);
            Btn_ExportPublicKey.Name = "Btn_ExportPublicKey";
            Btn_ExportPublicKey.Size = new Size(155, 22);
            Btn_ExportPublicKey.TabIndex = 3;
            Btn_ExportPublicKey.Text = "Export Public Key (.xml)";
            Btn_ExportPublicKey.UseVisualStyleBackColor = true;
            Btn_ExportPublicKey.Click += Btn_ExportPublicKey_Click;
            // 
            // Tb_PINInputSaveKeys
            // 
            Tb_PINInputSaveKeys.Location = new Point(52, 25);
            Tb_PINInputSaveKeys.Margin = new Padding(2, 1, 2, 1);
            Tb_PINInputSaveKeys.Name = "Tb_PINInputSaveKeys";
            Tb_PINInputSaveKeys.Size = new Size(194, 23);
            Tb_PINInputSaveKeys.TabIndex = 4;
            // 
            // Lbl_PIN
            // 
            Lbl_PIN.AutoSize = true;
            Lbl_PIN.Location = new Point(12, 26);
            Lbl_PIN.Margin = new Padding(2, 0, 2, 0);
            Lbl_PIN.Name = "Lbl_PIN";
            Lbl_PIN.Size = new Size(29, 15);
            Lbl_PIN.TabIndex = 3;
            Lbl_PIN.Text = "PIN:";
            // 
            // Gb_KeyPairGenerator
            // 
            Gb_KeyPairGenerator.Controls.Add(Btn_GenerateKeyPair);
            Gb_KeyPairGenerator.Controls.Add(Cbb_KeySize);
            Gb_KeyPairGenerator.Controls.Add(Lbl_KeySize);
            Gb_KeyPairGenerator.Location = new Point(16, 17);
            Gb_KeyPairGenerator.Margin = new Padding(2, 1, 2, 1);
            Gb_KeyPairGenerator.Name = "Gb_KeyPairGenerator";
            Gb_KeyPairGenerator.Padding = new Padding(2, 1, 2, 1);
            Gb_KeyPairGenerator.Size = new Size(258, 126);
            Gb_KeyPairGenerator.TabIndex = 0;
            Gb_KeyPairGenerator.TabStop = false;
            Gb_KeyPairGenerator.Text = "Key Pair Generator";
            // 
            // Btn_GenerateKeyPair
            // 
            Btn_GenerateKeyPair.Location = new Point(13, 76);
            Btn_GenerateKeyPair.Margin = new Padding(2, 1, 2, 1);
            Btn_GenerateKeyPair.Name = "Btn_GenerateKeyPair";
            Btn_GenerateKeyPair.Size = new Size(155, 22);
            Btn_GenerateKeyPair.TabIndex = 2;
            Btn_GenerateKeyPair.Text = "Generate Key Pair";
            Btn_GenerateKeyPair.UseVisualStyleBackColor = true;
            Btn_GenerateKeyPair.Click += Btn_GenerateKeyPair_Click;
            // 
            // Cbb_KeySize
            // 
            Cbb_KeySize.FormattingEnabled = true;
            Cbb_KeySize.Items.AddRange(new object[] { "512", "1024" });
            Cbb_KeySize.Location = new Point(115, 30);
            Cbb_KeySize.Margin = new Padding(2, 1, 2, 1);
            Cbb_KeySize.Name = "Cbb_KeySize";
            Cbb_KeySize.Size = new Size(132, 23);
            Cbb_KeySize.TabIndex = 1;
            // 
            // Lbl_KeySize
            // 
            Lbl_KeySize.AutoSize = true;
            Lbl_KeySize.Location = new Point(13, 30);
            Lbl_KeySize.Margin = new Padding(2, 0, 2, 0);
            Lbl_KeySize.Name = "Lbl_KeySize";
            Lbl_KeySize.Size = new Size(82, 15);
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
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2, 1, 2, 1);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 1, 2, 1);
            tabPage2.Size = new Size(692, 441);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Encryption & Decryption";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(Gb_SignatureTextInput);
            tabPage3.Controls.Add(Btn_CopySignatureResult);
            tabPage3.Controls.Add(Rtb_SignatureResult);
            tabPage3.Controls.Add(Lbl_SignatureResult);
            tabPage3.Controls.Add(Gb_SignatureKeyInput);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(2, 1, 2, 1);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(2, 1, 2, 1);
            tabPage3.Size = new Size(692, 441);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Digital Signature";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Gb_TextInput
            // 
            Gb_TextInput.Controls.Add(Btn_BrowseText);
            Gb_TextInput.Controls.Add(Lbl_ImportFileSrc);
            Gb_TextInput.Controls.Add(Btn_ClearInputText);
            Gb_TextInput.Controls.Add(Lbl_SrcTextInput);
            Gb_TextInput.Controls.Add(Btn_Paste);
            Gb_TextInput.Controls.Add(Rtb_SrcTextInput);
            Gb_TextInput.Location = new Point(18, 18);
            Gb_TextInput.Margin = new Padding(2, 1, 2, 1);
            Gb_TextInput.Name = "Gb_TextInput";
            Gb_TextInput.Padding = new Padding(2, 1, 2, 1);
            Gb_TextInput.Size = new Size(280, 186);
            Gb_TextInput.TabIndex = 60;
            Gb_TextInput.TabStop = false;
            Gb_TextInput.Text = "Text Input";
            // 
            // Btn_BrowseText
            // 
            Btn_BrowseText.Font = new Font("Segoe UI", 9F);
            Btn_BrowseText.Location = new Point(101, 154);
            Btn_BrowseText.Margin = new Padding(2, 1, 2, 1);
            Btn_BrowseText.Name = "Btn_BrowseText";
            Btn_BrowseText.Size = new Size(73, 22);
            Btn_BrowseText.TabIndex = 61;
            Btn_BrowseText.Text = "Browse";
            Btn_BrowseText.UseVisualStyleBackColor = true;
            Btn_BrowseText.Click += Btn_BrowseText_Click;
            // 
            // Lbl_ImportFileSrc
            // 
            Lbl_ImportFileSrc.AutoSize = true;
            Lbl_ImportFileSrc.Font = new Font("Segoe UI", 9F);
            Lbl_ImportFileSrc.Location = new Point(19, 158);
            Lbl_ImportFileSrc.Margin = new Padding(2, 0, 2, 0);
            Lbl_ImportFileSrc.Name = "Lbl_ImportFileSrc";
            Lbl_ImportFileSrc.Size = new Size(65, 15);
            Lbl_ImportFileSrc.TabIndex = 60;
            Lbl_ImportFileSrc.Text = "Import file:";
            // 
            // Btn_ClearInputText
            // 
            Btn_ClearInputText.Font = new Font("Segoe UI", 9F);
            Btn_ClearInputText.Location = new Point(194, 20);
            Btn_ClearInputText.Margin = new Padding(2, 1, 2, 1);
            Btn_ClearInputText.Name = "Btn_ClearInputText";
            Btn_ClearInputText.Size = new Size(73, 22);
            Btn_ClearInputText.TabIndex = 59;
            Btn_ClearInputText.Text = "Clear";
            Btn_ClearInputText.UseVisualStyleBackColor = true;
            Btn_ClearInputText.Click += Btn_ClearInputText_Click;
            // 
            // Lbl_SrcTextInput
            // 
            Lbl_SrcTextInput.AutoSize = true;
            Lbl_SrcTextInput.Font = new Font("Segoe UI", 9F);
            Lbl_SrcTextInput.Location = new Point(19, 22);
            Lbl_SrcTextInput.Margin = new Padding(2, 0, 2, 0);
            Lbl_SrcTextInput.Name = "Lbl_SrcTextInput";
            Lbl_SrcTextInput.Size = new Size(59, 15);
            Lbl_SrcTextInput.TabIndex = 58;
            Lbl_SrcTextInput.Text = "Enter text:";
            // 
            // Btn_Paste
            // 
            Btn_Paste.Font = new Font("Segoe UI", 9F);
            Btn_Paste.Location = new Point(108, 20);
            Btn_Paste.Margin = new Padding(2, 1, 2, 1);
            Btn_Paste.Name = "Btn_Paste";
            Btn_Paste.Size = new Size(73, 22);
            Btn_Paste.TabIndex = 57;
            Btn_Paste.Text = "Paste";
            Btn_Paste.UseVisualStyleBackColor = true;
            Btn_Paste.Click += Btn_Paste_Click;
            // 
            // Rtb_SrcTextInput
            // 
            Rtb_SrcTextInput.Font = new Font("Segoe UI", 9F);
            Rtb_SrcTextInput.Location = new Point(19, 45);
            Rtb_SrcTextInput.Margin = new Padding(2, 1, 2, 1);
            Rtb_SrcTextInput.Name = "Rtb_SrcTextInput";
            Rtb_SrcTextInput.Size = new Size(250, 95);
            Rtb_SrcTextInput.TabIndex = 56;
            Rtb_SrcTextInput.Text = "";
            // 
            // Btn_CopyResult
            // 
            Btn_CopyResult.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_CopyResult.Location = new Point(575, 224);
            Btn_CopyResult.Margin = new Padding(2, 1, 2, 1);
            Btn_CopyResult.Name = "Btn_CopyResult";
            Btn_CopyResult.Size = new Size(101, 22);
            Btn_CopyResult.TabIndex = 59;
            Btn_CopyResult.Text = "Copy Result";
            Btn_CopyResult.UseVisualStyleBackColor = true;
            Btn_CopyResult.Click += Btn_CopyResult_Click;
            // 
            // Rtb_Result
            // 
            Rtb_Result.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Rtb_Result.Location = new Point(18, 253);
            Rtb_Result.Margin = new Padding(2, 1, 2, 1);
            Rtb_Result.Name = "Rtb_Result";
            Rtb_Result.ReadOnly = true;
            Rtb_Result.Size = new Size(664, 158);
            Rtb_Result.TabIndex = 58;
            Rtb_Result.Text = "";
            // 
            // Lbl_Result
            // 
            Lbl_Result.AutoSize = true;
            Lbl_Result.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Result.Location = new Point(18, 227);
            Lbl_Result.Margin = new Padding(2, 0, 2, 0);
            Lbl_Result.Name = "Lbl_Result";
            Lbl_Result.Size = new Size(52, 20);
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
            Gb_KeyInput.Location = new Point(328, 18);
            Gb_KeyInput.Margin = new Padding(2, 1, 2, 1);
            Gb_KeyInput.Name = "Gb_KeyInput";
            Gb_KeyInput.Padding = new Padding(2, 1, 2, 1);
            Gb_KeyInput.Size = new Size(352, 157);
            Gb_KeyInput.TabIndex = 56;
            Gb_KeyInput.TabStop = false;
            Gb_KeyInput.Text = "Key Input";
            // 
            // Btn_Decrypt
            // 
            Btn_Decrypt.Location = new Point(188, 122);
            Btn_Decrypt.Margin = new Padding(2, 1, 2, 1);
            Btn_Decrypt.Name = "Btn_Decrypt";
            Btn_Decrypt.Size = new Size(102, 22);
            Btn_Decrypt.TabIndex = 60;
            Btn_Decrypt.Text = "Decrypt";
            Btn_Decrypt.UseVisualStyleBackColor = true;
            Btn_Decrypt.Click += Btn_Decrypt_Click;
            // 
            // Tb_PINKeyInput
            // 
            Tb_PINKeyInput.Location = new Point(54, 69);
            Tb_PINKeyInput.Margin = new Padding(2, 1, 2, 1);
            Tb_PINKeyInput.Name = "Tb_PINKeyInput";
            Tb_PINKeyInput.Size = new Size(211, 23);
            Tb_PINKeyInput.TabIndex = 59;
            // 
            // Lbl_PINKeyInput
            // 
            Lbl_PINKeyInput.AutoSize = true;
            Lbl_PINKeyInput.Location = new Point(12, 70);
            Lbl_PINKeyInput.Margin = new Padding(2, 0, 2, 0);
            Lbl_PINKeyInput.Name = "Lbl_PINKeyInput";
            Lbl_PINKeyInput.Size = new Size(29, 15);
            Lbl_PINKeyInput.TabIndex = 58;
            Lbl_PINKeyInput.Text = "PIN:";
            // 
            // Rtb_KeyInput
            // 
            Rtb_KeyInput.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Rtb_KeyInput.Location = new Point(54, 26);
            Rtb_KeyInput.Margin = new Padding(2, 1, 2, 1);
            Rtb_KeyInput.Name = "Rtb_KeyInput";
            Rtb_KeyInput.Size = new Size(211, 25);
            Rtb_KeyInput.TabIndex = 57;
            Rtb_KeyInput.Text = "";
            // 
            // Btn_BrowseKey
            // 
            Btn_BrowseKey.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_BrowseKey.Location = new Point(273, 26);
            Btn_BrowseKey.Margin = new Padding(2, 1, 2, 1);
            Btn_BrowseKey.Name = "Btn_BrowseKey";
            Btn_BrowseKey.Size = new Size(68, 22);
            Btn_BrowseKey.TabIndex = 57;
            Btn_BrowseKey.Text = "Browse";
            Btn_BrowseKey.UseVisualStyleBackColor = true;
            Btn_BrowseKey.Click += Btn_BrowseKey_Click;
            // 
            // Btn_Encrypt
            // 
            Btn_Encrypt.Location = new Point(54, 122);
            Btn_Encrypt.Margin = new Padding(2, 1, 2, 1);
            Btn_Encrypt.Name = "Btn_Encrypt";
            Btn_Encrypt.Size = new Size(102, 22);
            Btn_Encrypt.TabIndex = 3;
            Btn_Encrypt.Text = "Encrypt";
            Btn_Encrypt.UseVisualStyleBackColor = true;
            Btn_Encrypt.Click += Btn_Encrypt_Click;
            // 
            // Lbl_KeyInput
            // 
            Lbl_KeyInput.AutoSize = true;
            Lbl_KeyInput.Location = new Point(12, 26);
            Lbl_KeyInput.Margin = new Padding(2, 0, 2, 0);
            Lbl_KeyInput.Name = "Lbl_KeyInput";
            Lbl_KeyInput.Size = new Size(29, 15);
            Lbl_KeyInput.TabIndex = 3;
            Lbl_KeyInput.Text = "Key:";
            // 
            // Gb_SignatureTextInput
            // 
            Gb_SignatureTextInput.Controls.Add(Btn_BrowseSignatureText);
            Gb_SignatureTextInput.Controls.Add(Lbl_ImportFileSignature);
            Gb_SignatureTextInput.Controls.Add(Btn_ClearSignatureInputText);
            Gb_SignatureTextInput.Controls.Add(Lbl_SignatureTextInput);
            Gb_SignatureTextInput.Controls.Add(Btn_PasteSignature);
            Gb_SignatureTextInput.Controls.Add(Rtb_SignatureTextInput);
            Gb_SignatureTextInput.Location = new Point(18, 18);
            Gb_SignatureTextInput.Margin = new Padding(2, 1, 2, 1);
            Gb_SignatureTextInput.Name = "Gb_SignatureTextInput";
            Gb_SignatureTextInput.Padding = new Padding(2, 1, 2, 1);
            Gb_SignatureTextInput.Size = new Size(280, 186);
            Gb_SignatureTextInput.TabIndex = 60;
            Gb_SignatureTextInput.TabStop = false;
            Gb_SignatureTextInput.Text = "Text Input";
            // 
            // Btn_BrowseSignatureText
            // 
            Btn_BrowseSignatureText.Font = new Font("Segoe UI", 9F);
            Btn_BrowseSignatureText.Location = new Point(101, 154);
            Btn_BrowseSignatureText.Margin = new Padding(2, 1, 2, 1);
            Btn_BrowseSignatureText.Name = "Btn_BrowseSignatureText";
            Btn_BrowseSignatureText.Size = new Size(73, 22);
            Btn_BrowseSignatureText.TabIndex = 61;
            Btn_BrowseSignatureText.Text = "Browse";
            Btn_BrowseSignatureText.UseVisualStyleBackColor = true;
            Btn_BrowseSignatureText.Click += Btn_BrowseSignatureText_Click;
            // 
            // Lbl_ImportFileSignature
            // 
            Lbl_ImportFileSignature.AutoSize = true;
            Lbl_ImportFileSignature.Font = new Font("Segoe UI", 9F);
            Lbl_ImportFileSignature.Location = new Point(19, 158);
            Lbl_ImportFileSignature.Margin = new Padding(2, 0, 2, 0);
            Lbl_ImportFileSignature.Name = "Lbl_ImportFileSignature";
            Lbl_ImportFileSignature.Size = new Size(65, 15);
            Lbl_ImportFileSignature.TabIndex = 60;
            Lbl_ImportFileSignature.Text = "Import file:";
            // 
            // Btn_ClearSignatureInputText
            // 
            Btn_ClearSignatureInputText.Font = new Font("Segoe UI", 9F);
            Btn_ClearSignatureInputText.Location = new Point(194, 20);
            Btn_ClearSignatureInputText.Margin = new Padding(2, 1, 2, 1);
            Btn_ClearSignatureInputText.Name = "Btn_ClearSignatureInputText";
            Btn_ClearSignatureInputText.Size = new Size(73, 22);
            Btn_ClearSignatureInputText.TabIndex = 59;
            Btn_ClearSignatureInputText.Text = "Clear";
            Btn_ClearSignatureInputText.UseVisualStyleBackColor = true;
            Btn_ClearSignatureInputText.Click += Btn_ClearSignatureInputText_Click;
            // 
            // Lbl_SignatureTextInput
            // 
            Lbl_SignatureTextInput.AutoSize = true;
            Lbl_SignatureTextInput.Font = new Font("Segoe UI", 9F);
            Lbl_SignatureTextInput.Location = new Point(19, 22);
            Lbl_SignatureTextInput.Margin = new Padding(2, 0, 2, 0);
            Lbl_SignatureTextInput.Name = "Lbl_SignatureTextInput";
            Lbl_SignatureTextInput.Size = new Size(59, 15);
            Lbl_SignatureTextInput.TabIndex = 58;
            Lbl_SignatureTextInput.Text = "Enter text:";
            // 
            // Btn_PasteSignature
            // 
            Btn_PasteSignature.Font = new Font("Segoe UI", 9F);
            Btn_PasteSignature.Location = new Point(108, 20);
            Btn_PasteSignature.Margin = new Padding(2, 1, 2, 1);
            Btn_PasteSignature.Name = "Btn_PasteSignature";
            Btn_PasteSignature.Size = new Size(73, 22);
            Btn_PasteSignature.TabIndex = 57;
            Btn_PasteSignature.Text = "Paste";
            Btn_PasteSignature.UseVisualStyleBackColor = true;
            Btn_PasteSignature.Click += Btn_PasteSignature_Click;
            // 
            // Rtb_SignatureTextInput
            // 
            Rtb_SignatureTextInput.Font = new Font("Segoe UI", 9F);
            Rtb_SignatureTextInput.Location = new Point(19, 45);
            Rtb_SignatureTextInput.Margin = new Padding(2, 1, 2, 1);
            Rtb_SignatureTextInput.Name = "Rtb_SignatureTextInput";
            Rtb_SignatureTextInput.Size = new Size(250, 95);
            Rtb_SignatureTextInput.TabIndex = 56;
            Rtb_SignatureTextInput.Text = "";
            // 
            // Gb_SignatureKeyInput
            // 
            Gb_SignatureKeyInput.Controls.Add(Btn_Verify);
            Gb_SignatureKeyInput.Controls.Add(Btn_Sign);
            Gb_SignatureKeyInput.Controls.Add(Rtb_SignatureKeyInput);
            Gb_SignatureKeyInput.Controls.Add(Btn_BrowseSignatureKey);
            Gb_SignatureKeyInput.Controls.Add(Lbl_SignatureKeyInput);
            Gb_SignatureKeyInput.Location = new Point(328, 18);
            Gb_SignatureKeyInput.Margin = new Padding(2, 1, 2, 1);
            Gb_SignatureKeyInput.Name = "Gb_SignatureKeyInput";
            Gb_SignatureKeyInput.Padding = new Padding(2, 1, 2, 1);
            Gb_SignatureKeyInput.Size = new Size(352, 186);
            Gb_SignatureKeyInput.TabIndex = 56;
            Gb_SignatureKeyInput.TabStop = false;
            Gb_SignatureKeyInput.Text = "Key Input";
            // 
            // Btn_Sign
            // 
            Btn_Sign.Location = new Point(54, 110);
            Btn_Sign.Margin = new Padding(2, 1, 2, 1);
            Btn_Sign.Name = "Btn_Sign";
            Btn_Sign.Size = new Size(102, 22);
            Btn_Sign.TabIndex = 3;
            Btn_Sign.Text = "Sign";
            Btn_Sign.UseVisualStyleBackColor = true;
            Btn_Sign.Click += Btn_Sign_Click;
            // 
            // Btn_Verify
            // 
            Btn_Verify.Location = new Point(188, 110);
            Btn_Verify.Margin = new Padding(2, 1, 2, 1);
            Btn_Verify.Name = "Btn_Verify";
            Btn_Verify.Size = new Size(102, 22);
            Btn_Verify.TabIndex = 60;
            Btn_Verify.Text = "Verify";
            Btn_Verify.UseVisualStyleBackColor = true;
            Btn_Verify.Click += Btn_Verify_Click;
            // 
            // Rtb_SignatureKeyInput
            // 
            Rtb_SignatureKeyInput.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Rtb_SignatureKeyInput.Location = new Point(54, 26);
            Rtb_SignatureKeyInput.Margin = new Padding(2, 1, 2, 1);
            Rtb_SignatureKeyInput.Name = "Rtb_SignatureKeyInput";
            Rtb_SignatureKeyInput.Size = new Size(211, 65);
            Rtb_SignatureKeyInput.TabIndex = 57;
            Rtb_SignatureKeyInput.Text = "";
            // 
            // Btn_BrowseSignatureKey
            // 
            Btn_BrowseSignatureKey.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_BrowseSignatureKey.Location = new Point(273, 26);
            Btn_BrowseSignatureKey.Margin = new Padding(2, 1, 2, 1);
            Btn_BrowseSignatureKey.Name = "Btn_BrowseSignatureKey";
            Btn_BrowseSignatureKey.Size = new Size(68, 22);
            Btn_BrowseSignatureKey.TabIndex = 57;
            Btn_BrowseSignatureKey.Text = "Browse";
            Btn_BrowseSignatureKey.UseVisualStyleBackColor = true;
            Btn_BrowseSignatureKey.Click += Btn_BrowseSignatureKey_Click;
            // 
            // Lbl_SignatureKeyInput
            // 
            Lbl_SignatureKeyInput.AutoSize = true;
            Lbl_SignatureKeyInput.Location = new Point(12, 26);
            Lbl_SignatureKeyInput.Margin = new Padding(2, 0, 2, 0);
            Lbl_SignatureKeyInput.Name = "Lbl_SignatureKeyInput";
            Lbl_SignatureKeyInput.Size = new Size(29, 15);
            Lbl_SignatureKeyInput.TabIndex = 3;
            Lbl_SignatureKeyInput.Text = "Key:";
            // 
            // Btn_CopySignatureResult
            // 
            Btn_CopySignatureResult.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_CopySignatureResult.Location = new Point(575, 224);
            Btn_CopySignatureResult.Margin = new Padding(2, 1, 2, 1);
            Btn_CopySignatureResult.Name = "Btn_CopySignatureResult";
            Btn_CopySignatureResult.Size = new Size(101, 22);
            Btn_CopySignatureResult.TabIndex = 59;
            Btn_CopySignatureResult.Text = "Copy Result";
            Btn_CopySignatureResult.UseVisualStyleBackColor = true;
            Btn_CopySignatureResult.Click += Btn_CopySignatureResult_Click;
            // 
            // Rtb_SignatureResult
            // 
            Rtb_SignatureResult.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Rtb_SignatureResult.Location = new Point(18, 253);
            Rtb_SignatureResult.Margin = new Padding(2, 1, 2, 1);
            Rtb_SignatureResult.Name = "Rtb_SignatureResult";
            Rtb_SignatureResult.ReadOnly = true;
            Rtb_SignatureResult.Size = new Size(664, 158);
            Rtb_SignatureResult.TabIndex = 58;
            Rtb_SignatureResult.Text = "";
            // 
            // Lbl_SignatureResult
            // 
            Lbl_SignatureResult.AutoSize = true;
            Lbl_SignatureResult.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_SignatureResult.Location = new Point(18, 227);
            Lbl_SignatureResult.Margin = new Padding(2, 0, 2, 0);
            Lbl_SignatureResult.Name = "Lbl_SignatureResult";
            Lbl_SignatureResult.Size = new Size(52, 20);
            Lbl_SignatureResult.TabIndex = 57;
            Lbl_SignatureResult.Text = "Result:";
            // 
            // Rtb_SignatureInput
            // 
            Rtb_SignatureInput.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Rtb_SignatureInput.Location = new Point(18, 253);
            Rtb_SignatureInput.Margin = new Padding(2, 1, 2, 1);
            Rtb_SignatureInput.Name = "Rtb_SignatureInput";
            Rtb_SignatureInput.Size = new Size(664, 158);
            Rtb_SignatureInput.TabIndex = 58;
            Rtb_SignatureInput.Text = "";
            // 
            // Lbl_SignatureInput
            // 
            Lbl_SignatureInput.AutoSize = true;
            Lbl_SignatureInput.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_SignatureInput.Location = new Point(18, 227);
            Lbl_SignatureInput.Margin = new Padding(2, 0, 2, 0);
            Lbl_SignatureInput.Name = "Lbl_SignatureInput";
            Lbl_SignatureInput.Size = new Size(52, 20);
            Lbl_SignatureInput.TabIndex = 57;
            Lbl_SignatureInput.Text = "Input:";
            // 
            // RSAControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TbCtrl_RSAControl);
            Margin = new Padding(2, 1, 2, 1);
            Name = "RSAControl";
            Size = new Size(700, 469);
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
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            Gb_SignatureTextInput.ResumeLayout(false);
            Gb_SignatureTextInput.PerformLayout();
            Gb_SignatureKeyInput.ResumeLayout(false);
            Gb_SignatureKeyInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TbCtrl_RSAControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
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
        private GroupBox Gb_SignatureTextInput;
        private Button Btn_BrowseSignatureText;
        private Label Lbl_ImportFileSignature;
        private Button Btn_ClearSignatureInputText;
        private Label Lbl_SignatureTextInput;
        private Button Btn_PasteSignature;
        private RichTextBox Rtb_SignatureTextInput;
        private GroupBox Gb_SignatureKeyInput;
        private Button Btn_Verify;
        private Button Btn_Sign;
        private RichTextBox Rtb_SignatureKeyInput;
        private Button Btn_BrowseSignatureKey;
        private Label Lbl_SignatureKeyInput;
        private Button Btn_CopySignatureResult;
        private RichTextBox Rtb_SignatureResult;
        private Label Lbl_SignatureResult;
        private RichTextBox Rtb_SignatureInput;
        private Label Lbl_SignatureInput;
    }
}
