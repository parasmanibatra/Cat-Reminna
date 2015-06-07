using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace AppReminaLauncher
{
    class AppReminaLauncher
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(AppRemina.AppReminaService), 
                new Uri("http://localhost:8083/AppReminaService")))
            {
                host.AddServiceEndpoint("AppReminaInterfaces.IAuthenticationService", new BasicHttpBinding(),
                    "AppReminaService");
                ServiceMetadataBehavior metaDataBehaviour = host.Description.Behaviors.Find<ServiceMetadataBehavior>();
                if (metaDataBehaviour == null)
                {
                    metaDataBehaviour = new ServiceMetadataBehavior();
                    metaDataBehaviour.HttpGetEnabled = true;
                }
                host.Description.Behaviors.Add(metaDataBehaviour);
                host.Open();

                Console.WriteLine("Press any key to terminate host");
                Console.Read();
            }
        }
    }
}
