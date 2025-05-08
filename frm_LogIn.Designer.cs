namespace group_project
{
    partial class LoginForm
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
            btnLogin = new Button();
            kbk_YserName = new Label();
            lbl_password = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.AccessibleRole = AccessibleRole.TitleBar;
            btnLogin.AllowDrop = true;
            btnLogin.Font = new Font("Franklin Gothic Medium Cond", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(206, 186);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(84, 36);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // kbk_YserName
            // 
            kbk_YserName.AutoSize = true;
            kbk_YserName.Font = new Font("Franklin Gothic Medium Cond", 14.25F);
            kbk_YserName.Location = new Point(70, 72);
            kbk_YserName.Name = "kbk_YserName";
            kbk_YserName.Size = new Size(85, 24);
            kbk_YserName.TabIndex = 1;
            kbk_YserName.Text = "User Name";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Franklin Gothic Medium Cond", 14.25F);
            lbl_password.Location = new Point(70, 117);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(76, 24);
            lbl_password.TabIndex = 2;
            lbl_password.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Franklin Gothic Medium Cond", 14.25F);
            txtUsername.Location = new Point(172, 64);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(212, 29);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Franklin Gothic Medium Cond", 14.25F);
            txtPassword.Location = new Point(172, 114);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(212, 29);
            txtPassword.TabIndex = 4;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(507, 244);
            ControlBox = false;
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lbl_password);
            Controls.Add(kbk_YserName);
            Controls.Add(btnLogin);
            Name = "LoginForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label kbk_YserName;
        private Label lbl_password;
        private TextBox txtUsername;
        private TextBox txtPassword;
    }
}