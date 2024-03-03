using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_B2
{
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = textAddress.Text;
            string dept = cbbDept.Text;
            string edu = scrollEdu.Text;
            string dateOfJoining = date.Text;
            if(name == "" || address == "" || dept == "" || edu == "" || dateOfJoining == "")
            {
                MessageBox.Show("Please fill in all the fields!");
            }
            else
            {
                MessageBox.Show("Name: " + name + "\nAddress: " + address + "\nDepartment: " + dept + "\nEducation: " + edu + "\nDate of Joining: " + dateOfJoining);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            textAddress.Text = "";
            cbbDept.Text = "";
            scrollEdu.Text = "";
            date.Text = "";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
