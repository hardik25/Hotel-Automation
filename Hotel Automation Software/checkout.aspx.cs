using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Web.Configuration;
using System.IO;

namespace Hotel_Automation_Software
{
    public partial class checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void register(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Hotel"].ConnectionString);
            SqlCommand c = new SqlCommand("SELECT first_name,last_name from checkedin where cust_id=@cus", con);
            c.Parameters.AddWithValue("@cus",Convert.ToInt32(frequent.Text));
            SqlDataReader dr;
            try
            {
                con.Open();
                dr = c.ExecuteReader();
                dr.Read();
                Random rd = new Random();
                int id = rd.Next(100);

                c = new SqlCommand("INSERT INTO frequent(id,first_name,last_name) VALUES (@id,@first_name,@last_name)", con);
                c.Parameters.AddWithValue("@id", id);
                c.Parameters.AddWithValue("@first_name", Convert.ToString(dr["first_name"]));
                c.Parameters.AddWithValue("@last_name", Convert.ToString(dr["last_name"]));
                dr.Close();

                c.ExecuteNonQuery();
            }

            catch (Exception err)
            {
                lbl.Text = "Error " + err.Message;
            }
            finally
            {
                con.Close();
            }
        }

        protected void print(object sender, EventArgs args)
        {
            StreamWriter w;
            w = File.CreateText(@"C:\Users\Hardik\Desktop\"+frequent.Text+".txt");
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["Hotel"].ConnectionString);
            SqlCommand c = new SqlCommand("SELECT * from checkedin where cust_id=@cus", con);
            c.Parameters.AddWithValue("@cus", Convert.ToInt32(frequent.Text));
            SqlDataReader dr;
            try
            {
                con.Open();
                dr = c.ExecuteReader();
                dr.Read();
                w.WriteLine("The Generated Bill is:");
                
                w.WriteLine(dr["first_name"] + " " + dr["last_name"] + " " + dr["advance"] + " " + dr["duration"] + " " + dr["room_type"] + " " + dr["room_no"]);

                dr.Close();
                c = new SqlCommand("SELECT advance,balance from checkedin where cust_id=@cust", con);
                c.Parameters.AddWithValue("@cust", Convert.ToInt32(frequent.Text));
                dr = c.ExecuteReader();
                dr.Read();
                w.WriteLine("Amount left to Pay:" + (Convert.ToInt32(dr["balance"])-Convert.ToInt32(dr["advance"])));
                dr.Close();
                w.Close();
                

            }
            catch (Exception err)
            {
                lbl.Text = "error:" + err.Message;
            }
            finally
            {
                con.Close();
                    
            }
        }
    }
}