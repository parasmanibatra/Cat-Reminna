using System;
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
        [OperationContract]
        bool Authenticate(string userName, string password);
        [OperationContract]
        List<string> GetUsers();
    }
}
