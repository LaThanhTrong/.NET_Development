namespace ex3
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
            dates = new Label();
            add = new Button();
            save = new Button();
            exit = new Button();
            txthd = new TextBox();
            txtht = new TextBox();
            textid = new TextBox();
            txttt = new TextBox();
            txtp = new ComboBox();
            date = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 52);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 0;
            label1.Text = "Số HĐ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 99);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 146);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 2;
            label3.Text = "Số CMND";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 198);
            label4.Name = "label4";
            label4.Size = new Size(66, 17);
            label4.TabIndex = 3;
            label4.Text = "Số tiền TT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(328, 147);
            label5.Name = "label5";
            label5.Size = new Size(65, 17);
            label5.TabIndex = 4;
            label5.Text = "Số phòng";
            // 
            // dates
            // 
            dates.AutoSize = true;
            dates.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dates.Location = new Point(328, 199);
            dates.Name = "dates";
            dates.Size = new Size(57, 17);
            dates.TabIndex = 5;
            dates.Text = "Ngày TT";
            // 
            // add
            // 
            add.Location = new Point(136, 251);
            add.Name = "add";
            add.Size = new Size(82, 35);
            add.TabIndex = 6;
            add.Text = "Thêm";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // save
            // 
            save.Enabled = false;
            save.Location = new Point(248, 251);
            save.Name = "save";
            save.Size = new Size(82, 35);
            save.TabIndex = 7;
            save.Text = "Lưu";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // exit
            // 
            exit.Location = new Point(360, 251);
            exit.Name = "exit";
            exit.Size = new Size(82, 35);
            exit.TabIndex = 8;
            exit.Text = "Thoát";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // txthd
            // 
            txthd.Enabled = false;
            txthd.Location = new Point(121, 52);
            txthd.Name = "txthd";
            txthd.ReadOnly = true;
            txthd.Size = new Size(182, 23);
            txthd.TabIndex = 9;
            // 
            // txtht
            // 
            txtht.Location = new Point(121, 99);
            txtht.Name = "txtht";
            txtht.Size = new Size(431, 23);
            txtht.TabIndex = 10;
            // 
            // textid
            // 
            textid.Location = new Point(121, 146);
            textid.Name = "textid";
            textid.Size = new Size(182, 23);
            textid.TabIndex = 11;
            // 
            // txttt
            // 
            txttt.Location = new Point(121, 198);
            txttt.Name = "txttt";
            txttt.Size = new Size(182, 23);
            txttt.TabIndex = 12;
            // 
            // txtp
            // 
            txtp.FormattingEnabled = true;
            txtp.Location = new Point(399, 147);
            txtp.Name = "txtp";
            txtp.Size = new Size(153, 23);
            txtp.TabIndex = 13;
            txtp.SelectedIndexChanged += txtp_SelectedIndexChanged;
            // 
            // date
            // 
            date.Format = DateTimePickerFormat.Short;
            date.Location = new Point(399, 199);
            date.Name = "date";
            date.Size = new Size(153, 23);
            date.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 314);
            Controls.Add(date);
            Controls.Add(txtp);
            Controls.Add(txttt);
            Controls.Add(textid);
            Controls.Add(txtht);
            Controls.Add(txthd);
            Controls.Add(exit);
            Controls.Add(save);
            Controls.Add(add);
            Controls.Add(dates);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label dates;
        private Button add;
        private Button save;
        private Button exit;
        private TextBox txthd;
        private TextBox txtht;
        private TextBox textid;
        private TextBox txttt;
        private ComboBox txtp;
        private DateTimePicker date;
    }
}
