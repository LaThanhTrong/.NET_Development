namespace Lab03
{
    public partial class frmBookSale : Form
    {
        private clsBookSale mBookSale;
        public frmBookSale()
        {
            InitializeComponent();
        }
        private void mnuCal_Click(object sender, EventArgs e)
        {
            try
            {
                mBookSale = new clsStudentBookSale(txtTitle.Text, Convert.ToInt32(txtQuantity.Text), Convert.ToDecimal(txtPrice.Text), cbDiscount.Checked, cbStudent.Checked);

                txtExtendedPrice.Text = mBookSale.ExtendedPrice().ToString("C");
                txtPrice.Text = mBookSale.Price.ToString("C");
                txtDiscount.Text = mBookSale.DiscountAmount().ToString("C");
                txtDue.Text = mBookSale.NetDue().ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Quantity or Price. "+ex.Message,"Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void mnuNew_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            txtExtendedPrice.Text = "";
            txtTitle.Focus();
        }
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void mnuSum_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sales Total: " + clsBookSale.SalesTotal.ToString("C") + "\nSales Count: " + clsBookSale.SalesCount.ToString(), "Summary Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
