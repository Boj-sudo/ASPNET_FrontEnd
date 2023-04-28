using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPNET_FrontEnd.ServiceReference;

namespace ASPNET_FrontEnd
{
    public partial class Cart : System.Web.UI.Page
    {
        BackEndClient sr = new BackEndClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            int count = 1;
            double sum = 0;
            double vat = 0.15;
            string display = " ";
            string show = " ";
            string id = Request.QueryString["ID"];

            Session["Item"] = id;

            if (Session["Firstname"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                show += "<table class='table'>";
                show += "<thead class='thead-primary'>";
                show += "<tr class='text-center' style='color: white'>";
                show += "<th>&nbsp;</th>";
                show += "<th>&nbsp;</th>";
                show += "<th>Product image</th>";
                show += "<th>Product name</th>";
                show += "<th>Price</th>";
                show += " <th>Quantity</th>";
                show += "<th>Total</th>";
                show += "</tr>";
                show += "</thead>";
                show += "<tbody>";

                if (Session["Item"] == null)
                {
                    dynamic new_item = sr.getCartItems();

                    foreach (CartItems c in new_item)
                    {
                        var _product = sr.AboutProduct(Convert.ToString(c.ID));
                        double _total = Convert.ToInt32(_product.Price * c.Quantity);

                        show += "<tr class='text-center' style='color: white'>";
                        show += "<td class='product-remove'><a href = '#' ><span class='ion-ios-close'></span></a></td>";
                        show += "<td><img src = '" + _product.Image + "'class='img-fluid' alt='' width='150' Height='150'></td>";
                        show += "<td class='product-name'>";
                        show += "<h3><b>" + _product.Name + "</b></h3>";
                        show += "<p><b>" + _product.Description + "</b></p>";
                        show += "</td>";
                        show += "<td class='price'> R " + _product.Price + "</td>";
                        show += "<td class='quantity'>" + c.Quantity + "</td>";
                        show += "<td class='total'> R " + Math.Round(_total) + "</td>";
                        show += "</tr>";

                        sum += _total;
                    }
                }
                else
                {
                    CartItems items = new CartItems
                    {
                        ID = Convert.ToInt32(Session["Item"]),
                        Quantity = count
                    };

                    bool add = sr.addToCart(items);

                    if (add == true)
                    {
                        int new_item = Convert.ToInt32((Session["Item"]).ToString());
                        new_item += 1;
                        Session["Item"] = new_item;
                        Response.Redirect("Shop.aspx");
                    }
                }

                show += "</tbody>";
                show += "</table>";

                double vat_total = sum * vat;

                display += "<h3 > Cart Totals </h3>";
                display += "<p class='d-flex'>";
                display += "<span>Subtotal </span>";
                display += "<span> R " + sum + "</span>";
                display += "</p>";
                display += "<p class='d-flex'>";
                display += "<span>VAT Total </span>";
                display += "<span> R " + vat_total + "</span>";
                display += "</p>";
                display += "<p class='d-flex'>";
                display += "<span>Discount</span>";
                display += "<span>R50.00</span>";
                display += "</p>";
                display += "<hr>";
                display += "<p class='d-flex total-price'>";
                display += "<span>Total</span>";
                display += "<span> R " + (sum - vat_total) + "</span>";
                display += "</p>";

                showcart.InnerHtml = show;
                totalcart.InnerHtml = display;
            }
        }
    }
}