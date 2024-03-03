namespace Lab02_BT3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Verify(object sender, EventArgs e)
        {
            int flag = 0;
            string services = "";
            for (int i = 0; i < clistBoxServices.Items.Count; i++)
            {
                CheckState checkState = clistBoxServices.GetItemCheckState(i);
                if (checkState == CheckState.Checked)
                {
                    services += clistBoxServices.Items[i].ToString() + ", ";
                    flag = 1;
                }
            }

            if (txtTicket.Text == "" || txtPName.Text == "" || txtPNumber.Text == "" || lsSource.Text == "" || lsDestination.Text == "" || cbbClass.Text == "" || date.Text == "" || flag == 0)
            {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (lsSource.Text == lsDestination.Text)
            {
                MessageBox.Show("Source and Destination cannot be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ticket Name: " + txtTicket.Text + "\nPassenger Name: " + txtPName.Text + "\nPassport Number: " + txtPNumber.Text + "\nSource: " + lsSource.Text + "\nDestination: " + lsDestination.Text + "\nFlight Date: " + date.Text + "\nClass: " + cbbClass.Text + "\nServices: " + services, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Clear(object sender, EventArgs e)
        {
            txtTicket.Text = "";
            txtPName.Text = "";
            txtPNumber.Text = "";
            cbbClass.Text = "";
            date.Text = "";
        }
    }
}
