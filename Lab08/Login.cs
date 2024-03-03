using System.Data.SqlClient;
using System.Data;
using System;
using System.Windows.Forms;

namespace Lab08
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbId.Text == "" || tbPwd.Text == "") 
            {
                MessageBox.Show("Please fill all fields!");
            }
            else
            {
                try
                {
                    clsDatabase.OpenConnection();
                    string query = "SELECT * FROM Instructors WHERE MaCB = '" + tbId.Text + "' AND MatKhau = '" + tbPwd.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, clsDatabase.conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        string iid = dr["MaCB"].ToString();
                        string name = dr["TenCB"].ToString();
                        MessageBox.Show("Login successful!");
                        this.Hide();
                        Home home = new Home();
                        home.Closed += (s, args) => this.Close();
                        home.SetName(name);
                        home.SetId(iid);
                        home.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login failed!");
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
