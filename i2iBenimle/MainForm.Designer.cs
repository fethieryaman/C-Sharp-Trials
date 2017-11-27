namespace i2iBenimle
{
    partial class MainForm
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
            this.controlTag = new System.Windows.Forms.TabControl();
            this.pageMain = new System.Windows.Forms.TabPage();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelRatePlan = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pageRemainingBalance = new System.Windows.Forms.TabPage();
            this.labelRemainingDate = new System.Windows.Forms.Label();
            this.progressBarRemainingInternet = new System.Windows.Forms.ProgressBar();
            this.labelRemainingInternet = new System.Windows.Forms.Label();
            this.labelDescriptionRemainingInternet = new System.Windows.Forms.Label();
            this.progressBarRemainingSms = new System.Windows.Forms.ProgressBar();
            this.labelRemainingSms = new System.Windows.Forms.Label();
            this.labelDescriptionRemainingSms = new System.Windows.Forms.Label();
            this.progressBarRemainingMinute = new System.Windows.Forms.ProgressBar();
            this.labelRemainingMinute = new System.Windows.Forms.Label();
            this.labelDescriptionRemainingMinute = new System.Windows.Forms.Label();
            this.labelRemainingBalance = new System.Windows.Forms.Label();
            this.labelDescriptionRemainingBalance = new System.Windows.Forms.Label();
            this.pageRatePlan = new System.Windows.Forms.TabPage();
            this.btnGencTarife = new System.Windows.Forms.Button();
            this.btnEmekli = new System.Windows.Forms.Button();
            this.btnMemur = new System.Windows.Forms.Button();
            this.labelRatePlanDescription = new System.Windows.Forms.Label();
            this.pageCampaign = new System.Windows.Forms.TabPage();
            this.labelCampaignDescription = new System.Windows.Forms.Label();
            this.btnRetired = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnCınema = new System.Windows.Forms.Button();
            this.pageAddBalance = new System.Windows.Forms.TabPage();
            this.labelError = new System.Windows.Forms.Label();
            this.txtAddBalancePhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelAddBalanceTotalBalanceHeader = new System.Windows.Forms.Label();
            this.labelAddBalancePhoneNumberHeader = new System.Windows.Forms.Label();
            this.labelAddBalanceDescription = new System.Windows.Forms.Label();
            this.labelAddBalanceTotalBalance = new System.Windows.Forms.Label();
            this.labelAddBalancePhoneNumber = new System.Windows.Forms.Label();
            this.btnAddBalance50 = new System.Windows.Forms.Button();
            this.btnAddBalance30 = new System.Windows.Forms.Button();
            this.btnAddBalance20 = new System.Windows.Forms.Button();
            this.btnAddBalance10 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.controlTag.SuspendLayout();
            this.pageMain.SuspendLayout();
            this.pageRemainingBalance.SuspendLayout();
            this.pageRatePlan.SuspendLayout();
            this.pageCampaign.SuspendLayout();
            this.pageAddBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // controlTag
            // 
            this.controlTag.Controls.Add(this.pageMain);
            this.controlTag.Controls.Add(this.pageRemainingBalance);
            this.controlTag.Controls.Add(this.pageRatePlan);
            this.controlTag.Controls.Add(this.pageCampaign);
            this.controlTag.Controls.Add(this.pageAddBalance);
            this.controlTag.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlTag.Location = new System.Drawing.Point(12, 150);
            this.controlTag.Name = "controlTag";
            this.controlTag.SelectedIndex = 0;
            this.controlTag.Size = new System.Drawing.Size(545, 227);
            this.controlTag.TabIndex = 22;
            // 
            // pageMain
            // 
            this.pageMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pageMain.Controls.Add(this.labelLastName);
            this.pageMain.Controls.Add(this.labelFirstName);
            this.pageMain.Controls.Add(this.labelRatePlan);
            this.pageMain.Controls.Add(this.labelPhoneNumber);
            this.pageMain.Controls.Add(this.labelFullName);
            this.pageMain.Controls.Add(this.label1);
            this.pageMain.Location = new System.Drawing.Point(4, 24);
            this.pageMain.Name = "pageMain";
            this.pageMain.Padding = new System.Windows.Forms.Padding(3);
            this.pageMain.Size = new System.Drawing.Size(537, 199);
            this.pageMain.TabIndex = 4;
            this.pageMain.Text = "ANA SAYFA";
            this.pageMain.UseVisualStyleBackColor = true;
            this.pageMain.Click += new System.EventHandler(this.pageMain_Click);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelLastName.Location = new System.Drawing.Point(76, 149);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(95, 23);
            this.labelLastName.TabIndex = 11;
            this.labelLastName.Text = "SOYISIM";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelFirstName.Location = new System.Drawing.Point(76, 104);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(55, 23);
            this.labelFirstName.TabIndex = 10;
            this.labelFirstName.Text = "ISIM";
            // 
            // labelRatePlan
            // 
            this.labelRatePlan.AutoSize = true;
            this.labelRatePlan.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRatePlan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelRatePlan.Location = new System.Drawing.Point(352, 132);
            this.labelRatePlan.Name = "labelRatePlan";
            this.labelRatePlan.Size = new System.Drawing.Size(87, 23);
            this.labelRatePlan.TabIndex = 9;
            this.labelRatePlan.Text = "TARIFE";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPhoneNumber.Location = new System.Drawing.Point(352, 72);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(85, 23);
            this.labelPhoneNumber.TabIndex = 8;
            this.labelPhoneNumber.Text = "TEL NO";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelFullName.Location = new System.Drawing.Point(76, 60);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(77, 23);
            this.labelFullName.TabIndex = 7;
            this.labelFullName.Text = "SAYIN ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(188, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "HOSGELDİNİZ";
            // 
            // pageRemainingBalance
            // 
            this.pageRemainingBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pageRemainingBalance.Controls.Add(this.labelRemainingDate);
            this.pageRemainingBalance.Controls.Add(this.progressBarRemainingInternet);
            this.pageRemainingBalance.Controls.Add(this.labelRemainingInternet);
            this.pageRemainingBalance.Controls.Add(this.labelDescriptionRemainingInternet);
            this.pageRemainingBalance.Controls.Add(this.progressBarRemainingSms);
            this.pageRemainingBalance.Controls.Add(this.labelRemainingSms);
            this.pageRemainingBalance.Controls.Add(this.labelDescriptionRemainingSms);
            this.pageRemainingBalance.Controls.Add(this.progressBarRemainingMinute);
            this.pageRemainingBalance.Controls.Add(this.labelRemainingMinute);
            this.pageRemainingBalance.Controls.Add(this.labelDescriptionRemainingMinute);
            this.pageRemainingBalance.Controls.Add(this.labelRemainingBalance);
            this.pageRemainingBalance.Controls.Add(this.labelDescriptionRemainingBalance);
            this.pageRemainingBalance.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageRemainingBalance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pageRemainingBalance.Location = new System.Drawing.Point(4, 24);
            this.pageRemainingBalance.Name = "pageRemainingBalance";
            this.pageRemainingBalance.Padding = new System.Windows.Forms.Padding(3);
            this.pageRemainingBalance.Size = new System.Drawing.Size(537, 199);
            this.pageRemainingBalance.TabIndex = 0;
            this.pageRemainingBalance.Text = "KALAN KULLANIMLAR";
            this.pageRemainingBalance.UseVisualStyleBackColor = true;
            this.pageRemainingBalance.Click += new System.EventHandler(this.pageRemainingBalance_Click);
            // 
            // labelRemainingDate
            // 
            this.labelRemainingDate.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemainingDate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelRemainingDate.Location = new System.Drawing.Point(294, 169);
            this.labelRemainingDate.Name = "labelRemainingDate";
            this.labelRemainingDate.Size = new System.Drawing.Size(219, 23);
            this.labelRemainingDate.TabIndex = 16;
            this.labelRemainingDate.Text = "KALAN TL";
            // 
            // progressBarRemainingInternet
            // 
            this.progressBarRemainingInternet.Location = new System.Drawing.Point(413, 134);
            this.progressBarRemainingInternet.Name = "progressBarRemainingInternet";
            this.progressBarRemainingInternet.Size = new System.Drawing.Size(100, 23);
            this.progressBarRemainingInternet.TabIndex = 15;
            // 
            // labelRemainingInternet
            // 
            this.labelRemainingInternet.AutoSize = true;
            this.labelRemainingInternet.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemainingInternet.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelRemainingInternet.Location = new System.Drawing.Point(233, 134);
            this.labelRemainingInternet.Name = "labelRemainingInternet";
            this.labelRemainingInternet.Size = new System.Drawing.Size(143, 23);
            this.labelRemainingInternet.TabIndex = 14;
            this.labelRemainingInternet.Text = "--- INTERNET";
            // 
            // labelDescriptionRemainingInternet
            // 
            this.labelDescriptionRemainingInternet.AutoSize = true;
            this.labelDescriptionRemainingInternet.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescriptionRemainingInternet.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelDescriptionRemainingInternet.Location = new System.Drawing.Point(21, 134);
            this.labelDescriptionRemainingInternet.Name = "labelDescriptionRemainingInternet";
            this.labelDescriptionRemainingInternet.Size = new System.Drawing.Size(193, 23);
            this.labelDescriptionRemainingInternet.TabIndex = 13;
            this.labelDescriptionRemainingInternet.Text = "KALAN INTERNET";
            // 
            // progressBarRemainingSms
            // 
            this.progressBarRemainingSms.Location = new System.Drawing.Point(413, 97);
            this.progressBarRemainingSms.Name = "progressBarRemainingSms";
            this.progressBarRemainingSms.Size = new System.Drawing.Size(100, 23);
            this.progressBarRemainingSms.TabIndex = 12;
            // 
            // labelRemainingSms
            // 
            this.labelRemainingSms.AutoSize = true;
            this.labelRemainingSms.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemainingSms.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelRemainingSms.Location = new System.Drawing.Point(233, 97);
            this.labelRemainingSms.Name = "labelRemainingSms";
            this.labelRemainingSms.Size = new System.Drawing.Size(76, 23);
            this.labelRemainingSms.TabIndex = 11;
            this.labelRemainingSms.Text = "--- SMS";
            // 
            // labelDescriptionRemainingSms
            // 
            this.labelDescriptionRemainingSms.AutoSize = true;
            this.labelDescriptionRemainingSms.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescriptionRemainingSms.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelDescriptionRemainingSms.Location = new System.Drawing.Point(21, 97);
            this.labelDescriptionRemainingSms.Name = "labelDescriptionRemainingSms";
            this.labelDescriptionRemainingSms.Size = new System.Drawing.Size(126, 23);
            this.labelDescriptionRemainingSms.TabIndex = 10;
            this.labelDescriptionRemainingSms.Text = "KALAN SMS";
            // 
            // progressBarRemainingMinute
            // 
            this.progressBarRemainingMinute.Location = new System.Drawing.Point(413, 60);
            this.progressBarRemainingMinute.Name = "progressBarRemainingMinute";
            this.progressBarRemainingMinute.Size = new System.Drawing.Size(100, 23);
            this.progressBarRemainingMinute.TabIndex = 9;
            // 
            // labelRemainingMinute
            // 
            this.labelRemainingMinute.AutoSize = true;
            this.labelRemainingMinute.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemainingMinute.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelRemainingMinute.Location = new System.Drawing.Point(233, 60);
            this.labelRemainingMinute.Name = "labelRemainingMinute";
            this.labelRemainingMinute.Size = new System.Drawing.Size(118, 23);
            this.labelRemainingMinute.TabIndex = 8;
            this.labelRemainingMinute.Text = "--- DAKIKA";
            // 
            // labelDescriptionRemainingMinute
            // 
            this.labelDescriptionRemainingMinute.AutoSize = true;
            this.labelDescriptionRemainingMinute.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescriptionRemainingMinute.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelDescriptionRemainingMinute.Location = new System.Drawing.Point(21, 60);
            this.labelDescriptionRemainingMinute.Name = "labelDescriptionRemainingMinute";
            this.labelDescriptionRemainingMinute.Size = new System.Drawing.Size(168, 23);
            this.labelDescriptionRemainingMinute.TabIndex = 7;
            this.labelDescriptionRemainingMinute.Text = "KALAN DAKIKA";
            // 
            // labelRemainingBalance
            // 
            this.labelRemainingBalance.AutoSize = true;
            this.labelRemainingBalance.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemainingBalance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelRemainingBalance.Location = new System.Drawing.Point(233, 20);
            this.labelRemainingBalance.Name = "labelRemainingBalance";
            this.labelRemainingBalance.Size = new System.Drawing.Size(63, 23);
            this.labelRemainingBalance.TabIndex = 6;
            this.labelRemainingBalance.Text = "--- TL";
            // 
            // labelDescriptionRemainingBalance
            // 
            this.labelDescriptionRemainingBalance.AutoSize = true;
            this.labelDescriptionRemainingBalance.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescriptionRemainingBalance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelDescriptionRemainingBalance.Location = new System.Drawing.Point(21, 20);
            this.labelDescriptionRemainingBalance.Name = "labelDescriptionRemainingBalance";
            this.labelDescriptionRemainingBalance.Size = new System.Drawing.Size(113, 23);
            this.labelDescriptionRemainingBalance.TabIndex = 5;
            this.labelDescriptionRemainingBalance.Text = "KALAN TL";
            // 
            // pageRatePlan
            // 
            this.pageRatePlan.Controls.Add(this.btnGencTarife);
            this.pageRatePlan.Controls.Add(this.btnEmekli);
            this.pageRatePlan.Controls.Add(this.btnMemur);
            this.pageRatePlan.Controls.Add(this.labelRatePlanDescription);
            this.pageRatePlan.Location = new System.Drawing.Point(4, 24);
            this.pageRatePlan.Name = "pageRatePlan";
            this.pageRatePlan.Size = new System.Drawing.Size(537, 199);
            this.pageRatePlan.TabIndex = 5;
            this.pageRatePlan.Text = "TARIFELER";
            this.pageRatePlan.UseVisualStyleBackColor = true;
            this.pageRatePlan.Click += new System.EventHandler(this.pageRatePlan_Click);
            // 
            // btnGencTarife
            // 
            this.btnGencTarife.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGencTarife.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGencTarife.Location = new System.Drawing.Point(53, 19);
            this.btnGencTarife.Name = "btnGencTarife";
            this.btnGencTarife.Size = new System.Drawing.Size(122, 23);
            this.btnGencTarife.TabIndex = 15;
            this.btnGencTarife.Text = "GENC TARIFE";
            this.btnGencTarife.UseVisualStyleBackColor = true;
            this.btnGencTarife.Click += new System.EventHandler(this.btnGencTarife_Click);
            // 
            // btnEmekli
            // 
            this.btnEmekli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmekli.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEmekli.Location = new System.Drawing.Point(331, 19);
            this.btnEmekli.Name = "btnEmekli";
            this.btnEmekli.Size = new System.Drawing.Size(148, 23);
            this.btnEmekli.TabIndex = 14;
            this.btnEmekli.Text = "EMEKLI TARIFE";
            this.btnEmekli.UseVisualStyleBackColor = true;
            this.btnEmekli.Click += new System.EventHandler(this.btnEmekli_Click);
            // 
            // btnMemur
            // 
            this.btnMemur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemur.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMemur.Location = new System.Drawing.Point(181, 19);
            this.btnMemur.Name = "btnMemur";
            this.btnMemur.Size = new System.Drawing.Size(144, 23);
            this.btnMemur.TabIndex = 13;
            this.btnMemur.Text = "MEMUR TARIFE";
            this.btnMemur.UseVisualStyleBackColor = true;
            this.btnMemur.Click += new System.EventHandler(this.btnMemur_Click);
            // 
            // labelRatePlanDescription
            // 
            this.labelRatePlanDescription.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRatePlanDescription.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelRatePlanDescription.Location = new System.Drawing.Point(12, 58);
            this.labelRatePlanDescription.Name = "labelRatePlanDescription";
            this.labelRatePlanDescription.Size = new System.Drawing.Size(511, 128);
            this.labelRatePlanDescription.TabIndex = 10;
            this.labelRatePlanDescription.Text = "LUTFEN BILGI ALMAK ISTEDIGINIZ TARIFEYI SECINIZ.";
            // 
            // pageCampaign
            // 
            this.pageCampaign.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pageCampaign.Controls.Add(this.labelCampaignDescription);
            this.pageCampaign.Controls.Add(this.btnRetired);
            this.pageCampaign.Controls.Add(this.btnFood);
            this.pageCampaign.Controls.Add(this.btnCınema);
            this.pageCampaign.Location = new System.Drawing.Point(4, 24);
            this.pageCampaign.Name = "pageCampaign";
            this.pageCampaign.Padding = new System.Windows.Forms.Padding(3);
            this.pageCampaign.Size = new System.Drawing.Size(537, 199);
            this.pageCampaign.TabIndex = 2;
            this.pageCampaign.Text = "KAMPANYALAR";
            this.pageCampaign.UseVisualStyleBackColor = true;
            this.pageCampaign.Click += new System.EventHandler(this.pageCampaign_Click);
            // 
            // labelCampaignDescription
            // 
            this.labelCampaignDescription.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCampaignDescription.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCampaignDescription.Location = new System.Drawing.Point(6, 58);
            this.labelCampaignDescription.Name = "labelCampaignDescription";
            this.labelCampaignDescription.Size = new System.Drawing.Size(521, 134);
            this.labelCampaignDescription.TabIndex = 19;
            this.labelCampaignDescription.Text = "LUTFEN BILGI ALMAK ISTEDIGINIZ KAMPANYAYI SECINIZ.";
            this.labelCampaignDescription.Click += new System.EventHandler(this.labelCampaignDescription_Click);
            // 
            // btnRetired
            // 
            this.btnRetired.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetired.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRetired.Location = new System.Drawing.Point(6, 21);
            this.btnRetired.Name = "btnRetired";
            this.btnRetired.Size = new System.Drawing.Size(167, 23);
            this.btnRetired.TabIndex = 18;
            this.btnRetired.Text = "EMEKLI KAMPANYASI";
            this.btnRetired.UseVisualStyleBackColor = true;
            this.btnRetired.Click += new System.EventHandler(this.btnRetired_Click);
            // 
            // btnFood
            // 
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnFood.Location = new System.Drawing.Point(364, 21);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(163, 23);
            this.btnFood.TabIndex = 17;
            this.btnFood.Text = "YEMEK KAMPANYASI";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnCınema
            // 
            this.btnCınema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCınema.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCınema.Location = new System.Drawing.Point(179, 21);
            this.btnCınema.Name = "btnCınema";
            this.btnCınema.Size = new System.Drawing.Size(179, 23);
            this.btnCınema.TabIndex = 16;
            this.btnCınema.Text = "SINEMA KAMPANYASI";
            this.btnCınema.UseVisualStyleBackColor = true;
            this.btnCınema.Click += new System.EventHandler(this.btnCınema_Click);
            // 
            // pageAddBalance
            // 
            this.pageAddBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pageAddBalance.Controls.Add(this.labelError);
            this.pageAddBalance.Controls.Add(this.txtAddBalancePhoneNumber);
            this.pageAddBalance.Controls.Add(this.labelAddBalanceTotalBalanceHeader);
            this.pageAddBalance.Controls.Add(this.labelAddBalancePhoneNumberHeader);
            this.pageAddBalance.Controls.Add(this.labelAddBalanceDescription);
            this.pageAddBalance.Controls.Add(this.labelAddBalanceTotalBalance);
            this.pageAddBalance.Controls.Add(this.labelAddBalancePhoneNumber);
            this.pageAddBalance.Controls.Add(this.btnAddBalance50);
            this.pageAddBalance.Controls.Add(this.btnAddBalance30);
            this.pageAddBalance.Controls.Add(this.btnAddBalance20);
            this.pageAddBalance.Controls.Add(this.btnAddBalance10);
            this.pageAddBalance.Location = new System.Drawing.Point(4, 24);
            this.pageAddBalance.Name = "pageAddBalance";
            this.pageAddBalance.Padding = new System.Windows.Forms.Padding(3);
            this.pageAddBalance.Size = new System.Drawing.Size(537, 199);
            this.pageAddBalance.TabIndex = 3;
            this.pageAddBalance.Text = "TL YUKLE";
            this.pageAddBalance.UseVisualStyleBackColor = true;
            this.pageAddBalance.Click += new System.EventHandler(this.pageAddBalance_Click);
            // 
            // labelError
            // 
            this.labelError.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(197, 7);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(330, 20);
            this.labelError.TabIndex = 29;
            this.labelError.Text = "ERROR MESAJI";
            this.labelError.Visible = false;
            // 
            // txtAddBalancePhoneNumber
            // 
            this.txtAddBalancePhoneNumber.Location = new System.Drawing.Point(6, 4);
            this.txtAddBalancePhoneNumber.Mask = "00000000000";
            this.txtAddBalancePhoneNumber.Name = "txtAddBalancePhoneNumber";
            this.txtAddBalancePhoneNumber.Size = new System.Drawing.Size(185, 23);
            this.txtAddBalancePhoneNumber.TabIndex = 28;
            // 
            // labelAddBalanceTotalBalanceHeader
            // 
            this.labelAddBalanceTotalBalanceHeader.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddBalanceTotalBalanceHeader.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelAddBalanceTotalBalanceHeader.Location = new System.Drawing.Point(265, 71);
            this.labelAddBalanceTotalBalanceHeader.Name = "labelAddBalanceTotalBalanceHeader";
            this.labelAddBalanceTotalBalanceHeader.Size = new System.Drawing.Size(252, 30);
            this.labelAddBalanceTotalBalanceHeader.TabIndex = 27;
            this.labelAddBalanceTotalBalanceHeader.Text = "YÜKLENEN TUTAR";
            this.labelAddBalanceTotalBalanceHeader.Visible = false;
            // 
            // labelAddBalancePhoneNumberHeader
            // 
            this.labelAddBalancePhoneNumberHeader.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddBalancePhoneNumberHeader.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelAddBalancePhoneNumberHeader.Location = new System.Drawing.Point(7, 71);
            this.labelAddBalancePhoneNumberHeader.Name = "labelAddBalancePhoneNumberHeader";
            this.labelAddBalancePhoneNumberHeader.Size = new System.Drawing.Size(252, 30);
            this.labelAddBalancePhoneNumberHeader.TabIndex = 26;
            this.labelAddBalancePhoneNumberHeader.Text = "TELEFON NUMARASI";
            this.labelAddBalancePhoneNumberHeader.Visible = false;
            // 
            // labelAddBalanceDescription
            // 
            this.labelAddBalanceDescription.Font = new System.Drawing.Font("Imprint MT Shadow", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddBalanceDescription.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelAddBalanceDescription.Location = new System.Drawing.Point(7, 158);
            this.labelAddBalanceDescription.Name = "labelAddBalanceDescription";
            this.labelAddBalanceDescription.Size = new System.Drawing.Size(521, 39);
            this.labelAddBalanceDescription.TabIndex = 25;
            this.labelAddBalanceDescription.Text = "YUKLEME YAPTIGINIZ ICIN TESEKKUR EDERIZ";
            this.labelAddBalanceDescription.Visible = false;
            // 
            // labelAddBalanceTotalBalance
            // 
            this.labelAddBalanceTotalBalance.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddBalanceTotalBalance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelAddBalanceTotalBalance.Location = new System.Drawing.Point(264, 110);
            this.labelAddBalanceTotalBalance.Name = "labelAddBalanceTotalBalance";
            this.labelAddBalanceTotalBalance.Size = new System.Drawing.Size(251, 30);
            this.labelAddBalanceTotalBalance.TabIndex = 24;
            this.labelAddBalanceTotalBalance.Text = "TOPLAM TUTAR";
            this.labelAddBalanceTotalBalance.Visible = false;
            // 
            // labelAddBalancePhoneNumber
            // 
            this.labelAddBalancePhoneNumber.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddBalancePhoneNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelAddBalancePhoneNumber.Location = new System.Drawing.Point(6, 110);
            this.labelAddBalancePhoneNumber.Name = "labelAddBalancePhoneNumber";
            this.labelAddBalancePhoneNumber.Size = new System.Drawing.Size(252, 30);
            this.labelAddBalancePhoneNumber.TabIndex = 23;
            this.labelAddBalancePhoneNumber.Text = "TELEFON NUMARASI";
            this.labelAddBalancePhoneNumber.Visible = false;
            // 
            // btnAddBalance50
            // 
            this.btnAddBalance50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBalance50.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddBalance50.Location = new System.Drawing.Point(393, 33);
            this.btnAddBalance50.Name = "btnAddBalance50";
            this.btnAddBalance50.Size = new System.Drawing.Size(134, 23);
            this.btnAddBalance50.TabIndex = 22;
            this.btnAddBalance50.Text = "50 TL YUKLE";
            this.btnAddBalance50.UseVisualStyleBackColor = true;
            this.btnAddBalance50.Click += new System.EventHandler(this.btnAddBalance50_Click);
            // 
            // btnAddBalance30
            // 
            this.btnAddBalance30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBalance30.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddBalance30.Location = new System.Drawing.Point(260, 33);
            this.btnAddBalance30.Name = "btnAddBalance30";
            this.btnAddBalance30.Size = new System.Drawing.Size(127, 23);
            this.btnAddBalance30.TabIndex = 21;
            this.btnAddBalance30.Text = "30 TL YUKLE";
            this.btnAddBalance30.UseVisualStyleBackColor = true;
            this.btnAddBalance30.Click += new System.EventHandler(this.btnAddBalance30_Click);
            // 
            // btnAddBalance20
            // 
            this.btnAddBalance20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBalance20.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddBalance20.Location = new System.Drawing.Point(133, 33);
            this.btnAddBalance20.Name = "btnAddBalance20";
            this.btnAddBalance20.Size = new System.Drawing.Size(121, 23);
            this.btnAddBalance20.TabIndex = 20;
            this.btnAddBalance20.Text = "20 TL YUKLE";
            this.btnAddBalance20.UseVisualStyleBackColor = true;
            this.btnAddBalance20.Click += new System.EventHandler(this.btnAddBalance20_Click);
            // 
            // btnAddBalance10
            // 
            this.btnAddBalance10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBalance10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddBalance10.Location = new System.Drawing.Point(6, 33);
            this.btnAddBalance10.Name = "btnAddBalance10";
            this.btnAddBalance10.Size = new System.Drawing.Size(121, 23);
            this.btnAddBalance10.TabIndex = 19;
            this.btnAddBalance10.Text = "10 TL YUKLE";
            this.btnAddBalance10.UseVisualStyleBackColor = true;
            this.btnAddBalance10.Click += new System.EventHandler(this.btnAddBalance10_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(288, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 34);
            this.label3.TabIndex = 20;
            this.label3.Text = "İ2İ BENİMLE";
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.Snow;
            this.pictureLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureLogo.Image = global::i2iBenimle.Properties.Resources.i2i_logo;
            this.pictureLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(207, 132);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 21;
            this.pictureLogo.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(335, 80);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 35);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "CIKIS";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 391);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.controlTag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.controlTag.ResumeLayout(false);
            this.pageMain.ResumeLayout(false);
            this.pageMain.PerformLayout();
            this.pageRemainingBalance.ResumeLayout(false);
            this.pageRemainingBalance.PerformLayout();
            this.pageRatePlan.ResumeLayout(false);
            this.pageCampaign.ResumeLayout(false);
            this.pageAddBalance.ResumeLayout(false);
            this.pageAddBalance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl controlTag;
        private System.Windows.Forms.TabPage pageMain;
        private System.Windows.Forms.TabPage pageRemainingBalance;
        private System.Windows.Forms.ProgressBar progressBarRemainingInternet;
        private System.Windows.Forms.Label labelRemainingInternet;
        private System.Windows.Forms.Label labelDescriptionRemainingInternet;
        private System.Windows.Forms.ProgressBar progressBarRemainingSms;
        private System.Windows.Forms.Label labelRemainingSms;
        private System.Windows.Forms.Label labelDescriptionRemainingSms;
        private System.Windows.Forms.ProgressBar progressBarRemainingMinute;
        private System.Windows.Forms.Label labelRemainingMinute;
        private System.Windows.Forms.Label labelDescriptionRemainingMinute;
        private System.Windows.Forms.Label labelRemainingBalance;
        private System.Windows.Forms.Label labelDescriptionRemainingBalance;
        private System.Windows.Forms.TabPage pageCampaign;
        private System.Windows.Forms.TabPage pageAddBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelRatePlan;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage pageRatePlan;
        private System.Windows.Forms.Button btnGencTarife;
        private System.Windows.Forms.Button btnEmekli;
        private System.Windows.Forms.Button btnMemur;
        private System.Windows.Forms.Label labelRatePlanDescription;
        private System.Windows.Forms.Label labelCampaignDescription;
        private System.Windows.Forms.Button btnRetired;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnCınema;
        private System.Windows.Forms.Label labelAddBalanceDescription;
        private System.Windows.Forms.Label labelAddBalanceTotalBalance;
        private System.Windows.Forms.Label labelAddBalancePhoneNumber;
        private System.Windows.Forms.Button btnAddBalance50;
        private System.Windows.Forms.Button btnAddBalance30;
        private System.Windows.Forms.Button btnAddBalance20;
        private System.Windows.Forms.Button btnAddBalance10;
        private System.Windows.Forms.Label labelAddBalanceTotalBalanceHeader;
        private System.Windows.Forms.Label labelAddBalancePhoneNumberHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MaskedTextBox txtAddBalancePhoneNumber;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelRemainingDate;
    }
}