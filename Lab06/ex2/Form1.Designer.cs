namespace ex2
{
    partial class Form1
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
            txtMscb = new TextBox();
            txtHoten = new TextBox();
            txtTeachHour = new TextBox();
            txtPrc = new TextBox();
            cbCv = new ComboBox();
            add = new Button();
            save = new Button();
            close = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(85, 40);
            label1.Name = "label1";
            label1.Size = new Size(217, 30);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN CÁN BỘ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 150);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 1;
            label2.Text = "Họ tên CB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 198);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 2;
            label3.Text = "Chức vụ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 104);
            label4.Name = "label4";
            label4.Size = new Size(42, 17);
            label4.TabIndex = 3;
            label4.Text = "MSCB";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 248);
            label5.Name = "label5";
            label5.Size = new Size(83, 17);
            label5.TabIndex = 4;
            label5.Text = "Số giờ giảng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(27, 304);
            label6.Name = "label6";
            label6.Size = new Size(54, 17);
            label6.TabIndex = 5;
            label6.Text = "Đơn giá";
            // 
            // txtMscb
            // 
            txtMscb.Enabled = false;
            txtMscb.Location = new Point(121, 104);
            txtMscb.Name = "txtMscb";
            txtMscb.ReadOnly = true;
            txtMscb.Size = new Size(100, 23);
            txtMscb.TabIndex = 6;
            // 
            // txtHoten
            // 
            txtHoten.Location = new Point(121, 150);
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(210, 23);
            txtHoten.TabIndex = 7;
            // 
            // txtTeachHour
            // 
            txtTeachHour.Location = new Point(121, 248);
            txtTeachHour.Name = "txtTeachHour";
            txtTeachHour.Size = new Size(121, 23);
            txtTeachHour.TabIndex = 8;
            // 
            // txtPrc
            // 
            txtPrc.Location = new Point(121, 304);
            txtPrc.Name = "txtPrc";
            txtPrc.Size = new Size(100, 23);
            txtPrc.TabIndex = 9;
            // 
            // cbCv
            // 
            cbCv.FormattingEnabled = true;
            cbCv.Location = new Point(121, 198);
            cbCv.Name = "cbCv";
            cbCv.Size = new Size(121, 23);
            cbCv.TabIndex = 10;
            cbCv.SelectedIndexChanged += cbCv_SelectedIndexChanged;
            // 
            // add
            // 
            add.Location = new Point(27, 356);
            add.Name = "add";
            add.Size = new Size(88, 33);
            add.TabIndex = 11;
            add.Text = "Thêm";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // save
            // 
            save.Enabled = false;
            save.Location = new Point(133, 356);
            save.Name = "save";
            save.Size = new Size(88, 33);
            save.TabIndex = 12;
            save.Text = "Lưu";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // close
            // 
            close.Location = new Point(243, 356);
            close.Name = "close";
            close.Size = new Size(88, 33);
            close.TabIndex = 13;
            close.Text = "Đóng";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 409);
            Controls.Add(close);
            Controls.Add(save);
            Controls.Add(add);
            Controls.Add(cbCv);
            Controls.Add(txtPrc);
            Controls.Add(txtTeachHour);
            Controls.Add(txtHoten);
            Controls.Add(txtMscb);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Can bo";
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
        private TextBox txtMscb;
        private TextBox txtHoten;
        private TextBox txtTeachHour;
        private TextBox txtPrc;
        private ComboBox cbCv;
        private Button add;
        private Button save;
        private Button close;
    }
}
