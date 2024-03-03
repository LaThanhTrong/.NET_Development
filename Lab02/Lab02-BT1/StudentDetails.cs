namespace Lab02
{
    public partial class StudentDetails : Form
    {
        public StudentDetails()
        {
            InitializeComponent();
        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {

        }
        private void HandleValidation(object sender, EventArgs e)
        {
            int cnt = firstHob.CheckedItems.Count;
            string hobby = "";
            for (int index = 0; index <= cnt-1; index++)
            {
                hobby = hobby + firstHob.CheckedItems[index];
                if (index < cnt - 1)
                {
                    hobby = hobby + ",";
                }
            }
            MessageBox.Show(txtName.Text + " born in " + txtYear.Text + " from Class " + firstClass.Text + ", Division " + cboDiv.Text + " has following hobbies " + hobby);
        }
        private void HandleClear(object sender, EventArgs e)
        {
            firstClass.ClearSelected();
            cboDiv.Text = "";
            firstHob.ClearSelected();
            for(int index = 0; index <= firstHob.Items.Count - 1; index++)
            {
                if(firstHob.GetItemChecked(index))
                {
                    firstHob.SetItemChecked(index, false);
                }
            }
        }
    }
}
