namespace Rastgele4islem
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCevapla = new MetroFramework.Controls.MetroButton();
            this.lblSayi1 = new MetroFramework.Controls.MetroLabel();
            this.txtInput = new MetroFramework.Controls.MetroTextBox();
            this.lblIsaret = new MetroFramework.Controls.MetroLabel();
            this.lblSayi2 = new MetroFramework.Controls.MetroLabel();
            this.lblSure = new MetroFramework.Controls.MetroLabel();
            this.btnYeniOyun = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCevapla
            // 
            this.btnCevapla.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCevapla.Location = new System.Drawing.Point(347, 232);
            this.btnCevapla.Name = "btnCevapla";
            this.btnCevapla.Size = new System.Drawing.Size(244, 40);
            this.btnCevapla.TabIndex = 50;
            this.btnCevapla.Text = "CEVAPLA";
            this.btnCevapla.UseSelectable = true;
            this.btnCevapla.Click += new System.EventHandler(this.btnCevapla_Click);
            // 
            // lblSayi1
            // 
            this.lblSayi1.AutoSize = true;
            this.lblSayi1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSayi1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblSayi1.Location = new System.Drawing.Point(121, 104);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(64, 25);
            this.lblSayi1.TabIndex = 49;
            this.lblSayi1.Text = "SAYI 1";
            this.lblSayi1.UseCustomBackColor = true;
            this.lblSayi1.UseCustomForeColor = true;
            // 
            // txtInput
            // 
            // 
            // 
            // 
            this.txtInput.CustomButton.Image = null;
            this.txtInput.CustomButton.Location = new System.Drawing.Point(136, 2);
            this.txtInput.CustomButton.Name = "";
            this.txtInput.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInput.CustomButton.TabIndex = 1;
            this.txtInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInput.CustomButton.UseSelectable = true;
            this.txtInput.CustomButton.Visible = false;
            this.txtInput.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtInput.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtInput.Lines = new string[0];
            this.txtInput.Location = new System.Drawing.Point(232, 172);
            this.txtInput.MaxLength = 32767;
            this.txtInput.Name = "txtInput";
            this.txtInput.PasswordChar = '\0';
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInput.SelectedText = "";
            this.txtInput.SelectionLength = 0;
            this.txtInput.SelectionStart = 0;
            this.txtInput.ShortcutsEnabled = true;
            this.txtInput.ShowClearButton = true;
            this.txtInput.Size = new System.Drawing.Size(164, 30);
            this.txtInput.TabIndex = 48;
            this.txtInput.UseCustomBackColor = true;
            this.txtInput.UseCustomForeColor = true;
            this.txtInput.UseSelectable = true;
            this.txtInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // lblIsaret
            // 
            this.lblIsaret.AutoSize = true;
            this.lblIsaret.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblIsaret.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblIsaret.Location = new System.Drawing.Point(280, 104);
            this.lblIsaret.Name = "lblIsaret";
            this.lblIsaret.Size = new System.Drawing.Size(68, 25);
            this.lblIsaret.TabIndex = 51;
            this.lblIsaret.Text = "İŞARET";
            this.lblIsaret.UseCustomBackColor = true;
            this.lblIsaret.UseCustomForeColor = true;
            // 
            // lblSayi2
            // 
            this.lblSayi2.AutoSize = true;
            this.lblSayi2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSayi2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblSayi2.Location = new System.Drawing.Point(443, 104);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(64, 25);
            this.lblSayi2.TabIndex = 52;
            this.lblSayi2.Text = "SAYI 2";
            this.lblSayi2.UseCustomBackColor = true;
            this.lblSayi2.UseCustomForeColor = true;
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSure.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSure.Location = new System.Drawing.Point(39, 172);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(57, 25);
            this.lblSure.TabIndex = 53;
            this.lblSure.Text = "SÜRE";
            this.lblSure.UseCustomBackColor = true;
            this.lblSure.UseCustomForeColor = true;
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnYeniOyun.Location = new System.Drawing.Point(51, 232);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(244, 40);
            this.btnYeniOyun.TabIndex = 54;
            this.btnYeniOyun.Text = "YENİ OYUN";
            this.btnYeniOyun.UseSelectable = true;
            this.btnYeniOyun.Visible = false;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 295);
            this.Controls.Add(this.btnYeniOyun);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.lblSayi2);
            this.Controls.Add(this.lblIsaret);
            this.Controls.Add(this.btnCevapla);
            this.Controls.Add(this.lblSayi1);
            this.Controls.Add(this.txtInput);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Rastgele 4 İşlem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroButton btnCevapla;
        private MetroFramework.Controls.MetroLabel lblSayi1;
        private MetroFramework.Controls.MetroTextBox txtInput;
        private MetroFramework.Controls.MetroLabel lblIsaret;
        private MetroFramework.Controls.MetroLabel lblSayi2;
        private MetroFramework.Controls.MetroLabel lblSure;
        private MetroFramework.Controls.MetroButton btnYeniOyun;
    }
}

