using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WebReminaServices
{
    [ServiceContract]
    public interface IServices
    {
        [OperationContract]
        [WebGet(ResponseFormat= WebMessageFormat.Json)]
        bool Ping();
        [OperationContract]
        [WebGet(ResponseFormat= WebMessageFormat.Json,UriTemplate = "Authenticate/{userName}/{password}")]
        bool Authenticate(string userName,string password);
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        List<string> GetUsers();
    }
}
