﻿namespace EmployeeMgmt1
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
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TagBox = new Panel();
            logo = new PictureBox();
            email = new TextBox();
            password = new TextBox();
            button_login = new Button();
            signup = new LinkLabel();
            checkpassword = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TagBox);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 419);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Microsoft Sans Serif", 35F, FontStyle.Bold);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(19, 320);
            label4.Name = "label4";
            label4.Size = new Size(58, 54);
            label4.TabIndex = 3;
            label4.Text = "C";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 35F, FontStyle.Bold);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(17, 216);
            label3.Name = "label3";
            label3.Size = new Size(63, 54);
            label3.TabIndex = 2;
            label3.Text = "M";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 35F, FontStyle.Bold);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(19, 125);
            label2.Name = "label2";
            label2.Size = new Size(58, 54);
            label2.TabIndex = 1;
            label2.Text = "C";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 35F, FontStyle.Bold);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(17, 35);
            label1.Name = "label1";
            label1.Size = new Size(63, 54);
            label1.TabIndex = 0;
            label1.Text = "M";
            label1.Click += label1_Click;
            // 
            // TagBox
            // 
            TagBox.BackColor = Color.White;
            TagBox.Location = new Point(12, 25);
            TagBox.Name = "TagBox";
            TagBox.Size = new Size(73, 370);
            TagBox.TabIndex = 4;
            TagBox.Paint += panel2_Paint;
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.Image = Properties.Resources.mcmc;
            logo.Location = new Point(465, 15);
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
            // signup
            // 
            signup.AutoSize = true;
            signup.Font = new Font("Microsoft Sans Serif", 10F);
            signup.ForeColor = Color.White;
            signup.LinkColor = Color.Teal;
            signup.Location = new Point(493, 347);
            signup.Name = "signup";
            signup.Size = new Size(58, 17);
            signup.TabIndex = 5;
            signup.TabStop = true;
            signup.Text = "Sign Up";
            signup.LinkClicked += signup_LinkClicked;
            // 
            // checkpassword
            // 
            checkpassword.AutoSize = true;
            checkpassword.Location = new Point(407, 257);
            checkpassword.Name = "checkpassword";
            checkpassword.Size = new Size(102, 17);
            checkpassword.TabIndex = 6;
            checkpassword.Text = "Show Password";
            checkpassword.UseVisualStyleBackColor = true;
            checkpassword.CheckedChanged += checkpassword_CheckedChanged;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(742, 419);
            Controls.Add(checkpassword);
            Controls.Add(signup);
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
            Text = "Sign In";
            Load += login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Panel TagBox;
        private LinkLabel signup;
        private CheckBox checkpassword;
    }
}
