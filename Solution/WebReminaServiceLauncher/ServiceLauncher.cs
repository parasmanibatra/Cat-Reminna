using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebReminaServices;
using System.ServiceModel;
namespace WebReminaServiceLauncher
{
    class ServiceLauncher
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(WebReminaServices.WebServices)))
            {
                host.Open();
                Console.WriteLine("Press enter to terminate the host");
                Console.ReadLine();
            }

        }
    }
}
