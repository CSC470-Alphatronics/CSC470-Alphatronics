using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClimbingWall
{
    public partial class EmployeeLogin : Form
    {
        public EmployeeLogin()
        {
            InitializeComponent();
        }
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            bool isAdmin = false;
            bool loggedin= false;

            loggedin = Database.Instance.login(usernameInput.Text, passwordInput.Text, ref isAdmin);

            if (loggedin)
                MessageBox.Show("Login Successful");
            else
                MessageBox.Show("Login Failed");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
