﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
namespace AppReminaInterfaces
{
    [ServiceContract]
    public interface IAuthenticationService
    {
        [OperationContract]
        bool Ping();
    }
}
