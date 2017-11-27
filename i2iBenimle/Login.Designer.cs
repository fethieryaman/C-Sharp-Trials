namespace i2iBenimle
{
    partial class Login
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
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelLoginError = new System.Windows.Forms.Label();
            this.btnEntry = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedPassword = new System.Windows.Forms.MaskedTextBox();
            this.maskedPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.Snow;
            this.pictureLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureLogo.Image = global::i2iBenimle.Properties.Resources.i2i_logo;
            this.pictureLogo.Location = new System.Drawing.Point(168, 10);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(229, 132);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 20;
            this.pictureLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labelLoginError);
            this.panel1.Controls.Add(this.btnEntry);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.maskedPassword);
            this.panel1.Controls.Add(this.maskedPhoneNumber);
            this.panel1.Controls.Add(this.labelHeader);
            this.panel1.Location = new System.Drawing.Point(168, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 239);
            this.panel1.TabIndex = 21;
            // 
            // labelLoginError
            // 
            this.labelLoginError.Font = new System.Drawing.Font("Imprint MT Shadow", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginError.ForeColor = System.Drawing.Color.Red;
            this.labelLoginError.Location = new System.Drawing.Point(20, 197);
            this.labelLoginError.Name = "labelLoginError";
            this.labelLoginError.Size = new System.Drawing.Size(185, 38);
            this.labelLoginError.TabIndex = 20;
            this.labelLoginError.Text = "Hatalı Giris Yaptınız !";
            this.labelLoginError.Visible = false;
            // 
            // btnEntry
            // 
            this.btnEntry.BackColor = System.Drawing.Color.White;
            this.btnEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEntry.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntry.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEntry.Location = new System.Drawing.Point(20, 153);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(185, 32);
            this.btnEntry.TabIndex = 19;
            this.btnEntry.Text = "GIRIS";
            this.btnEntry.UseVisualStyleBackColor = false;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(82, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "SIFRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(38, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "TELEFON NUMARASI";
            // 
            // maskedPassword
            // 
            this.maskedPassword.Location = new System.Drawing.Point(20, 127);
            this.maskedPassword.Mask = "000000";
            this.maskedPassword.Name = "maskedPassword";
            this.maskedPassword.PasswordChar = '*';
            this.maskedPassword.Size = new System.Drawing.Size(185, 20);
            this.maskedPassword.TabIndex = 16;
            this.maskedPassword.ValidatingType = typeof(int);
            // 
            // maskedPhoneNumber
            // 
            this.maskedPhoneNumber.Location = new System.Drawing.Point(20, 75);
            this.maskedPhoneNumber.Mask = "00000000000";
            this.maskedPhoneNumber.Name = "maskedPhoneNumber";
            this.maskedPhoneNumber.Size = new System.Drawing.Size(185, 20);
            this.maskedPhoneNumber.TabIndex = 15;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Imprint MT Shadow", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelHeader.Location = new System.Drawing.Point(14, 7);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(191, 34);
            this.labelHeader.TabIndex = 13;
            this.labelHeader.Text = "İ2İ BENİMLE";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(562, 387);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox maskedPassword;
        private System.Windows.Forms.MaskedTextBox maskedPhoneNumber;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLoginError;
        private System.Windows.Forms.Button btnEntry;
    }
}