namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.ip_information = new System.Windows.Forms.Label();
            this.ipadress = new System.Windows.Forms.Label();
            this.webView1 = new EO.WebBrowser.WebView();
            this.webControl1 = new EO.WinForm.WebControl();
            this.webView2 = new EO.WebBrowser.WebView();
            this.check_internet = new System.Windows.Forms.Label();
            this.ip_information_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ip_information
            // 
            this.ip_information.AutoSize = true;
            this.ip_information.Location = new System.Drawing.Point(39, 446);
            this.ip_information.Name = "ip_information";
            this.ip_information.Size = new System.Drawing.Size(70, 13);
            this.ip_information.TabIndex = 0;
            this.ip_information.Text = "ip Information";
            // 
            // ipadress
            // 
            this.ipadress.AutoSize = true;
            this.ipadress.Location = new System.Drawing.Point(549, 364);
            this.ipadress.Name = "ipadress";
            this.ipadress.Size = new System.Drawing.Size(57, 13);
            this.ipadress.TabIndex = 1;
            this.ipadress.Text = "MacAdresi";
            // 
            // webView1
            // 
            this.webView1.ObjectForScripting = null;
            // 
            // webControl1
            // 
            this.webControl1.BackColor = System.Drawing.Color.White;
            this.webControl1.Location = new System.Drawing.Point(42, 12);
            this.webControl1.Name = "webControl1";
            this.webControl1.Size = new System.Drawing.Size(700, 325);
            this.webControl1.TabIndex = 3;
            this.webControl1.Text = "webControl1";
            this.webControl1.WebView = this.webView2;
            // 
            // webView2
            // 
            this.webView2.ObjectForScripting = null;
            // 
            // check_internet
            // 
            this.check_internet.AutoSize = true;
            this.check_internet.Location = new System.Drawing.Point(39, 364);
            this.check_internet.Name = "check_internet";
            this.check_internet.Size = new System.Drawing.Size(78, 13);
            this.check_internet.TabIndex = 4;
            this.check_internet.Text = "check_internet";
            // 
            // ip_information_title
            // 
            this.ip_information_title.AutoSize = true;
            this.ip_information_title.Location = new System.Drawing.Point(39, 403);
            this.ip_information_title.Name = "ip_information_title";
            this.ip_information_title.Size = new System.Drawing.Size(93, 13);
            this.ip_information_title.TabIndex = 5;
            this.ip_information_title.Text = "ip Information Title";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 603);
            this.Controls.Add(this.ip_information_title);
            this.Controls.Add(this.check_internet);
            this.Controls.Add(this.webControl1);
            this.Controls.Add(this.ipadress);
            this.Controls.Add(this.ip_information);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ip_information;
        private System.Windows.Forms.Label ipadress;
        private EO.WebBrowser.WebView webView1;
        private EO.WinForm.WebControl webControl1;
        private EO.WebBrowser.WebView webView2;
        private System.Windows.Forms.Label check_internet;
        private System.Windows.Forms.Label ip_information_title;
    }
}

