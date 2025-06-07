
using EmployeeMgmt1.Database;
using MySql.Data.MySqlClient;
namespace EmployeeMgmt1
{
    public partial class login : Form
    {
        public login()
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
                    string query = "SELECT * FROM users WHERE email = @Email AND password = @Password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", emailInput);
                        cmd.Parameters.AddWithValue("@Password", passwordInput);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Login successful!");
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
