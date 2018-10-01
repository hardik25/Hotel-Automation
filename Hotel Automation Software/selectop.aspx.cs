using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hotel_Automation_Software
{
    public partial class selectop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void checkin(object sender, EventArgs e)
        {
            Response.Redirect("staffAdmin.aspx");
        }
        protected void checkout(object sender, EventArgs e)
        {
            Response.Redirect("checkout.aspx");
        }
        protected void modify(object sender, EventArgs e)
        {
            Response.Redirect("tariff.aspx");
        }

    }
}