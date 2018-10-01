using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Hotel_Automation_Software
{
    public partial class clientReserve : System.Web.UI.Page
    {
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["Hotel"].ConnectionString;
            con = new SqlConnection(connectionString);

        }

        protected void submit_reservation(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText="INSERT INTO reservation(first_name,last_name,date_r,room_type,room_no) VALUES (@first_name,@last_name,@date_r,@room_type,@room_no)";
            cmd.Connection = con;
            
            cmd.Parameters.AddWithValue("@first_name",first_name.Text);
            cmd.Parameters.AddWithValue("@last_name", last_name.Text);
            cmd.Parameters.AddWithValue("@date_r", cal.SelectedDate);

            cmd.Parameters.AddWithValue("@room_type", CheckBoxList1.SelectedValue);
            cmd.Parameters.AddWithValue( "@room_no",no_of_rooms.Text);

            int inserted = 0;
            try
            {
                con.Open();
                inserted = cmd.ExecuteNonQuery();
                
            }
            catch (Exception err)
            {
                lblerr.Text = "Error setting record";
                lblerr.Text += err.Message;
            }
            finally
            {
                con.Close();
            }
        }
    }
}