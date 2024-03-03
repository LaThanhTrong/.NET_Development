using System.Data.SqlClient;

namespace ex1
{
    public partial class frmDVDCatalog : Form
    {
        int CodeNo;
        decimal price = 5;
        string language;
        int subTitle = 1;

        public frmDVDCatalog()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand com = new SqlCommand("SELECT Max(DVDCodeNo) FROM DVDLibrary", clsDatabase.conn);
                CodeNo = Convert.ToInt32(com.ExecuteScalar());
                clsDatabase.CloseConnection();
            }
            catch (Exception)
            {
                CodeNo = 0;
            }
            CodeNo++;
            ResetFields(true);
            dvdNum.Text = CodeNo.ToString();
        }

        void ResetFields(bool status)
        {
            dvdNum.Clear();
            dvdTitle.Clear();
            lang.SelectedIndex = -1;
            prc.Value = prc.Minimum;
            yes.Checked = true;
            no.Checked = false;
            save.Enabled = status;
            cancel.Enabled = status;
            add.Enabled = !status;
            dvdTitle.Focus();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                string strInsert = "Insert Into DVDLibrary Values (@DVDNo, @DVDTitle, @DVDLang, @SubTitle, @Price)";
                clsDatabase.OpenConnection();

                SqlCommand com = new SqlCommand(strInsert, clsDatabase.conn);

                SqlParameter p1 = new SqlParameter("@DVDNo", System.Data.SqlDbType.Int);
                p1.Value = CodeNo;
                SqlParameter p2 = new SqlParameter("@DVDTitle", System.Data.SqlDbType.NVarChar);
                p2.Value = dvdTitle.Text;
                SqlParameter p3 = new SqlParameter("@DVDLang", System.Data.SqlDbType.NVarChar);
                p3.Value = language;
                SqlParameter p4 = new SqlParameter("@SubTitle", System.Data.SqlDbType.Bit);
                p4.Value = subTitle;
                SqlParameter p5 = new SqlParameter("@Price", System.Data.SqlDbType.Money);
                p5.Value = price;

                com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                com.Parameters.Add(p3);
                com.Parameters.Add(p4);
                com.Parameters.Add(p5);
                com.ExecuteNonQuery();

                MessageBox.Show("DVD added successfully", "DVD Library", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clsDatabase.CloseConnection();
                ResetFields(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DVD Library", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            ResetFields(false);
        }

        private void prc_ValueChanged(object sender, EventArgs e)
        {
            price = prc.Value;
        }

        private void lang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lang.SelectedIndex == -1) return;
            language = lang.Text;
        }

        private void yes_CheckedChanged(object sender, EventArgs e)
        {
            subTitle = 1;
        }

        private void no_CheckedChanged(object sender, EventArgs e)
        {
            subTitle = 0;
        }
    }
}
