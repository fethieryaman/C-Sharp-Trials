using System.Windows.Forms;
using System.Net.NetworkInformation;
using System;
using System.Net;
using Newtonsoft.Json.Linq;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int ipInformationNumber = 4;
        String[] submasks, ips, connectionName;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            ipadress.Text = "MAC adresi : " + getMacAdress();
            ip_information.Text = "";
            ip_information_title.Text = "ip information : ";
            getIpAddress();
            for (int i = 0; i<ipInformationNumber; i++)
                ip_information.Text += connectionName[i] +  "   IP adress :   " + ips[i] + " SUBNET MASK:   " + submasks[i] + "\n";
            
            if (checkInternetConnection())
            {
                check_internet.Text = "Connect To Internet ...";
                String[] coords = getCoords();
                webControl1.WebView.Url = "http://www.google.com/maps?q=" + coords[0] + ",+" + coords[1]; ;
            }
            else
            {
                check_internet.Text = "Connect Not Internet ...";
                webControl1.Hide();
            }
 
        }


        public string getMacAdress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String macAdress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (macAdress == String.Empty)
                {                 
                    macAdress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return macAdress;
        }

        static public string[] getCoords()
        {
            String[] coords = new String[2];
            JObject jObject = JObject.Parse(new WebClient().DownloadString("http://ip-api.com/json"));
            var coordLat = (long)jObject["lat"];
            var coordLon = (long)jObject["lon"];
            coords[0] = coordLat.ToString();
            coords[1] = coordLon.ToString();
            return coords;
        }

        public void getIpAddress()
        {
            submasks = new String[4];
            ips = new String[4];
            connectionName = new String[4];
            int i = 0;
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {                
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            connectionName[i] = ni.Name;
                            ips[i] = ip.Address.ToString();
                            submasks[i] = ip.IPv4Mask.ToString();
                            i += 1;
                        }
                    }
                }
            }
        }


   
        public static bool checkInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

    }

    
}


