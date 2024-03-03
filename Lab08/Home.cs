using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab08
{
    public partial class Home : Form
    {
        string userid;
        public Home()
        {
            InitializeComponent();
        }

        public void SetName(string name)
        {
            lbname.Text = name;
        }
        public void SetId(string iid)
        {
            userid = iid;
            getCourses();
        }

        public void getCourses()
        {
            try
            {
                clsDatabase.OpenConnection();
                string query = "SELECT c.MaMon, c.TenMon FROM Instructors i JOIN Teaching t ON t.MaCB = i.MaCB JOIN Courses c ON c.MaMon = t.MaMon WHERE i.MaCB=@userid GROUP BY c.MaMon, c.TenMon;";
                SqlCommand cmd = new SqlCommand(query, clsDatabase.conn);

                cmd.Parameters.AddWithValue("@userid", userid);

                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cbbCourse.DataSource = dt;
                cbbCourse.DisplayMember = "TenMon";
                cbbCourse.ValueMember = "MaMon";
                clsDatabase.CloseConnection();
                cbbCourse.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void getDiemThi()
        {
            try
            {
                clsDatabase.OpenConnection();
                string query = "SELECT g.DiemThi FROM Instructors i JOIN Grades g ON g.MaCB = i.MaCB JOIN Courses c ON c.MaMon = g.MaMon WHERE i.MaCB=@userid AND c.MaMon=@cid";
                SqlCommand cmd = new SqlCommand(query, clsDatabase.conn);

                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.Parameters.AddWithValue("@cid", cbbCourse.SelectedValue);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    tbGrade.Text = dr["DiemThi"].ToString();
                }
                else
                {
                    tbGrade.Text = "";
                }
                clsDatabase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cbbCourse_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getDiemThi();
            getStudents();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbbCourse.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a course!");
            }
            else
            {
                try
                {
                    clsDatabase.OpenConnection();
                    string query = "UPDATE Grades SET DiemThi=@grade WHERE MaCB=@userid AND MaMon=@cid";
                    SqlCommand cmd = new SqlCommand(query, clsDatabase.conn);

                    cmd.Parameters.AddWithValue("@userid", userid);
                    cmd.Parameters.AddWithValue("@cid", cbbCourse.SelectedValue);
                    cmd.Parameters.AddWithValue("@grade", tbGrade.Text);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Update successful!");
                        getDiemThi();
                    }
                    else
                    {
                        MessageBox.Show("Update failed!");
                    }
                    clsDatabase.CloseConnection();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void getStudents()
        {
            try
            {
                clsDatabase.OpenConnection();
                string query = "SELECT c.MaMon, t.MaLop, s.TenLop, s.MSSV, s.HoTen FROM Instructors i JOIN Teaching t ON i.MaCB = t.MaCB JOIN Students s ON s.MaLop = t.MaLop JOIN Courses c ON c.MaMon = t.MaMon WHERE i.MaCB=@userid AND c.MaMon=@cid;";
                SqlCommand cmd = new SqlCommand(query, clsDatabase.conn);

                cmd.Parameters.AddWithValue("@userid", userid);
                cmd.Parameters.AddWithValue("@cid", cbbCourse.SelectedValue);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                // Set the DataGridView data source
                dtStd.DataSource = dt;

                // Automatically adjust the column widths
                dtStd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Automatically adjust the row heights
                dtStd.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                clsDatabase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
