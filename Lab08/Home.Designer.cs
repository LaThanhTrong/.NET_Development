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
            label3 = new Label();
            cbbClass = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtStd).BeginInit();
            SuspendLayout();
            // 
            // lbname
            // 
            lbname.AutoSize = true;
            lbname.Location = new Point(77, 22);
            lbname.Name = "lbname";
            lbname.Size = new Size(41, 15);
            lbname.TabIndex = 0;
            lbname.Text = "admin";
            // 
            // cbbCourse
            // 
            cbbCourse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbbCourse.FormattingEnabled = true;
            cbbCourse.Location = new Point(594, 19);
            cbbCourse.Name = "cbbCourse";
            cbbCourse.Size = new Size(121, 23);
            cbbCourse.TabIndex = 1;
            cbbCourse.SelectionChangeCommitted += cbbCourse_SelectionChangeCommitted;
            // 
            // dtStd
            // 
            dtStd.AllowUserToAddRows = false;
            dtStd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtStd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtStd.Location = new Point(21, 57);
            dtStd.Name = "dtStd";
            dtStd.Size = new Size(694, 370);
            dtStd.TabIndex = 2;
            dtStd.CellContentClick += dtStd_CellContentClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(542, 23);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 3;
            label1.Text = "Courses";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 22);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 7;
            label3.Text = "Welcome,";
            // 
            // cbbClass
            // 
            cbbClass.Anchor = AnchorStyles.Top;
            cbbClass.FormattingEnabled = true;
            cbbClass.Location = new Point(412, 19);
            cbbClass.Name = "cbbClass";
            cbbClass.Size = new Size(121, 23);
            cbbClass.TabIndex = 8;
            cbbClass.SelectionChangeCommitted += cbbClass_SelectionChangeCommitted;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(364, 23);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 9;
            label2.Text = "Classes";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 450);
            Controls.Add(label2);
            Controls.Add(cbbClass);
            Controls.Add(label3);
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
        private Label label3;
        private ComboBox cbbClass;
        private Label label2;
    }
}