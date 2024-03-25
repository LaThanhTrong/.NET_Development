using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab11
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            clsDatabase.OpenConnection();
            string sql = "SELECT * FROM Instructors WHERE MaCB = '" + txtUsername.Text + "' AND MatKhau = '" + txtPassword.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, clsDatabase.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                System.Diagnostics.Debug.WriteLine("Login success");
                Session["MaCB"] = dt.Rows[0]["MaCB"].ToString();
                Session["TenCB"] = dt.Rows[0]["TenCB"].ToString();
                clsDatabase.CloseConnection();
                Response.Redirect("Homepage.aspx");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Login failed");
                ClientScript.RegisterStartupScript(GetType(), "LoginFailedAlert", "alert('Username or password is incorrect!');", true);
            }
            clsDatabase.CloseConnection();
        }
    }
}