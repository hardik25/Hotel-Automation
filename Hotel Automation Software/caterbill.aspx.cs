using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hotel_Automation_Software
{
    public partial class caterbill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl.Font.Size = 30;
            lbl.Font.Bold = true;
            lbl.Text="Customer "+Request.QueryString["id"]+" is added with amount "+Request.QueryString["amount"];
        }
    }
}