using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;

namespace i2iBenimle
{
    public partial class MainForm : Form
    {
        private static readonly log4net.ILog log =
        log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MainForm()
        {
            InitializeComponent();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            Color colorValueFrmHex = ColorTranslator.FromHtml("#76B852");
            this.BackColor = colorValueFrmHex;
            this.Location = new Point(600, 300);

            //  Ana sayfa sekmesindeki labellar dolduruldu.
            labelFirstName.Text = User.getFirstName();
            labelLastName.Text = User.getLastName();
            labelPhoneNumber.Text = User.getPhoneNumber();
            labelRatePlan.Text = User.getRatePlanName();


            // Kalan kullanımlarım içindeki labeller dolduruldu.
            
            labelRemainingMinute.Text = Convert.ToString(User.getRemainingMinute()) + "/" + User.getRatePlanMinute() + " DAKIKA";
            labelRemainingSms.Text = Convert.ToString(User.getRemainingSms()) + "/" + User.getRatePlanSms() + "  SMS";
            labelRemainingInternet.Text = Convert.ToString(User.getRemainingInternet()) +   "/" + User.getRatePlanInternet() +  "MB";
            labelRemainingBalance.Text = Convert.ToString(User.getremainingBalance());
            labelRemainingDate.Text = User.getRemainingDate() + " ' tarihine kadar geçerlidir.";

            // Kalan kullanımlarım içindeki progressbarlar dolduruldu.
      
            
            progressBarRemainingMinute.Maximum = User.getRatePlanMinute();
            progressBarRemainingMinute.Value = User.getRemainingMinute();

            progressBarRemainingSms.Maximum = User.getRatePlanSms();
            progressBarRemainingSms.Value = User.getRemainingSms();

            progressBarRemainingInternet.Maximum = User.getRatePlanInternet();
            progressBarRemainingInternet.Value = User.getRemainingInternet();


        }


        // Tarifeler sayfasındaki butonlar
        private void btnGencTarife_Click(object sender, EventArgs e)
        {
            try
            {
                labelRatePlanDescription.Text = User.getYoungRatePlan;
            }
            catch (Exception)
            {
                log.Error("Genc tarife bilgileri görüntülenmiyor.");
            }

        }

        private void btnMemur_Click(object sender, EventArgs e)
        {
            labelRatePlanDescription.Text = User.getOfficerRatePlan;
        }

        private void btnEmekli_Click(object sender, EventArgs e)
        {

            labelRatePlanDescription.Text = User.getRetiredRatePlan;
        }


        // Kampanyalar sayfasındaki butonlar...
        private void btnRetired_Click(object sender, EventArgs e)
        {
            labelCampaignDescription.Text = User.getRetiredCampaign;
        }

        private void btnCınema_Click(object sender, EventArgs e)
        {
            labelCampaignDescription.Text = User.getCinemaCampaign;
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            labelCampaignDescription.Text = User.getFoodCampaign;
        }

        private void labelCampaignDescription_Click(object sender, EventArgs e)
        {

        }

        // TL yükle sekmesindeki butonlar.. 

        private void btnAddBalance10_Click(object sender, EventArgs e)
        {
            String addBalancePhoneNumber = txtAddBalancePhoneNumber.Text;
            int totalBalance = User.getTotalBalance(10, addBalancePhoneNumber);
            if(txtAddBalancePhoneNumber.Text.Length < 11)
            {
                labelError.Visible = true;
                labelError.Text = "Telefon numarası 11 haneli olmalıdır.";
                labelAddBalancePhoneNumber.Visible = false;
                labelAddBalanceTotalBalance.Visible = false;
                labelAddBalancePhoneNumberHeader.Visible = false;
                labelAddBalanceTotalBalanceHeader.Visible = false;
                labelAddBalanceDescription.Visible = false;

            }
            
            else if ( totalBalance == -2)
            {
                labelError.Visible = true;
                labelError.Text = "Yükleme yapılacak numara bulunamadı.";
                labelAddBalancePhoneNumber.Visible = false;
                labelAddBalanceTotalBalance.Visible = false;
                labelAddBalancePhoneNumberHeader.Visible = false;
                labelAddBalanceTotalBalanceHeader.Visible = false;
                labelAddBalanceDescription.Visible = false;
            }
            else if (totalBalance != -2)
            {
                Login loginObject = new Login();
                labelError.Visible = false;
                labelAddBalancePhoneNumber.Text = txtAddBalancePhoneNumber.Text;
                labelAddBalanceTotalBalance.Text = Convert.ToString(10) + "   TL";
                labelRemainingBalance.Text = totalBalance + "   TL";
                labelAddBalancePhoneNumber.Visible = true;
                labelAddBalanceTotalBalance.Visible = true;
                labelAddBalancePhoneNumberHeader.Visible = true;
                labelAddBalanceTotalBalanceHeader.Visible = true;
                labelAddBalanceDescription.Visible = true;
            }

        }

