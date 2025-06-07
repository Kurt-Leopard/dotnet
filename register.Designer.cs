namespace EmployeeMgmt1
{
    partial class Register
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TagBox = new Panel();
            checkpassword = new CheckBox();
            signin = new LinkLabel();
            button_register = new Button();
            password = new TextBox();
            email = new TextBox();
            logo = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // 
            // TagBox
            // 
            TagBox.BackColor = Color.White;
            TagBox.Location = new Point(12, 25);
            TagBox.Name = "TagBox";
            TagBox.Size = new Size(73, 370);
            TagBox.TabIndex = 4;
            // 
            // checkpassword
            // 
            checkpassword.AutoSize = true;
            checkpassword.Location = new Point(407, 257);
            checkpassword.Name = "checkpassword";
            checkpassword.Size = new Size(108, 19);
            checkpassword.TabIndex = 13;
            checkpassword.Text = "Show Password";
            checkpassword.UseVisualStyleBackColor = true;
            // 
            // signin
            // 
            signin.AutoSize = true;
            signin.Font = new Font("Microsoft Sans Serif", 10F);
            signin.ForeColor = Color.White;
            signin.LinkColor = Color.Teal;
            signin.Location = new Point(493, 347);
            signin.Name = "signin";
            signin.Size = new Size(51, 17);
            signin.TabIndex = 12;
            signin.TabStop = true;
            signin.Text = "Sign In";
            signin.LinkClicked += signin_LinkClicked;
            // 
            // button_register
            // 
            button_register.BackColor = Color.Teal;
            button_register.Cursor = Cursors.Hand;
            button_register.FlatStyle = FlatStyle.Popup;
            button_register.Font = new Font("Microsoft Sans Serif", 10F);
            button_register.ForeColor = Color.White;
            button_register.Location = new Point(404, 280);
            button_register.Name = "button_register";
            button_register.Size = new Size(234, 42);
            button_register.TabIndex = 11;
            button_register.Text = "Register";
            button_register.UseVisualStyleBackColor = false;
            button_register.Click += button_register_Click;
            // 
            // password
            // 
            password.Location = new Point(404, 214);
            password.Multiline = true;
            password.Name = "password";
            password.PlaceholderText = "Password";
            password.Size = new Size(234, 35);
            password.TabIndex = 10;
            // 
            // email
            // 
            email.BackColor = SystemColors.Window;
            email.Location = new Point(404, 153);
            email.Multiline = true;
            email.Name = "email";
            email.PlaceholderText = "Email";
            email.Size = new Size(234, 35);
            email.TabIndex = 9;
            email.TextChanged += email_TextChanged;
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.Image = Properties.Resources.mcmc;
            logo.Location = new Point(465, 15);
            logo.Name = "logo";
            logo.Size = new Size(101, 101);
            logo.TabIndex = 8;
            logo.TabStop = false;
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
            panel1.TabIndex = 7;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(742, 419);
            Controls.Add(checkpassword);
            Controls.Add(signin);
            Controls.Add(button_register);
            Controls.Add(password);
            Controls.Add(email);
            Controls.Add(logo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel TagBox;
        private CheckBox checkpassword;
        private LinkLabel signin;
        private Button button_register;
        private TextBox password;
        private TextBox email;
        private PictureBox logo;
        private Panel panel1;
    }
}