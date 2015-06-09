using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebRemina
{
    public class AppReminaCommunicator
    {
        private ServiceReference.AuthenticationServiceClient m_proxy;
        public AppReminaCommunicator()
        {
            if (m_proxy == null)
                m_proxy = new ServiceReference.AuthenticationServiceClient();
        }
        public bool Ping()
        {
            return m_proxy.Ping();
        }
        public bool Authenticate(string userName, string password)
        {
            return m_proxy.Authenticate(userName, password);
        }
    }
}