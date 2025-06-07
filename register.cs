


using EmployeeMgmt1.Database;
using MySql.Data.MySqlClient;
using EmployeeMgmt1.Utilities;
namespace EmployeeMgmt1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_register_Click(object sender, EventArgs e)
        {
            string emailInput = email.Text;
            string passwordInput = password.Text;
            string hashPassword = PasswordHasher.HashPassword(passwordInput);

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO users(email, password) VALUES(@email, @password)";
                    using(MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", emailInput);
                        cmd.Parameters.AddWithValue ("@Password", hashPassword);

                        int rowsAffected = cmd.ExecuteNonQuery(); 

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration Successful!");
                            Login loginForm = new Login();

                            loginForm.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Registration failed (no rows inserted).");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Server error" + ex);
                }
            }
          
        }

        private void signin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginForm = new Login();

            loginForm.Show();

            this.Hide();
        }
    }
}
