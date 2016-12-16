using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApplication
{
    public partial class Main : Form
    {
   
        public Main()
        {
            InitializeComponent();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            PartnerCode.Text = "smb1";
            accountNo.Text   = "001587700000054";
            CustomerID.Text  = "857552";
     
        }

        private void run_Click(object sender, EventArgs e)
        {
            //To empty the response text box while sending a new request
        
            response.Text = "";
            //reqURL.Text = "";
          
            String message;
            String url = "" ;

            APIBanking.Environment env;

            
            if ( clientSSL.Checked )
            {
                String certFileFullPath = Directory.GetCurrentDirectory() + "\\quantiguous.p12";

                env = new APIBanking.Environments.YBL.UAT("testclient", "test@123",
                    "5bbc3c5c-6225-4935-8146-523b5883097a", "bP7eY0fA7tW7nX7yE6oY8qD7tF3yL3fE4uK0pJ7cP3kE0mV8rF",
                   certFileFullPath, "quantiguous");
             
            }
            else
            {
                // without client ssl
                env = new APIBanking.Environments.YBL.UAT("testclient", "test@123", "5bbc3c5c-6225-4935-8146-523b5883097a", "bP7eY0fA7tW7nX7yE6oY8qD7tF3yL3fE4uK0pJ7cP3kE0mV8rF", null);
            }
            
            com.quantiguous.getBalance getBalanceRequest = new com.quantiguous.getBalance();
            com.quantiguous.getBalanceResponse getBalanceResponse;


            getBalanceRequest.partnerCode = PartnerCode.Text;
            getBalanceRequest.customerID = CustomerID.Text;
            getBalanceRequest.accountNo = accountNo.Text;

          
            try
            {  
                getBalanceResponse = APIBanking.DomesticRemittanceClient.getBalance(env, getBalanceRequest);
                url = APIBanking.DomesticRemittanceClient.getURL(env).ToString();
                message = getBalanceResponse.accountBalanceAmount.ToString();
            }
            catch (TimeoutException ex)
            {
                message = ex.Message;
            }
            catch (FaultException ex)
            {
                // for information on faultCode, refer documentation 
                String faultCode = ex.Code.SubCode.Namespace + ":" + ex.Code.SubCode.Name;

                // faultSubCode is for information only, do not use in your application, this is subject to change without notice
                String faultSubCode  = "";
                if (ex.Code.SubCode.SubCode != null) { 
                    faultSubCode = ex.Code.SubCode.SubCode.Namespace + ":" + ex.Code.SubCode.SubCode.Name;
                }

                // an english message, you can choose to show this to your users
                String FaultReason = ex.Reason.ToString();

                message = faultCode + "(" + faultSubCode + ")" + " - " + FaultReason;

            }

            catch (CommunicationException ex)
            {
                message = ex.Message;
            }

            catch (Exception ex)
            {
                message = ex.ToString();
            }

            response.Text = "Available Balance: " + message;
            reqURL.Text = url;
        }
   
    }
}
