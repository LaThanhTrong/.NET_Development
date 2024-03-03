namespace Lab08
{
    partial class Home
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
            lbname = new Label();
            cbbCourse = new ComboBox();
            dtStd = new DataGridView();
            label1 = new Label();
            tbGrade = new TextBox();
            btnUpdate = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtStd).BeginInit();
            SuspendLayout();
            // 
            // lbname
            // 
            lbname.AutoSize = true;
            lbname.Location = new Point(21, 18);
            lbname.Name = "lbname";
            lbname.Size = new Size(57, 15);
            lbname.TabIndex = 0;
            lbname.Text = "Welcome";
            // 
            // cbbCourse
            // 
            cbbCourse.FormattingEnabled = true;
            cbbCourse.Location = new Point(468, 18);
            cbbCourse.Name = "cbbCourse";
            cbbCourse.Size = new Size(121, 23);
            cbbCourse.TabIndex = 1;
            cbbCourse.SelectionChangeCommitted += cbbCourse_SelectionChangeCommitted;
            // 
            // dtStd
            // 
            dtStd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtStd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtStd.Location = new Point(21, 57);
            dtStd.Name = "dtStd";
            dtStd.Size = new Size(568, 370);
            dtStd.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(415, 22);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 3;
            label1.Text = "Courses";
            // 
            // tbGrade
            // 
            tbGrade.Location = new Point(201, 18);
            tbGrade.Name = "tbGrade";
            tbGrade.Size = new Size(137, 23);
            tbGrade.TabIndex = 4;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(340, 18);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(62, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 22);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "Grade";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 450);
            Controls.Add(label2);
            Controls.Add(btnUpdate);
            Controls.Add(tbGrade);
            Controls.Add(label1);
            Controls.Add(dtStd);
            Controls.Add(cbbCourse);
            Controls.Add(lbname);
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)dtStd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbname;
        private ComboBox cbbCourse;
        private DataGridView dtStd;
        private Label label1;
        private TextBox tbGrade;
        private Button btnUpdate;
        private Label label2;
    }
}