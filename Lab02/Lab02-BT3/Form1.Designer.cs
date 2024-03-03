namespace Lab02_BT3
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
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtTicket = new TextBox();
            txtPName = new TextBox();
            txtPNumber = new TextBox();
            lsSource = new ListBox();
            lsDestination = new ListBox();
            cbbClass = new ComboBox();
            clistBoxServices = new CheckedListBox();
            bnVerify = new Button();
            btnClear = new Button();
            date = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 24);
            label1.Name = "label1";
            label1.Size = new Size(263, 30);
            label1.TabIndex = 0;
            label1.Text = "Flight Reservation Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 82);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Ticket Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 128);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 2;
            label3.Text = "Passenger Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 176);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 3;
            label4.Text = "Passport Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 224);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 4;
            label5.Text = "Source";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 291);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 5;
            label6.Text = "Destination";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 367);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 6;
            label7.Text = "Flight Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 407);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 7;
            label8.Text = "Class";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 455);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 8;
            label9.Text = "Servives";
            // 
            // txtTicket
            // 
            txtTicket.Location = new Point(148, 79);
            txtTicket.Name = "txtTicket";
            txtTicket.Size = new Size(117, 23);
            txtTicket.TabIndex = 9;
            // 
            // txtPName
            // 
            txtPName.Location = new Point(148, 125);
            txtPName.Name = "txtPName";
            txtPName.Size = new Size(163, 23);
            txtPName.TabIndex = 10;
            // 
            // txtPNumber
            // 
            txtPNumber.Location = new Point(148, 173);
            txtPNumber.Name = "txtPNumber";
            txtPNumber.Size = new Size(117, 23);
            txtPNumber.TabIndex = 11;
            // 
            // lsSource
            // 
            lsSource.FormattingEnabled = true;
            lsSource.ItemHeight = 15;
            lsSource.Items.AddRange(new object[] { "Amsterdam", "Hanoi", "Singapore" });
            lsSource.Location = new Point(148, 224);
            lsSource.Name = "lsSource";
            lsSource.Size = new Size(120, 49);
            lsSource.TabIndex = 13;
            // 
            // lsDestination
            // 
            lsDestination.FormattingEnabled = true;
            lsDestination.ItemHeight = 15;
            lsDestination.Items.AddRange(new object[] { "Amsterdam", "Hanoi", "Singapore" });
            lsDestination.Location = new Point(148, 291);
            lsDestination.Name = "lsDestination";
            lsDestination.Size = new Size(120, 49);
            lsDestination.TabIndex = 14;
            // 
            // cbbClass
            // 
            cbbClass.FormattingEnabled = true;
            cbbClass.Items.AddRange(new object[] { "Economy", "Business", "First" });
            cbbClass.Location = new Point(148, 407);
            cbbClass.Name = "cbbClass";
            cbbClass.Size = new Size(121, 23);
            cbbClass.TabIndex = 16;
            // 
            // clistBoxServices
            // 
            clistBoxServices.FormattingEnabled = true;
            clistBoxServices.Items.AddRange(new object[] { "Child Care", "Nurse" });
            clistBoxServices.Location = new Point(148, 455);
            clistBoxServices.Name = "clistBoxServices";
            clistBoxServices.Size = new Size(120, 40);
            clistBoxServices.TabIndex = 17;
            // 
            // bnVerify
            // 
            bnVerify.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bnVerify.Location = new Point(68, 512);
            bnVerify.Name = "bnVerify";
            bnVerify.Size = new Size(79, 33);
            bnVerify.TabIndex = 18;
            bnVerify.Text = "Verify";
            bnVerify.UseVisualStyleBackColor = true;
            bnVerify.Click += Verify;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(173, 512);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(81, 33);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += Clear;
            // 
            // date
            // 
            date.Format = DateTimePickerFormat.Short;
            date.Location = new Point(148, 361);
            date.Name = "date";
            date.Size = new Size(120, 23);
            date.TabIndex = 20;
            date.Value = new DateTime(2024, 1, 5, 22, 21, 47, 0);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(348, 573);
            Controls.Add(date);
            Controls.Add(btnClear);
            Controls.Add(bnVerify);
            Controls.Add(clistBoxServices);
            Controls.Add(cbbClass);
            Controls.Add(lsDestination);
            Controls.Add(lsSource);
            Controls.Add(txtPNumber);
            Controls.Add(txtPName);
            Controls.Add(txtTicket);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Flight Reservation Details";
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
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtTicket;
        private TextBox txtPName;
        private TextBox txtPNumber;
        private ListBox lsSource;
        private ListBox lsDestination;
        private ComboBox cbbClass;
        private CheckedListBox clistBoxServices;
        private Button bnVerify;
        private Button btnClear;
        private DateTimePicker date;
    }
}
