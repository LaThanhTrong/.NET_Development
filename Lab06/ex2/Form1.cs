using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ex2
{
    public partial class Form1 : Form
    {
        private int mscv;
        private int mscb;
        private bool initializing = true;

        public Form1()
        {
            InitializeComponent();
            getChucVu();
            mscv = (int)cbCv.SelectedValue;
            ResetFields(false);
        }

        private void ResetFields(bool status)
        {
            txtMscb.Clear();
            txtHoten.Clear();
            txtTeachHour.Clear();
            txtPrc.Clear();
            cbCv.SelectedIndex = -1;
            save.Enabled = status;
            add.Enabled = !status;
            txtHoten.Focus();
        }

        private void getChucVu()
        {
            initializing = true;
            clsDatabase.OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ChucVu", clsDatabase.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            clsDatabase.CloseConnection();
            cbCv.DataSource = dt;
            cbCv.DisplayMember = "TenCV";
            cbCv.ValueMember = "MaCV";
            initializing = false;
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand com = new SqlCommand("SELECT Max(MaCB) FROM CanBo", clsDatabase.conn);
                mscb = Convert.ToInt32(com.ExecuteScalar());
                clsDatabase.CloseConnection();
            } catch (Exception)
            {
                mscb = 0;
            }
            mscb++;
            ResetFields(true);
            txtMscb.Text = mscb.ToString();
        }

        private void cbCv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (initializing)
            {
                initializing = false;
                return;
            }

            if (cbCv.SelectedIndex != -1)
            {
                mscv = (int)cbCv.SelectedValue;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                string strInsert = "Insert Into CanBo Values (@MaCB, @TenCB, @ChucVuCB, @SoGioGiang, @DonGia)";
                clsDatabase.OpenConnection();
                SqlCommand com = new SqlCommand(strInsert, clsDatabase.conn);
                SqlParameter p1 = new SqlParameter("@MaCB", System.Data.SqlDbType.Int);
                p1.Value = mscb;
                SqlParameter p2 = new SqlParameter("@TenCB", System.Data.SqlDbType.NVarChar);
                p2.Value = txtHoten.Text;
                SqlParameter p3 = new SqlParameter("@ChucVuCB", System.Data.SqlDbType.Int);
                p3.Value = mscv;
                SqlParameter p4 = new SqlParameter("@SoGioGiang", System.Data.SqlDbType.Int);
                p4.Value = txtTeachHour.Text;
                SqlParameter p5 = new SqlParameter("@DonGia", System.Data.SqlDbType.Money);
                p5.Value = txtPrc.Text;

                com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                com.Parameters.Add(p3);
                com.Parameters.Add(p4);
                com.Parameters.Add(p5);

                com.ExecuteNonQuery();

                MessageBox.Show("Cán bộ mới đã được thêm", "QLCB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clsDatabase.CloseConnection();
                ResetFields(false);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill all fields or invalid format! See error:\n"+ex.Message, "QLCB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
