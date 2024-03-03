namespace Lab03
{
    partial class frmBookSale
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            calculateToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            summaryToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            cbStudent = new CheckBox();
            cbDiscount = new CheckBox();
            txtDue = new TextBox();
            txtDiscount = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtExtendedPrice = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtTitle = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(439, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, calculateToolStripMenuItem, exitToolStripMenuItem, summaryToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(125, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += mnuNew_Click;
            // 
            // calculateToolStripMenuItem
            // 
            calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            calculateToolStripMenuItem.Size = new Size(125, 22);
            calculateToolStripMenuItem.Text = "Calculate";
            calculateToolStripMenuItem.Click += mnuCal_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(125, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += mnuExit_Click;
            // 
            // summaryToolStripMenuItem
            // 
            summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            summaryToolStripMenuItem.Size = new Size(125, 22);
            summaryToolStripMenuItem.Text = "Summary";
            summaryToolStripMenuItem.Click += mnuSum_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MistyRose;
            groupBox1.Controls.Add(cbStudent);
            groupBox1.Controls.Add(cbDiscount);
            groupBox1.Controls.Add(txtDue);
            groupBox1.Controls.Add(txtDiscount);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtExtendedPrice);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 308);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Information";
            // 
            // cbStudent
            // 
            cbStudent.AutoSize = true;
            cbStudent.Location = new Point(293, 241);
            cbStudent.Name = "cbStudent";
            cbStudent.Size = new Size(110, 19);
            cbStudent.TabIndex = 13;
            cbStudent.Text = "Distinct Student";
            cbStudent.UseVisualStyleBackColor = true;
            // 
            // cbDiscount
            // 
            cbDiscount.AutoSize = true;
            cbDiscount.Location = new Point(293, 194);
            cbDiscount.Name = "cbDiscount";
            cbDiscount.Size = new Size(116, 19);
            cbDiscount.TabIndex = 12;
            cbDiscount.Text = "Normal Discount";
            cbDiscount.UseVisualStyleBackColor = true;
            // 
            // txtDue
            // 
            txtDue.Enabled = false;
            txtDue.Location = new Point(153, 259);
            txtDue.Name = "txtDue";
            txtDue.RightToLeft = RightToLeft.Yes;
            txtDue.Size = new Size(121, 23);
            txtDue.TabIndex = 11;
            // 
            // txtDiscount
            // 
            txtDiscount.Enabled = false;
            txtDiscount.Location = new Point(153, 211);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.RightToLeft = RightToLeft.Yes;
            txtDiscount.Size = new Size(121, 23);
            txtDiscount.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 259);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 9;
            label6.Text = "Net Due";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 211);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 8;
            label5.Text = "Discount";
            // 
            // txtExtendedPrice
            // 
            txtExtendedPrice.Enabled = false;
            txtExtendedPrice.Location = new Point(153, 169);
            txtExtendedPrice.Name = "txtExtendedPrice";
            txtExtendedPrice.RightToLeft = RightToLeft.Yes;
            txtExtendedPrice.Size = new Size(121, 23);
            txtExtendedPrice.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(153, 126);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(121, 23);
            txtPrice.TabIndex = 6;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(153, 85);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(121, 23);
            txtQuantity.TabIndex = 5;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(153, 45);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(235, 23);
            txtTitle.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 169);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 3;
            label4.Text = "Extented Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 126);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 85);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Quantity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 43);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // frmBookSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(439, 345);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmBookSale";
            Text = "Book Sales";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem calculateToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private GroupBox groupBox1;
        private TextBox txtExtendedPrice;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtTitle;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ToolStripMenuItem summaryToolStripMenuItem;
        private Label label5;
        private Label label6;
        private TextBox txtDue;
        private TextBox txtDiscount;
        private CheckBox cbDiscount;
        private CheckBox cbStudent;
    }
}
