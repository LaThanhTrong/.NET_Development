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
    public partial class Homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    if (Session["MaCB"] != null)
                    {
                        string maCB = Session["MaCB"].ToString();
                        string hoTen = Session["TenCB"].ToString();
                        lblUsername.Text = hoTen;
                        LoadCourse();
                        LoadClass();
                        LoadStudent();

                    }
                    else
                    {
                        Response.Redirect("Login.aspx");
                    }
                }
                catch (Exception)
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Login.aspx");
        }

        protected void LoadCourse()
        {
            try
            {
                clsDatabase.OpenConnection();
                string sql = $"SELECT c.MaMon, c.TenMon FROM Instructors i JOIN Teaching t ON t.MaCB = i.MaCB JOIN Courses c ON c.MaMon = t.MaMon WHERE i.MaCB='{Session["MaCB"]}' GROUP BY c.MaMon, c.TenMon;";
                SqlDataAdapter da = new SqlDataAdapter(sql, clsDatabase.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbbCourse.DataSource = dt;
                cbbCourse.DataTextField = "TenMon";
                cbbCourse.DataValueField = "MaMon";
                cbbCourse.DataBind();

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            clsDatabase.CloseConnection();
        }

        protected void LoadClass()
        {
            try
            {
                clsDatabase.OpenConnection();
                string sql = $"SELECT cls.MaLop, cls.TenLop FROM Instructors i JOIN Teaching t ON t.MaCB = i.MaCB JOIN Courses c ON c.MaMon = t.MaMon JOIN CLASS cls ON cls.MaLop = t.MaLop WHERE i.MaCB='{Session["MaCB"]}' GROUP BY cls.MaLop, cls.TenLop;";
                SqlDataAdapter da = new SqlDataAdapter(sql, clsDatabase.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbbClass.DataSource = dt;
                cbbClass.DataTextField = "TenLop";
                cbbClass.DataValueField = "MaLop";
                cbbClass.DataBind();

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            clsDatabase.CloseConnection();
        }

        protected void LoadStudent()
        {
            GridView.DataSource = null;
            GridView.DataBind();
            System.Diagnostics.Debug.WriteLine("Load student");
            try
            {
                if (cbbClass.SelectedIndex == -1 || cbbCourse.SelectedIndex == -1)
                {
                    return;
                }
                clsDatabase.OpenConnection();
                string sql = $"SELECT st.MSSV as MSSV, st.HoTen as Name, g.DiemThi as Grade FROM Students st JOIN Grades g ON g.MSSV = st.MSSV WHERE st.MaLop = '{cbbClass.SelectedValue}' AND g.MaMon = '{cbbCourse.SelectedValue}';";
                SqlCommand cmd = new SqlCommand(sql, clsDatabase.conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView.DataSource = dt;
                GridView.DataBind();

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        protected void cbbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudent();
        }

        protected void cbbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudent();
        }

        protected void GridView_RowCreated(object sender, GridViewRowEventArgs e)
        {

        }
        protected void GridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.RowIndex % 2 == 0)
                {
                    e.Row.BackColor = System.Drawing.Color.FromArgb(224, 244, 255);
                }
            }
        }

        protected void GridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void grdSV_OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView.PageIndex = e.NewPageIndex;
            LoadStudent();
        }

        protected void GridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView.EditIndex = -1;
            LoadStudent();
        }

        protected void GridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView.EditIndex = e.NewEditIndex;
            LoadStudent();
        }

        protected void GridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                GridViewRow row = GridView.Rows[e.RowIndex];
                clsDatabase.OpenConnection();
                Label mssv = row.FindControl("LabelMSSV") as Label;
                TextBox grade = row.FindControl("TextBoxGrade") as TextBox;
                string sql = $"UPDATE Grades SET DiemThi = {grade.Text} WHERE MSSV = '{mssv.Text}' AND MaMon = '{cbbCourse.SelectedValue}';";
                SqlCommand cmd = new SqlCommand(sql, clsDatabase.conn);
                cmd.ExecuteNonQuery();
                ClientScript.RegisterStartupScript(GetType(), "LoginFailedAlert", "alert('Update grade success!');", true);
                GridView.EditIndex = -1;
                LoadStudent();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            clsDatabase.CloseConnection();
        }

        protected void GridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = GridView.SelectedIndex;
            if (selectedIndex != -1)
            {
                GridViewRow row = GridView.Rows[selectedIndex];
                Label mssv = row.FindControl("LabelMSSV") as Label;
                Session["MSSV"] = mssv.Text;
                Response.Redirect($"Homepage.aspx?userid={mssv.Text}");
            }
        }
    }
}