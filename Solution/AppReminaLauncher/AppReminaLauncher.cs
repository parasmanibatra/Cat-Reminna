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
            using (ServiceHost host = new ServiceHost(typeof(AppRemina.AppReminaService)))
            {
               host.Open();
               Console.WriteLine("Press any key to terminate host");
               Console.Read();
            }

        }
    }
}
