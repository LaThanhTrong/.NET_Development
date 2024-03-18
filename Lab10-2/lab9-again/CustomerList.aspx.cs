using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace lab9_again
{
    public partial class CustomerList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getKhachHang();
            }
        }

        protected void GridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.RowIndex % 2 == 0)
                {
                    e.Row.BackColor = System.Drawing.Color.FromArgb(224, 244, 255);
                }
                CheckBox checkbox = e.Row.FindControl("CheckBoxPhai") as CheckBox;
                if (checkbox != null)
                {
                    string genderValue = DataBinder.Eval(e.Row.DataItem, "gender").ToString();
                    if (genderValue == "Nam")
                    {
                        checkbox.Checked = true; 
                    }
                    else
                    {
                        checkbox.Checked = false;
                    }
                }
            }
        }

        protected void GridView_RowCreated(object sender, GridViewRowEventArgs e)
        {

        }

        protected void GridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                GridViewRow row = GridView.Rows[e.RowIndex];
                Label txtUsername = row.FindControl("LabelUsername") as Label;
                clsDatabase.openConnection();
                SqlCommand cmd = new SqlCommand("delete from khachHang where username = @username", clsDatabase.con);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.ExecuteNonQuery();

            } catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                clsDatabase.closeConnection();
            }
            getKhachHang();
        }

        private void getKhachHang()
        {
            clsDatabase.openConnection();
            SqlCommand cmd = new SqlCommand("select username as Username, real_name as Name, birthday, gender, email from khachHang;", clsDatabase.con);
            DataTable t = new DataTable();
            t.Load(cmd.ExecuteReader());
            GridView.DataSource = t;
            GridView.DataBind();
            clsDatabase.closeConnection();
        }

        protected void grdSV_OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView.PageIndex = e.NewPageIndex;
            getKhachHang();
        }

        protected void GridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView.EditIndex = e.NewEditIndex;
            getKhachHang();
        }

        protected void GridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                GridViewRow row = GridView.Rows[e.RowIndex];
                TextBox txtName = row.FindControl("TextBoxName") as TextBox;
                HtmlInputControl txtBirthday = row.FindControl("TextBoxDOB") as HtmlInputControl;
                string birthday = txtBirthday.Value;
                CheckBox checkbox = (CheckBox)row.FindControl("CheckBoxPhai");
                TextBox txtEmail = row.FindControl("TextBoxEmail") as TextBox;
                Label txtUsername = row.FindControl("LabelUsername") as Label;

                clsDatabase.openConnection();
                SqlCommand cmd = new SqlCommand("update khachHang set real_name = @name, birthday = @dob, gender = @gender, email = @email where username = @username", clsDatabase.con);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@dob", birthday);
                cmd.Parameters.AddWithValue("@gender", checkbox.Checked ? "Nam" : "Nu");
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);

            }
            finally
            {
                clsDatabase.closeConnection();
            }
            GridView.EditIndex = -1;
            getKhachHang();
        }

        protected void GridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView.EditIndex = -1;
            getKhachHang();
        }

        protected void GridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = GridView.SelectedIndex;
            if (selectedIndex != -1)
            {
                GridViewRow row = GridView.Rows[selectedIndex];
                CheckBox checkbox = GridView.Rows[selectedIndex].FindControl("CheckBoxPhai") as CheckBox;
                Label Username = row.FindControl("LabelUsername") as Label;
                Label Name = row.FindControl("LabelName") as Label;
                Label Birthday = row.FindControl("LabelBirthday") as Label;
                Label Email = row.FindControl("LabelEmail") as Label;
                string username = Username.Text;
                string name = Name.Text;
                string email = Email.Text;
                int phai = checkbox.Checked ? 0 : 1;
                //Student student = new Student(maSV, tenSV, phai, lop);
                // Save student to session
                //Session["student"] = student;
                // Handle Student Detail page, but there none
                Response.Redirect($"CustomerList.aspx?userid={username}");
            }
        }

    }
}