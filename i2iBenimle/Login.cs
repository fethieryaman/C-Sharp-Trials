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
    public partial class Login : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static string globalPhoneNumber  = String.Empty;
        private static string globalPassword     = String.Empty;
        private static int contractID = 0;

        public Login()
        {
            InitializeComponent();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Color colorValueFrmHex = ColorTranslator.FromHtml("#76B852");
            this.BackColor = colorValueFrmHex;
            this.Location = new Point(600, 300);            
        }

        
        private void btnEntry_Click(object sender, EventArgs e)
        {

            if (maskedPhoneNumber.Text.Length < 11 && maskedPhoneNumber.Text.Length != 0)
            {
                labelLoginError.Visible = true;
                labelLoginError.Text = "Telefon numarası 11 haneli olmalıdır.";
                log.Error("Telefon numarası 11 haneli olmalıdır");
            }
            else if (maskedPhoneNumber.Text.Length == 0 || maskedPassword.Text.Length == 0)
            {
                labelLoginError.Visible = true;
                labelLoginError.Text = "Telefon numarası/şifre boş bırakılamaz.";
                log.Error("telefon numarası/şifre boş bırakılamaz.");
            }
            else if (maskedPhoneNumber.Text.Length == 11)
            {
                log.Info("web servise bağlanıyor");
                ServiceReference.dbi2iBenimleClient connectWebService = new ServiceReference.dbi2iBenimleClient();
                contractID = connectWebService.getContractId(maskedPhoneNumber.Text, maskedPassword.Text);
                log.Info("web servisten responce alındı");
                if (contractID != -1) {
                    globalPhoneNumber = maskedPhoneNumber.Text;
                    globalPassword = maskedPassword.Text;
                    log.Info("ana sayfaya yönlendiriliyor ...");
                    MainForm mainFormObject = new MainForm();
                    mainFormObject.Show();
                    Hide();
                }
                else
                {
                    labelLoginError.Visible = true;
                    labelLoginError.Text = "Telefon numarası veya şifre hatalıdır. Lütfen tekrar deneyiniz.";
                    log.Error("Telefon numarası veya şifre hatalıdır. Lütfen tekrar deneyiniz.");
                }
            }
            else
            {
                labelLoginError.Visible = true;
                labelLoginError.Text = "System ERROR";
                log.Error("System ERROR");

            }

        }

        public int getContractID
        {

            get
            {
                return contractID;
            }
        }

        public String getPhoneNumber
        {
            get
            {
                return globalPhoneNumber;
            }
        }

        public String getPassword
        {
            get
            {
                return globalPassword;
            }
        }
    }
}
