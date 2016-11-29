using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Liphsoft.Crypto.Argon2;

namespace ClimbingWall
{
    public class Database
    {
        MySqlConnection connection;
        private static Database instance;

        public void connect()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "root";
            builder.Database = "climbing_wall";
            connection = new MySqlConnection(builder.ToString());
            try
            {
                connection.Open();
                MessageBox.Show("Connection Successful");
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Failed");
            }
        }
        ~Database()
        {
            connection.Close();
        }

        public static Database Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }
        }
        public bool login(string username, string password, ref bool isAdmin)
        {
            string cmd_str = "SELECT * FROM climbing_wall.employee WHERE Employee_Name = @username";
            MySqlCommand cmd = new MySqlCommand(cmd_str, connection);
            cmd.CommandText = cmd_str;
            cmd.Parameters.AddWithValue("@username", username);

            // Create hasher variable to hash the entered password
            var hasher = new PasswordHasher();
            // Cross-check hashed password with hashes in database
            // If match is found
            MySqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            if (reader.HasRows)
            {
                reader.Read();
                if (!hasher.Verify(reader.GetString("Password"), password))
                {
                    reader.Close();
                    return false;
                }
                if (reader.GetBoolean("Admin") == true)
                    isAdmin = true;
            }
            else
            {
                reader.Close();
                return false;
            }
            reader.Close();
            return true;
        }
    }
}
