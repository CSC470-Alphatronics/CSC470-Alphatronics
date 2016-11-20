using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
            builder.Password = "";
            builder.Database = "climbing_wall";
            connection = new MySqlConnection(builder.ToString());
            connection.Open();
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
    }
}
