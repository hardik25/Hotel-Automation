using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Web.Configuration;
using System.Data;

namespace Hotel_Automation_Software
{
    public partial class staffAdmin : System.Web.UI.Page
    {
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["Hotel"].ConnectionString;
            con = new SqlConnection(connectionString);

        }

        protected void allot_room(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT last_name, room_type, room_no FROM reservation WHERE first_name=@first_name";
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@first_name", fname.Text);
            int cust_id;
           
            SqlDataReader dr;
            int inserted = 0;
            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                Random rnd = new Random();
                cust_id=rnd.Next(1000);
                
                int price;
                string type = Convert.ToString(dr["room_type"]);
                int dur = Convert.ToInt32(duration.Text);
                int no = Convert.ToInt32(dr["room_no"]);
                // lbl.Text = type;
                if (type.Equals("nacd"))

                    price = 100 * no * dur;

                else if (type.Equals("acd"))


                    price = 200 * no * dur;
                else if (type.Equals("nacs"))
                    price = 300 * no * dur;
                else
                    price = 400 * no * dur;
                cmd.CommandText = "INSERT INTO checkedin(cust_id,first_name,last_name,advance,duration,room_type,room_no,balance) VALUES (@cust_id,@fir_name,@last_name,@advance,@duration,@room_type,@room_no,@balance)";
                cmd.Parameters.AddWithValue("@cust_id",cust_id);
                cmd.Parameters.AddWithValue("@fir_name",fname.Text);
                cmd.Parameters.AddWithValue("@last_name",dr["last_name"]);
                cmd.Parameters.AddWithValue("@advance",adv.Text);
                cmd.Parameters.AddWithValue("@duration",duration.Text);
                cmd.Parameters.AddWithValue("@room_type",dr["room_type"]);
                cmd.Parameters.AddWithValue("@room_no",dr["room_no"]);
                


                cmd.Parameters.AddWithValue("@balance", price);
                
                dr.Close();
                inserted = cmd.ExecuteNonQuery();
                string query = "confirmcheck.aspx?name=" + fname.Text + "&id=" + Convert.ToString(cust_id);
                Response.Redirect(query);
                
            }
            catch (Exception err)
            {
                lbl.Text = "Error could not find the record";
                      lbl.Text+=err.Message;
            }
            finally
            {
                con.Close();
                
            }
            
            
        }
    }
}