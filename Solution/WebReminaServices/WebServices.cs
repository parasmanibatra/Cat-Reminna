using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using AppReminaInterfaces;

namespace WebReminaServices
{
    public class WebServices : IServices
    {
        IAuthenticationService m_appReminaAuthenticateServiceClient;
        public WebServices()
        {
            InitializeAppReminaClient();
        }
        private void InitializeAppReminaClient()
        {
            if (m_appReminaAuthenticateServiceClient == null)
                m_appReminaAuthenticateServiceClient = ChannelFactory<IAuthenticationService>.CreateChannel(new BasicHttpBinding(),
                    new EndpointAddress("http://localhost:8083/AppReminaService/AppReminaService"));
        }
        public bool Ping()
        {
            return m_appReminaAuthenticateServiceClient.Ping();
        }
        public bool Authenticate(string username, string password)
        {
            return m_appReminaAuthenticateServiceClient.Authenticate(username,password);
        }
    }
}
