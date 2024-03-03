namespace Lab02_B2
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
            btnOk = new Button();
            lbUsername = new Label();
            lbPassword = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOk.Location = new Point(49, 136);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(79, 33);
            btnOk.TabIndex = 0;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(28, 42);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(63, 15);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "User name";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(28, 90);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(105, 87);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(177, 23);
            textBox2.TabIndex = 4;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(173, 136);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(92, 33);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(341, 195);
            Controls.Add(btnCancel);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Controls.Add(btnOk);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private Label lbUsername;
        private Label lbPassword;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnCancel;
    }
}
