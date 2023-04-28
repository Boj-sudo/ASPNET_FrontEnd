using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPNET_FrontEnd.ServiceReference;

namespace ASPNET_FrontEnd
{
    public partial class ClearCart : System.Web.UI.Page
    {
        BackEndClient sr = new BackEndClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            sr.clearCart();
            Session["CartItems"] = 0;
            Response.Redirect("Cart.aspx");
        }
    }
}