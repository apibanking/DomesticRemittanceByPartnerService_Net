using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void run_Click(object sender, EventArgs e)
        {

            String message;
            APIBanking.Environment env = new APIBanking.Environments.YBL.UAT("testclient","test@123", "5bbc3c5c-6225-4935-8146-523b5883097a", "bP7eY0fA7tW7nX7yE6oY8qD7tF3yL3fE4uK0pJ7cP3kE0mV8rF", null);
            com.quantiguous.getBalance getBalanceRequest = new com.quantiguous.getBalance();
            com.quantiguous.getBalanceResponse getBalanceResponse;


            getBalanceRequest.partnerCode = "smb1";
            getBalanceRequest.customerID = "857552";
            getBalanceRequest.accountNo = "001587700000054";


            try
            {
                getBalanceResponse = APIBanking.DomesticRemittanceClient.getBalance(env, getBalanceRequest);
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
                String faultSubCode = ex.Code.SubCode.SubCode.Namespace + ":" + ex.Code.SubCode.SubCode.Name;

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

            response.Text = message;
        }
    }
}
