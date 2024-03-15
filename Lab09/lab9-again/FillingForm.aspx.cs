using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Data;
using System.Data.SqlClient;

namespace lab9_again
{
    public partial class FillingForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string gender="";
        protected void btnDangKy_Click(object sender, EventArgs e)
        {
            lblThongBao.Text = "Đăng ký thành công";
            clsDatabase.openConnection();
            SqlCommand com = new SqlCommand("insert into khachHang values (@username,@password,@real_name,@birthday,@gender,@email,@income)",clsDatabase.con);
            SqlParameter p1 = new SqlParameter("@username", SqlDbType.NVarChar);
            p1.Value = txtTenDN.Text;
            SqlParameter p2 = new SqlParameter("@password", SqlDbType.VarChar);
            p2.Value = txtMK.Text;
            SqlParameter p3 = new SqlParameter("@real_name", SqlDbType.NVarChar);
            p3.Value = txtKH.Text;
            SqlParameter p4 = new SqlParameter("@birthday", SqlDbType.SmallDateTime);
            p4.Value = txtNgaySinh.Text;
            SqlParameter p5 = new SqlParameter("@gender", SqlDbType.VarChar);
            p5.Value = gender;
            SqlParameter p6 = new SqlParameter("@email", SqlDbType.NVarChar);
            p6.Value = txtEmail.Text;
            SqlParameter p7 = new SqlParameter("@income", SqlDbType.Money);
            p7.Value = txtThuNhap.Text;
            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            com.Parameters.Add(p3);
            com.Parameters.Add(p4);
            com.Parameters.Add(p5);
            com.Parameters.Add(p6);
            com.Parameters.Add(p7);
            try
            {
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error" + ex.Message);
            }
            finally
            {
                clsDatabase.closeConnection();
            }
        }

        protected void radNam_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Nam";
        }

        protected void radNu_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Nu";
        }

        protected void cv_gender_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = false;
            if (gender != "")
            {
                args.IsValid = true;
            }
        }
    }
}