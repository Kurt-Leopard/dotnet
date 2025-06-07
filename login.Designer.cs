namespace EmployeeMgmt1
{
    partial class login
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
            panel1 = new Panel();
            logo = new PictureBox();
            email = new TextBox();
            password = new TextBox();
            button_login = new Button();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 419);
            panel1.TabIndex = 0;
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.Image = Properties.Resources.mcmc;
            logo.Location = new Point(460, 15);
            logo.Name = "logo";
            logo.Size = new Size(101, 101);
            logo.TabIndex = 1;
            logo.TabStop = false;
            logo.Click += logo_Click;
            // 
            // email
            // 
            email.BackColor = SystemColors.Window;
            email.Location = new Point(404, 153);
            email.Multiline = true;
            email.Name = "email";
            email.PlaceholderText = "Email";
            email.Size = new Size(234, 35);
            email.TabIndex = 2;
            email.TextChanged += email_TextChanged;
            // 
            // password
            // 
            password.Location = new Point(404, 214);
            password.Multiline = true;
            password.Name = "password";
            password.PlaceholderText = "Password";
            password.Size = new Size(234, 35);
            password.TabIndex = 3;
            password.TextChanged += password_TextChanged;
            // 
            // button_login
            // 
            button_login.BackColor = Color.Teal;
            button_login.Cursor = Cursors.Hand;
            button_login.FlatStyle = FlatStyle.Popup;
            button_login.Font = new Font("Microsoft Sans Serif", 10F);
            button_login.ForeColor = Color.White;
            button_login.Location = new Point(404, 280);
            button_login.Name = "button_login";
            button_login.Size = new Size(234, 42);
            button_login.TabIndex = 4;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(770, 419);
            Controls.Add(button_login);
            Controls.Add(password);
            Controls.Add(email);
            Controls.Add(logo);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += login_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox logo;
        private TextBox email;
        private TextBox password;
        private Button button_login;
    }
}
