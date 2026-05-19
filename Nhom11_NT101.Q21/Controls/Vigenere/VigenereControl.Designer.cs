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
            btnBrowse = new Button();
            lblFileSrc = new Label();
            btnClearInputText = new Button();
            btnDecrypt = new Button();
            btnEncrypt = new Button();
            btnCopy = new Button();
            rtbResult = new RichTextBox();
            lblResult = new Label();
            lblInputSrcText = new Label();
            txtInputKey = new Label();
            btnPaste = new Button();
            rtbInputSrcText = new RichTextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnBrowse
            // 
            btnBrowse.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBrowse.Location = new Point(228, 724);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(137, 46);
            btnBrowse.TabIndex = 31;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            // 
            // lblFileSrc
            // 
            lblFileSrc.AutoSize = true;
            lblFileSrc.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFileSrc.Location = new Point(54, 724);
            lblFileSrc.Name = "lblFileSrc";
            lblFileSrc.Size = new Size(156, 40);
            lblFileSrc.TabIndex = 30;
            lblFileSrc.Text = "Import file:";
            // 
            // btnClearInputText
            // 
            btnClearInputText.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearInputText.Location = new Point(469, 182);
            btnClearInputText.Name = "btnClearInputText";
            btnClearInputText.Size = new Size(137, 46);
            btnClearInputText.TabIndex = 29;
            btnClearInputText.Text = "Clear";
            btnClearInputText.UseVisualStyleBackColor = true;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDecrypt.Location = new Point(677, 836);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(285, 71);
            btnDecrypt.TabIndex = 28;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEncrypt.Location = new Point(321, 836);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(285, 71);
            btnEncrypt.TabIndex = 27;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            btnCopy.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCopy.Location = new Point(1119, 179);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(137, 46);
            btnCopy.TabIndex = 26;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            // 
            // rtbResult
            // 
            rtbResult.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbResult.Location = new Point(704, 245);
            rtbResult.Name = "rtbResult";
            rtbResult.ReadOnly = true;
            rtbResult.Size = new Size(552, 444);
            rtbResult.TabIndex = 25;
            rtbResult.Text = "";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(704, 182);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(99, 40);
            lblResult.TabIndex = 24;
            lblResult.Text = "Result:";
            // 
            // lblInputSrcText
            // 
            lblInputSrcText.AutoSize = true;
            lblInputSrcText.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInputSrcText.Location = new Point(54, 182);
            lblInputSrcText.Name = "lblInputSrcText";
            lblInputSrcText.Size = new Size(145, 40);
            lblInputSrcText.TabIndex = 23;
            lblInputSrcText.Text = "Enter text:";
            // 
            // txtInputKey
            // 
            txtInputKey.AutoSize = true;
            txtInputKey.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInputKey.Location = new Point(50, 81);
            txtInputKey.Name = "txtInputKey";
            txtInputKey.Size = new Size(140, 40);
            txtInputKey.TabIndex = 22;
            txtInputKey.Text = "Enter key:";
            // 
            // btnPaste
            // 
            btnPaste.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPaste.Location = new Point(310, 182);
            btnPaste.Name = "btnPaste";
            btnPaste.Size = new Size(137, 46);
            btnPaste.TabIndex = 21;
            btnPaste.Text = "Paste";
            btnPaste.UseVisualStyleBackColor = true;
            // 
            // rtbInputSrcText
            // 
            rtbInputSrcText.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbInputSrcText.Location = new Point(54, 245);
            rtbInputSrcText.Name = "rtbInputSrcText";
            rtbInputSrcText.Size = new Size(552, 444);
            rtbInputSrcText.TabIndex = 19;
            rtbInputSrcText.Text = "";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(196, 78);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1060, 64);
            textBox1.TabIndex = 18;
            // 
            // VigenereControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBrowse);
            Controls.Add(lblFileSrc);
            Controls.Add(btnClearInputText);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(btnCopy);
            Controls.Add(rtbResult);
            Controls.Add(lblResult);
            Controls.Add(lblInputSrcText);
            Controls.Add(txtInputKey);
            Controls.Add(btnPaste);
            Controls.Add(rtbInputSrcText);
            Controls.Add(textBox1);
            Name = "VigenereControl";
            Size = new Size(1300, 1000);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowse;
        private Label lblFileSrc;
        private Button btnClearInputText;
        private Button btnDecrypt;
        private Button btnEncrypt;
        private Button btnCopy;
        private RichTextBox rtbResult;
        private Label lblResult;
        private Label lblInputSrcText;
        private Label txtInputKey;
        private Button btnPaste;
        private RichTextBox rtbInputSrcText;
        private TextBox textBox1;
    }
}
