using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsApplication.com.quantiguous;
using System.Collections;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Xml;

namespace APIBanking
{
    class DomesticRemittanceClient : SoapClient
    {
        public static readonly String VERSION = "1";
        public static readonly String SERVICE_NAME = "DomesticRemittanceByPartnerService";

        private static DomesticRemittanceByPartnerServiceClient createClient(Environment env)
        { 
            DomesticRemittanceByPartnerServiceClient client;

            client = new DomesticRemittanceByPartnerServiceClient( getBinding(env), env.getEndpointAddress(SERVICE_NAME));

            if (env.needsClientCertificate())
            {
                client.ClientCredentials.ClientCertificate.Certificate = env.getClientCertificate();
            }

            if (env.needsHTTPBasicAuth())
            {
                client.ClientCredentials.UserName.UserName = env.getUser();
                client.ClientCredentials.UserName.Password = env.getPassword();
            }

            return client;
        }

        public static remitResponse remit(Environment env, remit request)
        {
            DomesticRemittanceByPartnerServiceClient client = createClient(env);

            request.version = VERSION;

            using (new System.ServiceModel.OperationContextScope((System.ServiceModel.IClientChannel)client.InnerChannel))
            {
                System.Net.ServicePointManager.SecurityProtocol = env.getSecurityProtocol();

                System.ServiceModel.Web.WebOperationContext.Current.OutgoingRequest.UserAgent = "APIBanking.NET";


                IDictionaryEnumerator headers = env.getHeaders().GetEnumerator();
                while (headers.MoveNext())
                {

                    System.ServiceModel.Web.WebOperationContext.Current.OutgoingRequest.Headers.Add(headers.Key.ToString(), headers.Value.ToString());
                }

                remitResponse response = client.remit(request);

                return response;
            }
        }

        public static getBalanceResponse getBalance(Environment env, getBalance request)
        {
            DomesticRemittanceByPartnerServiceClient client = createClient(env);

            request.version = VERSION;

                using (new System.ServiceModel.OperationContextScope((System.ServiceModel.IClientChannel)client.InnerChannel))
                {
                    System.Net.ServicePointManager.SecurityProtocol = env.getSecurityProtocol();

                    System.ServiceModel.Web.WebOperationContext.Current.OutgoingRequest.UserAgent = "APIBanking.NET";


                    IDictionaryEnumerator headers = env.getHeaders().GetEnumerator();
                    while (headers.MoveNext())
                    {

                        System.ServiceModel.Web.WebOperationContext.Current.OutgoingRequest.Headers.Add(headers.Key.ToString(), headers.Value.ToString());
                    }

                    getBalanceResponse response = client.getBalance(request);

                    return response;
                }
        }
    }
}
