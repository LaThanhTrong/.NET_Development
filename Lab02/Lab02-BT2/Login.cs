namespace Lab02_B2
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
        private void btnOk_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (username == "Admin" && password == "Admin")
            {
                MessageBox.Show("Login successful!");
                EmployeeDetails employeeDetails = new EmployeeDetails();
                this.Hide();
                employeeDetails.Show();
                employeeDetails.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Login failed!");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
