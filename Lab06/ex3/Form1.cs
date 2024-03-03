using System.Data;
using System.Data.SqlClient;

namespace ex3
{
    public partial class Form1 : Form
    {
        private int maphong;
        private int sohd;
        private bool initializing = true;

        public Form1()
        {
            InitializeComponent();
            getPhong();
            maphong = (int)txtp.SelectedValue;
            ResetFields(false);
        }

        private void ResetFields(bool status)
        {
            txthd.Clear();
            txtht.Clear();
            textid.Clear();
            txttt.Clear();
            txtp.SelectedIndex = -1;
            date.Value = DateTime.Now;
            txtht.Focus();
            save.Enabled = status;
            add.Enabled = !status;
        }

        private void getPhong()
        {
            initializing = true;
            clsDatabase.OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Phong", clsDatabase.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            clsDatabase.CloseConnection();
            txtp.DataSource = dt;
            txtp.DisplayMember = "TenPhong";
            txtp.ValueMember = "MaPhong";
            initializing = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand com = new SqlCommand("SELECT Max(SoHD) FROM KhachHang", clsDatabase.conn);
                sohd = Convert.ToInt32(com.ExecuteScalar());
                clsDatabase.CloseConnection();
            }
            catch (Exception)
            {
                sohd = 0;
            }
            sohd++;
            ResetFields(true);
            txthd.Text = sohd.ToString();
        }

        private void txtp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (initializing)
            {
                initializing = false;
                return;
            }

            if (txtp.SelectedIndex != -1)
            {
                maphong = (int)txtp.SelectedValue;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                string strInsert = "Insert Into KhachHang Values (@SoHD, @TenKH, @SoCMND, @SoTien, @NgayTT, @Phong)";
                clsDatabase.OpenConnection();
                SqlCommand com = new SqlCommand(strInsert, clsDatabase.conn);

                SqlParameter p1 = new SqlParameter("@SoHD", System.Data.SqlDbType.Int);
                p1.Value = sohd;
                SqlParameter p2 = new SqlParameter("@TenKH", System.Data.SqlDbType.NVarChar);
                p2.Value = txtht.Text;
                SqlParameter p3 = new SqlParameter("@SoCMND", System.Data.SqlDbType.NVarChar);
                p3.Value = textid.Text;
                SqlParameter p4 = new SqlParameter("@SoTien", System.Data.SqlDbType.Money);
                p4.Value = txttt.Text;
                SqlParameter p5 = new SqlParameter("@NgayTT", System.Data.SqlDbType.Date);
                p5.Value = date.Value;
                SqlParameter p6 = new SqlParameter("@Phong", System.Data.SqlDbType.Int);
                p6.Value = maphong;

                com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                com.Parameters.Add(p3);
                com.Parameters.Add(p4);
                com.Parameters.Add(p5);
                com.Parameters.Add(p6);

                com.ExecuteNonQuery();

                MessageBox.Show("Hóa đơn mới đã được thêm", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clsDatabase.CloseConnection();
                ResetFields(false);
            } catch (Exception ex)
            {
                MessageBox.Show("Please fill all fields or invalid format! See error:\n" + ex.Message, "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
    }
}
