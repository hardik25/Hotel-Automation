using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hotel_Automation_Software
{
    public partial class confirmcheck : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl.Font.Size = 40;
            lbl.Font.Bold = true;
            lbl.Font.Name = "verdana";
            lbl.Text="Welcome Mr./Ms. "+Request.QueryString["name"]+"!. Your Unique Identification Number is:"+Request.QueryString["id"];
        }
    }
}