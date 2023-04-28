using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET_FrontEnd
{
    public partial class Kota : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Name"] != null)
            {
                loginlink.Visible = false;
                registerlink.Visible = false;
                LogoutLink.Visible = true;
                user.Visible = true;
                catalog.Visible = true;

                if (Session["type"].Equals("Manager"))
                {
                    catalog.Visible = true;
                    addprod.Visible = true;
                    admin.Visible = false;
                    remove.Visible = false;
                }
                else if (Session["type"].Equals("admin"))
                {
                    catalog.Visible = true;
                    addprod.Visible = true;
                    admin.Visible = true;
                    remove.Visible = true;
                }
            }
        }
    }
}