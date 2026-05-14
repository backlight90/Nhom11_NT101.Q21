namespace Nhom11_NT101.Q21
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TbCtrl_Algorithms = new TabControl();
            Tab_PlayFair = new TabPage();
            Tab_RSA = new TabPage();
            Tab_Vigenere = new TabPage();
            TbCtrl_Algorithms.SuspendLayout();
            SuspendLayout();
            // 
            // TbCtrl_Algorithms
            // 
            TbCtrl_Algorithms.Controls.Add(Tab_PlayFair);
            TbCtrl_Algorithms.Controls.Add(Tab_RSA);
            TbCtrl_Algorithms.Controls.Add(Tab_Vigenere);
            TbCtrl_Algorithms.Location = new Point(0, 0);
            TbCtrl_Algorithms.Name = "TbCtrl_Algorithms";
            TbCtrl_Algorithms.SelectedIndex = 0;
            TbCtrl_Algorithms.Size = new Size(1421, 1012);
            TbCtrl_Algorithms.TabIndex = 0;
            // 
            // Tab_PlayFair
            // 
            Tab_PlayFair.Location = new Point(8, 46);
            Tab_PlayFair.Name = "Tab_PlayFair";
            Tab_PlayFair.Padding = new Padding(3);
            Tab_PlayFair.Size = new Size(1405, 958);
            Tab_PlayFair.TabIndex = 0;
            Tab_PlayFair.Text = "PlayFair";
            Tab_PlayFair.UseVisualStyleBackColor = true;
            // 
            // Tab_RSA
            // 
            Tab_RSA.Location = new Point(8, 46);
            Tab_RSA.Name = "Tab_RSA";
            Tab_RSA.Padding = new Padding(3);
            Tab_RSA.Size = new Size(1405, 958);
            Tab_RSA.TabIndex = 1;
            Tab_RSA.Text = "RSA";
            Tab_RSA.UseVisualStyleBackColor = true;
            // 
            // Tab_Vigenere
            // 
            Tab_Vigenere.Location = new Point(8, 46);
            Tab_Vigenere.Name = "Tab_Vigenere";
            Tab_Vigenere.Padding = new Padding(3);
            Tab_Vigenere.Size = new Size(1405, 958);
            Tab_Vigenere.TabIndex = 2;
            Tab_Vigenere.Text = "Vigenère";
            Tab_Vigenere.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1433, 1010);
            Controls.Add(TbCtrl_Algorithms);
            Name = "MainForm";
            Text = "Main Form";
            TbCtrl_Algorithms.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TbCtrl_Algorithms;
        private TabPage Tab_PlayFair;
        private TabPage Tab_RSA;
        private TabPage Tab_Vigenere;
    }
}
