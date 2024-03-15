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
            getClasses();
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

        public void getClasses()
        {
            try
            {
                clsDatabase.OpenConnection();
                string query = "SELECT cls.MaLop, cls.TenLop FROM Instructors i JOIN Teaching t ON t.MaCB = i.MaCB JOIN Courses c ON c.MaMon = t.MaMon JOIN CLASS cls ON cls.MaLop = t.MaLop WHERE i.MaCB=@userid GROUP BY cls.MaLop, cls.TenLop;";
                SqlCommand cmd = new SqlCommand(query, clsDatabase.conn);

                cmd.Parameters.AddWithValue("@userid", userid);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                cbbClass.DataSource = dt;
                cbbClass.DisplayMember = "TenLop";
                cbbClass.ValueMember = "MaLop";
                clsDatabase.CloseConnection();
                cbbClass.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cbbCourse_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getStudents();
        }

        public void getStudents()
        {
            dtStd.Columns.Clear();
            try
            {
                if(cbbClass.SelectedIndex != -1 && cbbCourse.SelectedIndex != -1)
                {
                    clsDatabase.OpenConnection();
                    string query = "SELECT st.MSSV as MSSV, st.HoTen as Name, g.DiemThi as Grade FROM Students st JOIN Grades g ON g.MSSV = st.MSSV WHERE st.MaLop = @clsid AND g.MaMon = @crsid;";
                    SqlCommand cmd = new SqlCommand(query, clsDatabase.conn);

                    cmd.Parameters.AddWithValue("@clsid", cbbClass.SelectedValue);
                    cmd.Parameters.AddWithValue("@crsid", cbbCourse.SelectedValue);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dt.Columns["MSSV"].ReadOnly = true;
                    dt.Columns["Name"].ReadOnly = true;
                    dtStd.DataSource = dt;
                    clsDatabase.CloseConnection();
                    DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                    btnColumn.Name = "action";
                    btnColumn.HeaderText = "Action";
                    btnColumn.Text = "Edit";
                    btnColumn.UseColumnTextForButtonValue = true;
                    dtStd.Columns.Add(btnColumn);
                    dtStd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dtStd.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cbbClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getStudents();
        }

        private void dtStd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtStd != null && dtStd.Columns.Contains("action") && e.ColumnIndex == dtStd.Columns["action"].Index && e.RowIndex >= 0)
            {
                int selectedRowIndex = e.RowIndex;
                float grade = float.Parse(dtStd.Rows[selectedRowIndex].Cells["Grade"].Value.ToString());
                string mssv = dtStd.Rows[selectedRowIndex].Cells["MSSV"].Value.ToString();
                if(cbbCourse.SelectedIndex != -1)
                {
                    try
                    {
                        clsDatabase.OpenConnection();
                        string query = "UPDATE Grades SET DiemThi = @grade WHERE MSSV = @mssv AND MaMon = @crsid";
                        SqlCommand cmd = new SqlCommand(query, clsDatabase.conn);
                        cmd.Parameters.AddWithValue("@grade", grade);
                        cmd.Parameters.AddWithValue("@mssv", mssv);
                        cmd.Parameters.AddWithValue("@crsid", cbbCourse.SelectedValue);
                        cmd.ExecuteNonQuery();
                        clsDatabase.CloseConnection();
                        MessageBox.Show("Update successful!");
                        getStudents();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a course!");
                }
            }
        }
    }
}
