namespace Lab02
{
    partial class StudentDetails
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            txtYear = new TextBox();
            firstClass = new ListBox();
            cboDiv = new ComboBox();
            firstHob = new CheckedListBox();
            btnConfirm = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 24);
            label1.Name = "label1";
            label1.Size = new Size(303, 37);
            label1.TabIndex = 0;
            label1.Text = "Student's Class Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 107);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 1;
            label2.Text = "Student Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 167);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 2;
            label3.Text = "Year of birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 223);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 3;
            label4.Text = "Standard/Class";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 291);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 4;
            label5.Text = "Division";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 336);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 5;
            label6.Text = "Hobbies";
            // 
            // txtName
            // 
            txtName.Location = new Point(148, 104);
            txtName.Name = "txtName";
            txtName.Size = new Size(324, 23);
            txtName.TabIndex = 6;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(148, 164);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(187, 23);
            txtYear.TabIndex = 7;
            // 
            // firstClass
            // 
            firstClass.FormattingEnabled = true;
            firstClass.ItemHeight = 15;
            firstClass.Items.AddRange(new object[] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" });
            firstClass.Location = new Point(148, 223);
            firstClass.Name = "firstClass";
            firstClass.Size = new Size(120, 49);
            firstClass.TabIndex = 10;
            // 
            // cboDiv
            // 
            cboDiv.FormattingEnabled = true;
            cboDiv.Items.AddRange(new object[] { "A", "B", "C", "D" });
            cboDiv.Location = new Point(148, 288);
            cboDiv.Name = "cboDiv";
            cboDiv.Size = new Size(121, 23);
            cboDiv.TabIndex = 11;
            // 
            // firstHob
            // 
            firstHob.FormattingEnabled = true;
            firstHob.Items.AddRange(new object[] { "Singing", "Dancing", "Swimming", "Reading", "Travelling" });
            firstHob.Location = new Point(148, 336);
            firstHob.Name = "firstHob";
            firstHob.Size = new Size(120, 94);
            firstHob.TabIndex = 12;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(55, 475);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(168, 32);
            btnConfirm.TabIndex = 13;
            btnConfirm.Text = "Confirm Student Details";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += HandleValidation;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(261, 475);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(74, 32);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += HandleClear;
            // 
            // StudentDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(511, 598);
            Controls.Add(btnClear);
            Controls.Add(btnConfirm);
            Controls.Add(firstHob);
            Controls.Add(cboDiv);
            Controls.Add(firstClass);
            Controls.Add(txtYear);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentDetails";
            Text = "Student Details";
            Load += StudentDetails_Load;
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
        private TextBox txtYear;
        private ListBox firstClass;
        private ComboBox cboDiv;
        private CheckedListBox firstHob;
        private Button btnConfirm;
        private Button btnClear;
    }
}
