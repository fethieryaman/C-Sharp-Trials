using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i2iBenimle
{
    class User
    {
        public static String getRetiredCampaign = User.getCampaignRetired().ToString();
        public static String getCinemaCampaign = User.getCampaignCinema().ToString();
        public static String getFoodCampaign = User.getCampaignFood().ToString();
        public static String getYoungRatePlan = User.getRatePlanYoung().ToString();
        public static String getRetiredRatePlan = User.getRatePlanRetired().ToString();
        public static String getOfficerRatePlan = User.getRatePlanOfficer().ToString();



        private static Login loginObject = new Login();
        private static int contractID = loginObject.getContractID;


        public static int getRemainingMinute()
            {
          
                ServiceReference.dbi2iBenimleClient connectObject = new ServiceReference.dbi2iBenimleClient();
                int remainingMinute = connectObject.getBalance(contractID).remaining_voice;
                return remainingMinute;
            }
            public static int getRemainingSms()
            {

                ServiceReference.dbi2iBenimleClient connect = new ServiceReference.dbi2iBenimleClient();
                int remainingSms = connect.getBalance(contractID).remaining_sms;
                return remainingSms;
            }
            public static int getRemainingInternet()
            {

                ServiceReference.dbi2iBenimleClient connect = new ServiceReference.dbi2iBenimleClient();
                int remainingInternet = connect.getBalance(contractID).remaining_data;
                return remainingInternet;
            }

            public static String getRemainingDate()
            {
                ServiceReference.dbi2iBenimleClient connect = new ServiceReference.dbi2iBenimleClient();
                String remainingDate = connect.getBalance(contractID).expiration_date;
                return remainingDate;
            }
            public static int getRatePlanMinute()
            {
                ServiceReference.dbi2iBenimleClient connectObject = new ServiceReference.dbi2iBenimleClient();
                int ratePlanMinute = connectObject.getRateplan(contractID).voice_amount;
                return ratePlanMinute;
            }

            public static int getRatePlanSms()
            {
                ServiceReference.dbi2iBenimleClient connectObject = new ServiceReference.dbi2iBenimleClient();
                int ratePlanSms = connectObject.getRateplan(contractID).sms_amount;
                return ratePlanSms;
            }

            public static int getRatePlanInternet()
            {
                ServiceReference.dbi2iBenimleClient connectObject = new ServiceReference.dbi2iBenimleClient();
                int ratePlanInternet = connectObject.getRateplan(contractID).data_amount;
                return ratePlanInternet;
            }


            public static String getFirstName()
            {
                ServiceReference.dbi2iBenimleClient connect = new ServiceReference.dbi2iBenimleClient();
                String firstName = connect.getCustomerCredential(contractID).first_name;
                return firstName;
            }

            public static String getLastName()
            {
                ServiceReference.dbi2iBenimleClient connect = new ServiceReference.dbi2iBenimleClient();
                String lastName = connect.getCustomerCredential(contractID).last_name;
                return lastName;
            }

            public static int getTotalBalance(int addBalance, string addBalancePhoneNumber)
            {
                ServiceReference.dbi2iBenimleClient connect = new ServiceReference.dbi2iBenimleClient();
                int totalBalance = connect.updateCustomerWallet(addBalance,addBalancePhoneNumber);
                return totalBalance;

            }


            public static int getremainingBalance()
            {

                ServiceReference.dbi2iBenimleClient connect = new ServiceReference.dbi2iBenimleClient();
                int remainingBalance = connect.getCustomerWallet(contractID).amount;
                return remainingBalance;

            }

            public static String getRatePlanName()
            {
                ServiceReference.dbi2iBenimleClient connect = new ServiceReference.dbi2iBenimleClient();
                String ratePlanName = connect.getRateplan(contractID).name;
                return ratePlanName;
            }

            public static String getPhoneNumber()
            {
                String phoneNumber = loginObject.getPhoneNumber;
                return phoneNumber;
            }

            public static String getRatePlanDescription()
            {
                ServiceReference.dbi2iBenimleClient connect = new ServiceReference.dbi2iBenimleClient();
                String ratePlanDescription = connect.getRateplan(contractID).description;
                return ratePlanDescription;
            }

            
            public static Tuple<string> getRatePlanYoung()
            {
                ServiceReference.dbi2iBenimleClient connect = new ServiceReference.dbi2iBenimleClient();
             
                var youngRatePlan = new Tuple<string>
                (
                    connect.getRateplanList()[1].name  + Environment.NewLine +
                    connect.getRateplanList()[1].voice_amount.ToString() + "   DAKIKA" + "     "   + 
                    connect.getRateplanList()[1].sms_amount.ToString() + "   SMS"    + "     "   +
                    connect.getRateplanList()[1].data_amount.ToString() + "   MB INTERNET" + Environment.NewLine +
                    connect.getRateplanList()[1].price.ToString() + "  TL"
                );

            return youngRatePlan;

            }


            public static Tuple<string> getRatePlanRetired()
            {

                ServiceReference.dbi2iBenimleClient connect = new ServiceReference.dbi2iBenimleClient();

                var retiredRatePlan = new Tuple<string>
                (
                    connect.getRateplanList()[0].name + Environment.NewLine +
                    connect.getRateplanList()[0].voice_amount.ToString() + "   DAKIKA" + "     " +
                    connect.getRateplanList()[0].sms_amount.ToString() + "   SMS" + "     " +
                    connect.getRateplanList()[0].data_amount.ToString() + "   MB INTERNET" + Environment.NewLine +
                    connect.getRateplanList()[0].price.ToString() + "  TL"
                );

                return retiredRatePlan;

            }


            public static Tuple<string> getRatePlanOfficer()
            {

                ServiceReference.dbi2iBenimleClient connect = new ServiceReference.dbi2iBenimleClient();

                var officerRatePlan = new Tuple<string>
                (
                    connect.getRateplanList()[2].name + Environment.NewLine +
                    connect.getRateplanList()[2].voice_amount.ToString() + "   DAKIKA" + "     " +
                    connect.getRateplanList()[2].sms_amount.ToString() + "   SMS" + "     " +
                    connect.getRateplanList()[2].data_amount.ToString() + "   MB INTERNET" + Environment.NewLine +
                    connect.getRateplanList()[2].price.ToString() + "  TL"
                );

                return officerRatePlan;

            }


            public static Tuple<string> getCampaignRetired()
            {

                ServiceReference.dbi2iBenimleClient connect = new ServiceReference.dbi2iBenimleClient();

                var officerCampaign = new Tuple<string>
                (
                    connect.getCampaign()[0].name + Environment.NewLine +
                    connect.getCampaign()[0].description.ToString() 

                );

                return officerCampaign;

            }

            public static Tuple<string> getCampaignCinema()
            {

                ServiceReference.dbi2iBenimleClient connect = new ServiceReference.dbi2iBenimleClient();

                var cinemaCampaign = new Tuple<string>
                (
                    connect.getCampaign()[1].name + Environment.NewLine +
                    connect.getCampaign()[1].description.ToString()

                );

                return cinemaCampaign;

            }

            public static Tuple<string> getCampaignFood()
            {

                ServiceReference.dbi2iBenimleClient connect = new ServiceReference.dbi2iBenimleClient();

                var foodCampaign = new Tuple<string>
                (
                    connect.getCampaign()[2].name + Environment.NewLine +
                    connect.getCampaign()[2].description.ToString()

                );

                return foodCampaign;

            }

            
            

    }
}
