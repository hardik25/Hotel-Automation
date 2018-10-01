using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Web.Configuration;
using System.Web.UI.WebControls;

namespace Hotel_Automation_Software
{
    public partial class catering : System.Web.UI.Page
    {
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Hotel"].ConnectionString);
        }
        protected void add_bill(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT balance FROM checkedin WHERE cust_id=@customer";
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@customer",custID.Text);
            SqlDataReader dr;
            int inserted = 0;
            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                int balance = Convert.ToInt32(dr["balance"]);
                dr.Close();
                balance = balance + Convert.ToInt32(amount.Text);
                //lbl.Text = Convert.ToString(balance);
                cmd = new SqlCommand("UPDATE checkedin SET balance=@bal where cust_id=@cus", con);
                
                
                cmd.Parameters.AddWithValue("@bal", balance);
                cmd.Parameters.AddWithValue("@cus", Convert.ToInt32(custID.Text));
                inserted = cmd.ExecuteNonQuery();
             //   lbl.Text = custID.Text + " " + balance + " " + Convert.ToInt32(custID.Text);
                string query = "caterbill.aspx?id=" + custID.Text + "&amount=" + amount.Text;
                Response.Redirect(query);
            }
            catch (Exception err)
            {
               lbl.Text = "Error" + err.Message;
            }
            finally
            {
                con.Close();
            }

        }
    }
}