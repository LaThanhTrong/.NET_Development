namespace Lab02_B2
{
    partial class EmployeeDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            btnExit = new Button();
            cbbDept = new ComboBox();
            scrollEdu = new DomainUpDown();
            textAddress = new RichTextBox();
            date = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 30);
            label1.Name = "label1";
            label1.Size = new Size(180, 30);
            label1.TabIndex = 0;
            label1.Text = "Employee Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 95);
            label2.Name = "label2";
            label2.Size = new Size(104, 17);
            label2.TabIndex = 1;
            label2.Text = "Employee Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 132);
            label3.Name = "label3";
            label3.Size = new Size(117, 17);
            label3.TabIndex = 2;
            label3.Text = "Employee Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 249);
            label4.Name = "label4";
            label4.Size = new Size(96, 17);
            label4.TabIndex = 3;
            label4.Text = "Date of Joining";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 286);
            label5.Name = "label5";
            label5.Size = new Size(65, 17);
            label5.TabIndex = 4;
            label5.Text = "Education";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 325);
            label6.Name = "label6";
            label6.Size = new Size(77, 17);
            label6.TabIndex = 5;
            label6.Text = "Department";
            // 
            // txtName
            // 
            txtName.Location = new Point(170, 94);
            txtName.Name = "txtName";
            txtName.Size = new Size(189, 23);
            txtName.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(36, 384);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(87, 30);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(165, 384);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 30);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(284, 384);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 30);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // cbbDept
            // 
            cbbDept.FormattingEnabled = true;
            cbbDept.Items.AddRange(new object[] { "Human Resource", "Marketing", "R&D" });
            cbbDept.Location = new Point(165, 325);
            cbbDept.Name = "cbbDept";
            cbbDept.Size = new Size(121, 23);
            cbbDept.TabIndex = 15;
            // 
            // scrollEdu
            // 
            scrollEdu.Items.Add("UnderGraduate");
            scrollEdu.Items.Add("PostGraduate");
            scrollEdu.Location = new Point(166, 286);
            scrollEdu.Name = "scrollEdu";
            scrollEdu.Size = new Size(120, 23);
            scrollEdu.TabIndex = 16;
            // 
            // textAddress
            // 
            textAddress.Location = new Point(170, 131);
            textAddress.Name = "textAddress";
            textAddress.Size = new Size(189, 96);
            textAddress.TabIndex = 17;
            textAddress.Text = "";
            // 
            // date
            // 
            date.Format = DateTimePickerFormat.Short;
            date.Location = new Point(165, 249);
            date.Name = "date";
            date.Size = new Size(121, 23);
            date.TabIndex = 18;
            date.Value = new DateTime(2024, 1, 5, 0, 0, 0, 0);
            // 
            // EmployeeDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(412, 450);
            Controls.Add(date);
            Controls.Add(textAddress);
            Controls.Add(scrollEdu);
            Controls.Add(cbbDept);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmployeeDetails";
            Text = "s";
            Load += EmployeeDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtName;
        private Button btnSave;
        private Button btnClear;
        private Button btnExit;
        private ComboBox cbbDept;
        private DomainUpDown scrollEdu;
        private RichTextBox textAddress;
        private DateTimePicker date;
    }
}