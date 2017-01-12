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
        public bool login(string username, string password, ref EmployeeLevel empLevel)
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
                empLevel = (EmployeeLevel)reader.GetInt16("Level");
            }
            else
            {
                reader.Close();
                return false;
            }
            reader.Close();
            return true;
        }
        public bool patron_login(string ID)
        {
            DateTime dt = DateTime.Now;
            int first_log;
            int userID = Int32.Parse(ID);
            string cmd_str = "SELECT * FROM climbing_wall.patron WHERE PatronID = @ID";
            MySqlCommand cmd = new MySqlCommand(cmd_str, connection);
            cmd.CommandText = cmd_str;
            cmd.Parameters.AddWithValue("@ID", userID);

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
            if(!reader.HasRows)
            {
                reader.Close();
                return false;
            }

            reader.Close();
            cmd_str = "insert into climbing_wall.log_table (FK_Patron_ID, Log_DateTime) VALUES (@id, @dt)";
            cmd = new MySqlCommand(cmd_str, connection);
            cmd.CommandText = cmd_str;
            cmd.Parameters.AddWithValue("@id", userID);
            cmd.Parameters.AddWithValue("@dt", dt);
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            
            long lastInsert = cmd.LastInsertedId;
            cmd_str = "SELECT * FROM climbing_wall.patron WHERE PatronID = @ID";
            cmd = new MySqlCommand(cmd_str, connection);
            cmd.CommandText = cmd_str;
            cmd.Parameters.AddWithValue("@ID", userID);
                reader = cmd.ExecuteReader();
            var ordinal = reader.GetOrdinal("FK_FirstLog");
            reader.Read();
            if (reader.IsDBNull(ordinal))
                first_log = (int)lastInsert;
            else
                first_log = reader.GetInt32("FK_FirstLog");
            reader.Close();

            cmd_str = "UPDATE `climbing_wall`.`patron` SET `New_Flag`='0', `FK_FirstLog` = @fLog, `FK_LatestLog` = @lLog WHERE `PatronID` = @id";
            cmd = new MySqlCommand(cmd_str, connection);
            cmd.CommandText = cmd_str;
            cmd.Parameters.AddWithValue("@id", userID);
            cmd.Parameters.AddWithValue("@flog", first_log);
            cmd.Parameters.AddWithValue("@lLog", (int)lastInsert);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        public bool createEmployee(string username, string password, EmployeeLevel empLevel)
        {
            var hasher = new PasswordHasher();
            string hashedPassword = hasher.Hash(password);
            string cmd_str = "INSERT INTO climbing_wall.employee (Employee_Name, Password, Level) VALUES (@username, @hashedPassword, @level)";
            MySqlCommand cmd = new MySqlCommand(cmd_str, connection);
            cmd.CommandText = cmd_str;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@hashedPassword", hashedPassword);
            cmd.Parameters.AddWithValue("@level", empLevel);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

    }
}
