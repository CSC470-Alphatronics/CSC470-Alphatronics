using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClimbingWall
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connectStr = null;
            MySqlConnection connect;
            connectStr = "server=localhost;database=climbing_wall;uid=root;pwd=root;";
            connect = new MySqlConnection(connectStr);
            try
            {
                connect.Open();
                MessageBox.Show("Connection Successful");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Connection Failed");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EmployeeLogin());
        }
    }
}
