using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string path = @"config.ini";
            if (File.Exists(path) && Globals.useConfigFile)
            {
                char[] delimiters = { ' ', '\t', '=' };
                string[] lines = File.ReadAllLines(@"config.ini", Encoding.UTF8);
                Globals.DBPort = lines[0].Split(delimiters, StringSplitOptions.RemoveEmptyEntries)[1];
                Globals.DBID = lines[1].Split(delimiters, StringSplitOptions.RemoveEmptyEntries)[1];
                Globals.DBPassword = lines[2].Split(delimiters, StringSplitOptions.RemoveEmptyEntries)[1];
                Globals.DBName = lines[3].Split(delimiters, StringSplitOptions.RemoveEmptyEntries)[1];
            }
            else if(Globals.useConfigFile)
            {
                MessageBox.Show("ERROR: missing file \"config.ini\"");
                Application.Exit();
            }
            Database.Instance.connect();
            Application.Run(new EmployeeLogin());
        }
    }
}
