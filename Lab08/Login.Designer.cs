namespace Lab08
{
    partial class Login
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
            tbId = new TextBox();
            tbPwd = new TextBox();
            lb1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // tbId
            // 
            tbId.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbId.Location = new Point(121, 36);
            tbId.Name = "tbId";
            tbId.Size = new Size(219, 25);
            tbId.TabIndex = 0;
            tbId.Text = "001";
            // 
            // tbPwd
            // 
            tbPwd.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPwd.Location = new Point(121, 86);
            tbPwd.Name = "tbPwd";
            tbPwd.Size = new Size(219, 25);
            tbPwd.TabIndex = 1;
            tbPwd.Text = "123";
            tbPwd.UseSystemPasswordChar = true;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb1.Location = new Point(12, 37);
            lb1.Name = "lb1";
            lb1.Size = new Size(103, 20);
            lb1.TabIndex = 2;
            lb1.Text = "Instructior ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(121, 128);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(219, 35);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(359, 177);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(lb1);
            Controls.Add(tbPwd);
            Controls.Add(tbId);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbId;
        private TextBox tbPwd;
        private Label lb1;
        private Label label2;
        private Button btnLogin;
    }
}