        private void btnAddBalance20_Click(object sender, EventArgs e)
        {
            String addBalancePhoneNumber = txtAddBalancePhoneNumber.Text;
            int totalBalance = User.getTotalBalance(20, addBalancePhoneNumber);
            if (txtAddBalancePhoneNumber.Text.Length < 11)
            {
                labelError.Visible = true;
                labelError.Text = "Lutfen telefon numaranızı 11 haneli olarak giriniz.";
                labelAddBalancePhoneNumber.Visible = false;
                labelAddBalanceTotalBalance.Visible = false;
                labelAddBalancePhoneNumberHeader.Visible = false;
                labelAddBalanceTotalBalanceHeader.Visible = false;
                labelAddBalanceDescription.Visible = false;

            }

            else if (totalBalance == -2)
            {
                labelError.Visible = true;
                labelError.Text = "Bu numaraya ait bir abonemiz bulunmamaktadır.";
                labelAddBalancePhoneNumber.Visible = false;
                labelAddBalanceTotalBalance.Visible = false;
                labelAddBalancePhoneNumberHeader.Visible = false;
                labelAddBalanceTotalBalanceHeader.Visible = false;
                labelAddBalanceDescription.Visible = false;
            }
            else if (totalBalance != -2)
            {
                labelError.Visible = false;
                labelAddBalancePhoneNumber.Text = txtAddBalancePhoneNumber.Text;
                labelAddBalanceTotalBalance.Text = Convert.ToString(20) + "   TL";
                labelRemainingBalance.Text = totalBalance + "   TL";
                labelAddBalancePhoneNumber.Visible = true;
                labelAddBalanceTotalBalance.Visible = true;
                labelAddBalancePhoneNumberHeader.Visible = true;
                labelAddBalanceTotalBalanceHeader.Visible = true;
                labelAddBalanceDescription.Visible = true;
            }
        }



        private void btnAddBalance30_Click(object sender, EventArgs e)
        {
            String addBalancePhoneNumber = txtAddBalancePhoneNumber.Text;
            int totalBalance = User.getTotalBalance(30, addBalancePhoneNumber);
            if (txtAddBalancePhoneNumber.Text.Length < 11)
            {
                labelError.Visible = true;
                labelError.Text = "Lutfen telefon numaranızı 11 haneli olarak giriniz.";
                labelAddBalancePhoneNumber.Visible = false;
                labelAddBalanceTotalBalance.Visible = false;
                labelAddBalancePhoneNumberHeader.Visible = false;
                labelAddBalanceTotalBalanceHeader.Visible = false;
                labelAddBalanceDescription.Visible = false;

            }

            else if (totalBalance == -2)
            {
                labelError.Visible = true;
                labelError.Text = "Bu numaraya ait bir abonemiz bulunmamaktadır.";
                labelAddBalancePhoneNumber.Visible = false;
                labelAddBalanceTotalBalance.Visible = false;
                labelAddBalancePhoneNumberHeader.Visible = false;
                labelAddBalanceTotalBalanceHeader.Visible = false;
                labelAddBalanceDescription.Visible = false;
            }
            else if (totalBalance != -2)
            {
                labelError.Visible = false;
                labelAddBalancePhoneNumber.Text = txtAddBalancePhoneNumber.Text;
                labelAddBalanceTotalBalance.Text = Convert.ToString(30) + "   TL";
                labelRemainingBalance.Text = totalBalance + "   TL";
                labelAddBalancePhoneNumber.Visible = true;
                labelAddBalanceTotalBalance.Visible = true;
                labelAddBalancePhoneNumberHeader.Visible = true;
                labelAddBalanceTotalBalanceHeader.Visible = true;
                labelAddBalanceDescription.Visible = true;
            }
        }

        private void btnAddBalance50_Click(object sender, EventArgs e)
        {
            String addBalancePhoneNumber = txtAddBalancePhoneNumber.Text;
            int totalBalance = User.getTotalBalance(50, addBalancePhoneNumber);
            if (txtAddBalancePhoneNumber.Text.Length < 11)
            {
                labelError.Visible = true;
                labelError.Text = "Lutfen telefon numaranızı 11 haneli olarak giriniz.";
                labelAddBalancePhoneNumber.Visible = false;
                labelAddBalanceTotalBalance.Visible = false;
                labelAddBalancePhoneNumberHeader.Visible = false;
                labelAddBalanceTotalBalanceHeader.Visible = false;
                labelAddBalanceDescription.Visible = false;

            }

            else if (totalBalance == -2)
            {
                labelError.Visible = true;
                labelError.Text = "Bu numaraya ait bir abonemiz bulunmamaktadır.";
                labelAddBalancePhoneNumber.Visible = false;
                labelAddBalanceTotalBalance.Visible = false;
                labelAddBalancePhoneNumberHeader.Visible = false;
                labelAddBalanceTotalBalanceHeader.Visible = false;
                labelAddBalanceDescription.Visible = false;
            }
            else if (totalBalance != -2)
            {
                labelError.Visible = false;
                labelAddBalancePhoneNumber.Text = txtAddBalancePhoneNumber.Text;
                labelAddBalanceTotalBalance.Text = Convert.ToString(50) + "   TL";
                labelRemainingBalance.Text = totalBalance + "   TL";
                labelAddBalancePhoneNumber.Visible = true;
                labelAddBalanceTotalBalance.Visible = true;
                labelAddBalancePhoneNumberHeader.Visible = true;
                labelAddBalanceTotalBalanceHeader.Visible = true;
                labelAddBalanceDescription.Visible = true;
            }
        }
                private void pageMain_Click(object sender, EventArgs e)
                {

                }

                private void pageRemainingBalance_Click(object sender, EventArgs e)
                {

                }

                private void pageRatePlan_Click(object sender, EventArgs e)
                {

                }


                private void pageCampaign_Click(object sender, EventArgs e)
                {

                }

                private void pageAddBalance_Click(object sender, EventArgs e)
                {

                }

                private void button1_Click(object sender, EventArgs e)
                {
                    Login loginObject = new Login();
                    loginObject.Show();
                    Hide();
                }
            }
        }
