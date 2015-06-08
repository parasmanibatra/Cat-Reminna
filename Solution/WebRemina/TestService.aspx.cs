using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebRemina
{
    public partial class TestService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference.AuthenticationServiceClient proxy = new ServiceReference.AuthenticationServiceClient();
            bool result = proxy.Ping();
            if (result)
                result = proxy.Authenticate("cat", "remina");
            if (result)
                responseMessage.Text = "authenticated successfully";
            else
                responseMessage.Text = "authentication failed";

        }
    }
}