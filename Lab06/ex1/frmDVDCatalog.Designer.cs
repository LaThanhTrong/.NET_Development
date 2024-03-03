namespace ex1
{
    partial class frmDVDCatalog
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
            groupBox = new GroupBox();
            no = new RadioButton();
            yes = new RadioButton();
            add = new Button();
            save = new Button();
            cancel = new Button();
            dvdNum = new TextBox();
            dvdTitle = new TextBox();
            lang = new ComboBox();
            prc = new NumericUpDown();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prc).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(138, 19);
            label1.Name = "label1";
            label1.Size = new Size(138, 30);
            label1.TabIndex = 0;
            label1.Text = "DVD Catalog";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 68);
            label2.Name = "label2";
            label2.Size = new Size(91, 17);
            label2.TabIndex = 1;
            label2.Text = "DVD Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 107);
            label3.Name = "label3";
            label3.Size = new Size(69, 17);
            label3.TabIndex = 2;
            label3.Text = "DVD Title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 147);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 3;
            label4.Text = "Language";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 187);
            label5.Name = "label5";
            label5.Size = new Size(38, 17);
            label5.TabIndex = 4;
            label5.Text = "Price";
            // 
            // groupBox
            // 
            groupBox.Controls.Add(no);
            groupBox.Controls.Add(yes);
            groupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox.Location = new Point(158, 230);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(150, 100);
            groupBox.TabIndex = 5;
            groupBox.TabStop = false;
            groupBox.Text = "Sub title";
            // 
            // no
            // 
            no.AutoSize = true;
            no.Location = new Point(79, 47);
            no.Name = "no";
            no.Size = new Size(41, 19);
            no.TabIndex = 1;
            no.Text = "No";
            no.UseVisualStyleBackColor = true;
            no.CheckedChanged += no_CheckedChanged;
            // 
            // yes
            // 
            yes.AutoSize = true;
            yes.Checked = true;
            yes.Location = new Point(6, 47);
            yes.Name = "yes";
            yes.Size = new Size(43, 19);
            yes.TabIndex = 0;
            yes.TabStop = true;
            yes.Text = "Yes";
            yes.UseVisualStyleBackColor = true;
            yes.CheckedChanged += yes_CheckedChanged;
            // 
            // add
            // 
            add.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add.Location = new Point(78, 361);
            add.Name = "add";
            add.Size = new Size(82, 36);
            add.TabIndex = 6;
            add.Text = "Add new";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // save
            // 
            save.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            save.Location = new Point(194, 361);
            save.Name = "save";
            save.Size = new Size(82, 36);
            save.TabIndex = 7;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // cancel
            // 
            cancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancel.Location = new Point(316, 361);
            cancel.Name = "cancel";
            cancel.Size = new Size(82, 36);
            cancel.TabIndex = 8;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // dvdNum
            // 
            dvdNum.Location = new Point(158, 68);
            dvdNum.Name = "dvdNum";
            dvdNum.ReadOnly = true;
            dvdNum.Size = new Size(150, 23);
            dvdNum.TabIndex = 9;
            // 
            // dvdTitle
            // 
            dvdTitle.Location = new Point(158, 107);
            dvdTitle.Name = "dvdTitle";
            dvdTitle.Size = new Size(210, 23);
            dvdTitle.TabIndex = 10;
            // 
            // lang
            // 
            lang.FormattingEnabled = true;
            lang.Items.AddRange(new object[] { "English ", "Spanish ", "French ", "Chinese ", "Russian" });
            lang.Location = new Point(158, 147);
            lang.Name = "lang";
            lang.Size = new Size(150, 23);
            lang.TabIndex = 11;
            lang.SelectedIndexChanged += lang_SelectedIndexChanged;
            // 
            // prc
            // 
            prc.Location = new Point(158, 187);
            prc.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            prc.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            prc.Name = "prc";
            prc.Size = new Size(150, 23);
            prc.TabIndex = 12;
            prc.Value = new decimal(new int[] { 5, 0, 0, 0 });
            prc.ValueChanged += prc_ValueChanged;
            // 
            // frmDVDCatalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 450);
            Controls.Add(prc);
            Controls.Add(lang);
            Controls.Add(dvdTitle);
            Controls.Add(dvdNum);
            Controls.Add(cancel);
            Controls.Add(save);
            Controls.Add(add);
            Controls.Add(groupBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDVDCatalog";
            Text = "Form1";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)prc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox;
        private RadioButton no;
        private RadioButton yes;
        private Button add;
        private Button save;
        private Button cancel;
        private TextBox dvdNum;
        private TextBox dvdTitle;
        private ComboBox lang;
        private NumericUpDown prc;
    }
}
