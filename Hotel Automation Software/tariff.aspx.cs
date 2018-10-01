using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Hotel_Automation_Software
{
    public partial class tariff : System.Web.UI.Page
    {
        SqlConnection sql;
        protected void Page_Load(object sender, EventArgs e)
        {
            sql = new SqlConnection(WebConfigurationManager.ConnectionStrings["Hotel"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT count(*) as occ FROM checkedin WHERE room_type='acd'", sql);
            SqlDataReader dr;
            try
            {
                lbl.Font.Size = 20;
                sql.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                lbl.Text = "AC Double:"+Convert.ToString(dr["occ"])+"&nbsp;&nbsp;&nbsp";
                dr.Close();
                cmd = new SqlCommand("SELECT count(*) as occ FROM checkedin WHERE room_type='nacd'",sql);
                dr = cmd.ExecuteReader();
                dr.Read();
                lbl.Text += "Non-AC Double:" + Convert.ToString(dr["occ"])+"&nbsp;&nbsp;&nbsp";
                dr.Close();
                cmd = new SqlCommand("SELECT count(*) as occ FROM checkedin WHERE room_type='acs'", sql);
                dr = cmd.ExecuteReader();
                dr.Read();
                lbl.Text += "AC Single:" + Convert.ToString(dr["occ"]) + "&nbsp;&nbsp;&nbsp";
                dr.Close();
                cmd = new SqlCommand("SELECT count(*) as occ FROM checkedin WHERE room_type='nacs'", sql);
                dr = cmd.ExecuteReader();
                dr.Read();
                lbl.Text += "Non-AC Single:" + Convert.ToString(dr["occ"]) + "&nbsp;&nbsp;&nbsp";
                dr.Close();
            }

            catch (Exception err)
            {
                lbl.Text = "Error:" + err.Message;
            }

            finally
            {
                sql.Close();
            }
        }
    }
}