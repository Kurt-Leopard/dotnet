
using EmployeeMgmt1.Database;
using MySql.Data.MySqlClient;
using EmployeeMgmt1.Utilities;
namespace EmployeeMgmt1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {


        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (!email.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email.");
                return;
            }

            string emailInput = email.Text;
            string passwordInput = password.Text;

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                try
                {
                    
                    conn.Open();
                    string query = "SELECT password FROM users WHERE email = @Email";

                    string storedHash = null;
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@Email", emailInput);
                 
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            storedHash = result.ToString();
                        }

                        if (storedHash != null && PasswordHasher.VerifyPassword(passwordInput, storedHash))
                        {
                            MessageBox.Show("Login successful!");
                    
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkpassword_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();

            // Show the register form
            registerForm.Show();

            // Optionally hide or close the login form
            this.Hide();

        }
    }
}
