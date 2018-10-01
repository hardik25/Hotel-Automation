using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Hotel_Automation_Software
{
    
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con;
        string selected;
        protected void Page_Load(object sender, EventArgs e)
        {
            string mycon = WebConfigurationManager.ConnectionStrings["Hotel"].ConnectionString;
            con = new SqlConnection(mycon);
        }

        protected void submit_login(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT password,category from logindata where username=@username";
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@username", username.Text);
            SqlDataReader dr;
            try
            {

                con.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                
                 string pass = password.Text;
                string enterpass = Convert.ToString(dr["password"]);
                string ca = admin.SelectedItem.Text;
                string cat=Convert.ToString(dr["category"]);
                lbl.Text = cat;
                if (enterpass.Equals(pass) && selected.Equals("customer"))
                {
                    Response.Redirect("clientReserve.aspx");
                }

                else if (enterpass.Equals(pass) && selected.Equals("admin"))
                {
                    Response.Redirect("selectop.aspx");
                }
                else if (enterpass.Equals(pass) && selected.Equals("catering"))
                {
                    Response.Redirect("catering.aspx");
                }

                else
                {
                    lbl.Text = "Error Logging in. Try again Later";
                }
             
                dr.Close();
            }
            catch (Exception Err)
            {
                lbl.Text = "Error Loggin In";
                lbl.Text += Err.Message;
            }
            finally
            {
                
                con.Close();
            }
        }
        protected void selection(object sender, EventArgs e)
        {
            selected = admin.SelectedValue.ToString();
        }

    }
}