using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppReminaInterfaces;

namespace AppRemina
{
    public class AppReminaService : IAuthenticationService
    {
        public bool Ping()
        {
            return true;
        }
    }
}
