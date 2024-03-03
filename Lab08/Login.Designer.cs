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
            tbId.Location = new Point(72, 50);
            tbId.Name = "tbId";
            tbId.Size = new Size(219, 23);
            tbId.TabIndex = 0;
            tbId.Text = "001";
            // 
            // tbPwd
            // 
            tbPwd.Location = new Point(72, 118);
            tbPwd.Name = "tbPwd";
            tbPwd.Size = new Size(219, 23);
            tbPwd.TabIndex = 1;
            tbPwd.Text = "123";
            tbPwd.UseSystemPasswordChar = true;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(12, 53);
            lb1.Name = "lb1";
            lb1.Size = new Size(17, 15);
            lb1.TabIndex = 2;
            lb1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 121);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(72, 168);
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
            ClientSize = new Size(311, 215);
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
