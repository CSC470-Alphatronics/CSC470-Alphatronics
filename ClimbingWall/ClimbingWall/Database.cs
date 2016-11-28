using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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
            catch (Exception ex)
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
            string cmd_str = "SELECT * FROM climbing_wall.employee WHERE Employee_Name = @username AND Password = @password";
            MySqlCommand cmd = new MySqlCommand(cmd_str, connection);
            cmd.CommandText = cmd_str;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
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
