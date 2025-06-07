using MySql.Data.MySqlClient;

namespace EmployeeMgmt1.Database
{
    public class DbConnection  // must be public
    {
        private static readonly string connectionString = "server=localhost;user=root;password=;database=dotnet;";

        public static MySqlConnection GetConnection()  // must be public
        {
            return new MySqlConnection(connectionString);
        }
    }
}
