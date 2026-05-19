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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            button4 = new Button();
            button5 = new Button();
            richTextBox2 = new RichTextBox();
            label4 = new Label();
            btnBrowse = new Button();
            lblFileSrc = new Label();
            btnClearInputText = new Button();
            lblInputSrcText = new Label();
            btnPaste = new Button();
            rtbInputSrcText = new RichTextBox();
            groupBox4 = new GroupBox();
            button7 = new Button();
            label5 = new Label();
            button8 = new Button();
            richTextBox3 = new RichTextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            button6 = new Button();
            btnCopy = new Button();
            rtbResult = new RichTextBox();
            lblResult = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1300, 1000);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1284, 946);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Key Management";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnCopy);
            tabPage2.Controls.Add(rtbResult);
            tabPage2.Controls.Add(lblResult);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(btnBrowse);
            tabPage2.Controls.Add(lblFileSrc);
            tabPage2.Controls.Add(btnClearInputText);
            tabPage2.Controls.Add(lblInputSrcText);
            tabPage2.Controls.Add(btnPaste);
            tabPage2.Controls.Add(rtbInputSrcText);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1284, 946);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Encryption & Decryption";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(29, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 269);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Key Pair Generator";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(550, 46);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(691, 260);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Save Keys to Files";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(richTextBox2);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(richTextBox1);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(29, 360);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1212, 532);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "View Generated Keys (XML Format)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 65);
            label1.Name = "label1";
            label1.Size = new Size(167, 32);
            label1.TabIndex = 0;
            label1.Text = "Key Size (Bits):";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "512", "1024" });
            comboBox1.Location = new Point(214, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 40);
            comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(24, 163);
            button1.Name = "button1";
            button1.Size = new Size(288, 46);
            button1.TabIndex = 2;
            button1.Text = "Generate Key Pairs";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 56);
            label2.Name = "label2";
            label2.Size = new Size(56, 32);
            label2.TabIndex = 3;
            label2.Text = "PIN:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(97, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(357, 39);
            textBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(23, 154);
            button2.Name = "button2";
            button2.Size = new Size(288, 46);
            button2.TabIndex = 3;
            button2.Text = "Export Public Key (.xml)";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(383, 154);
            button3.Name = "button3";
            button3.Size = new Size(288, 46);
            button3.TabIndex = 5;
            button3.Text = "Export Private Key (.xml)";
            button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 83);
            label3.Name = "label3";
            label3.Size = new Size(304, 32);
            label3.TabIndex = 6;
            label3.Text = "Public Key (For Encryption):";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(24, 129);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1168, 115);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // button4
            // 
            button4.Location = new Point(977, 69);
            button4.Name = "button4";
            button4.Size = new Size(215, 46);
            button4.TabIndex = 3;
            button4.Text = "Copy Public Key";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(977, 301);
            button5.Name = "button5";
            button5.Size = new Size(215, 46);
            button5.TabIndex = 7;
            button5.Text = "Copy Private Key";
            button5.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(24, 361);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(1168, 115);
            richTextBox2.TabIndex = 8;
            richTextBox2.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 315);
            label4.Name = "label4";
            label4.Size = new Size(316, 32);
            label4.TabIndex = 9;
            label4.Text = "Private Key (For Decryption):";
            // 
            // btnBrowse
            // 
            btnBrowse.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBrowse.Location = new Point(200, 342);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(137, 46);
            btnBrowse.TabIndex = 55;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            // 
            // lblFileSrc
            // 
            lblFileSrc.AutoSize = true;
            lblFileSrc.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFileSrc.Location = new Point(26, 342);
            lblFileSrc.Name = "lblFileSrc";
            lblFileSrc.Size = new Size(156, 40);
            lblFileSrc.TabIndex = 54;
            lblFileSrc.Text = "Import file:";
            // 
            // btnClearInputText
            // 
            btnClearInputText.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearInputText.Location = new Point(359, 40);
            btnClearInputText.Name = "btnClearInputText";
            btnClearInputText.Size = new Size(137, 46);
            btnClearInputText.TabIndex = 53;
            btnClearInputText.Text = "Clear";
            btnClearInputText.UseVisualStyleBackColor = true;
            // 
            // lblInputSrcText
            // 
            lblInputSrcText.AutoSize = true;
            lblInputSrcText.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInputSrcText.Location = new Point(34, 40);
            lblInputSrcText.Name = "lblInputSrcText";
            lblInputSrcText.Size = new Size(145, 40);
            lblInputSrcText.TabIndex = 52;
            lblInputSrcText.Text = "Enter text:";
            // 
            // btnPaste
            // 
            btnPaste.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPaste.Location = new Point(200, 40);
            btnPaste.Name = "btnPaste";
            btnPaste.Size = new Size(137, 46);
            btnPaste.TabIndex = 51;
            btnPaste.Text = "Paste";
            btnPaste.UseVisualStyleBackColor = true;
            // 
            // rtbInputSrcText
            // 
            rtbInputSrcText.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbInputSrcText.Location = new Point(34, 103);
            rtbInputSrcText.Name = "rtbInputSrcText";
            rtbInputSrcText.Size = new Size(462, 209);
            rtbInputSrcText.TabIndex = 50;
            rtbInputSrcText.Text = "";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button6);
            groupBox4.Controls.Add(textBox2);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(richTextBox3);
            groupBox4.Controls.Add(button8);
            groupBox4.Controls.Add(button7);
            groupBox4.Controls.Add(label5);
            groupBox4.Location = new Point(575, 54);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(679, 334);
            groupBox4.TabIndex = 56;
            groupBox4.TabStop = false;
            groupBox4.Text = "Key Input";
            // 
            // button7
            // 
            button7.Location = new Point(101, 260);
            button7.Name = "button7";
            button7.Size = new Size(189, 46);
            button7.TabIndex = 3;
            button7.Text = "Encrypt";
            button7.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 56);
            label5.Name = "label5";
            label5.Size = new Size(58, 32);
            label5.TabIndex = 3;
            label5.Text = "Key:";
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(525, 58);
            button8.Name = "button8";
            button8.Size = new Size(137, 46);
            button8.TabIndex = 57;
            button8.Text = "Browse";
            button8.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            richTextBox3.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox3.Location = new Point(101, 56);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(389, 48);
            richTextBox3.TabIndex = 57;
            richTextBox3.Text = "";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(101, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(389, 39);
            textBox2.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 136);
            label6.Name = "label6";
            label6.Size = new Size(56, 32);
            label6.TabIndex = 58;
            label6.Text = "PIN:";
            // 
            // button6
            // 
            button6.Location = new Point(350, 260);
            button6.Name = "button6";
            button6.Size = new Size(189, 46);
            button6.TabIndex = 60;
            button6.Text = "Decrypt";
            button6.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            btnCopy.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCopy.Location = new Point(1100, 467);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(137, 46);
            btnCopy.TabIndex = 59;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            // 
            // rtbResult
            // 
            rtbResult.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbResult.Location = new Point(34, 539);
            rtbResult.Name = "rtbResult";
            rtbResult.ReadOnly = true;
            rtbResult.Size = new Size(1220, 333);
            rtbResult.TabIndex = 58;
            rtbResult.Text = "";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(34, 467);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(99, 40);
            lblResult.TabIndex = 57;
            lblResult.Text = "Result:";
            // 
            // RSAControl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "RSAControl";
            Size = new Size(1300, 1000);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
        private Button button5;
        private RichTextBox richTextBox2;
        private Label label4;
        private Button button4;
        private RichTextBox richTextBox1;
        private Label label3;
        private Button button3;
        private Button button2;
        private TextBox textBox1;
        private Label label2;
        private GroupBox groupBox4;
        private RichTextBox richTextBox3;
        private Button button8;
        private Button button7;
        private Label label5;
        private Button btnBrowse;
        private Label lblFileSrc;
        private Button btnClearInputText;
        private Label lblInputSrcText;
        private Button btnPaste;
        private RichTextBox rtbInputSrcText;
        private Button button6;
        private TextBox textBox2;
        private Label label6;
        private Button btnCopy;
        private RichTextBox rtbResult;
        private Label lblResult;
    }
}
