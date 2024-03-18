using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab10
{
    public partial class wfrStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
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
                    int dataValue = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "Phai"));
                    checkbox.Checked = (dataValue == 0);
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
                Label labelMaSV = (Label)row.FindControl("LabelMaSV");
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand("DELETE FROM SinhVien WHERE MaSV = @MaSV", clsDatabase.conn);
                cmd.Parameters.AddWithValue("@MaSV", labelMaSV.Text);
                cmd.ExecuteNonQuery();

            } catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                clsDatabase.CloseConnection();
            }
            LoadData();
        }

        private void LoadData()
        {
            clsDatabase.OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM SinhVien", clsDatabase.conn);
            DataTable t = new DataTable();
            t.Load(cmd.ExecuteReader());
            GridView.DataSource = t;
            GridView.DataBind();
            clsDatabase.CloseConnection();
        }

        protected void grdSV_OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView.PageIndex = e.NewPageIndex;
            LoadData();
        }

        protected void GridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView.EditIndex = e.NewEditIndex;
            LoadData();
        }

        protected void GridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                GridViewRow row = GridView.Rows[e.RowIndex];
                TextBox textBoxMaSV = (TextBox)row.FindControl("TextBoxMaSV");
                TextBox textBoxTenSV = (TextBox)row.FindControl("TextBoxTenSV");
                CheckBox checkbox = (CheckBox)row.FindControl("CheckBoxPhai");
                TextBox textBoxLop = (TextBox)row.FindControl("TextBoxLop");
                Label labelMaSV = (Label)row.FindControl("LabelMaSV");

                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand("UPDATE SinhVien SET TenSV = @TenSV, Phai = @Phai, Lop = @Lop WHERE MaSV = @MaSV", clsDatabase.conn);
                cmd.Parameters.AddWithValue("@MaSV", labelMaSV.Text);
                cmd.Parameters.AddWithValue("@TenSV", textBoxTenSV.Text);
                cmd.Parameters.AddWithValue("@Phai", checkbox.Checked ? 0 : 1);
                cmd.Parameters.AddWithValue("@Lop", textBoxLop.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                clsDatabase.CloseConnection();
            }
            GridView.EditIndex = -1;
            LoadData();
        }

        protected void GridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView.EditIndex = -1;
            LoadData();
        }

        protected void GridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = GridView.SelectedIndex;
            if (selectedIndex != -1)
            {
                GridViewRow row = GridView.Rows[selectedIndex];
                CheckBox checkbox = GridView.Rows[selectedIndex].FindControl("CheckBoxPhai") as CheckBox;
                Label MaSV = row.FindControl("LabelMaSV") as Label;
                Label TenSV = row.FindControl("LabelTenSV") as Label;
                Label Lop = row.FindControl("LabelLop") as Label;
                string maSV = MaSV.Text;
                string tenSV = TenSV.Text;
                string lop = Lop.Text;
                int phai = checkbox.Checked ? 0 : 1;
                Student student = new Student(maSV, tenSV, phai, lop);
                // Save student to session
                Session["student"] = student;
                // Handle Student Detail page, but there none
                Response.Redirect($"wfrStudent.aspx?userid={maSV}");
            }
        }
    }
}