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
    public partial class EmployeeInterface : Form
    {
        public EmployeeInterface()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var login = new ManLogInForm();
            login.Show();
        }

        private void EmployeeInterface_Load(object sender, EventArgs e)
        {

        }

        private void newUsernameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            bool success = Database.Instance.createEmployee(newUsernameInput.Text, newPasswordInput.Text, isAdminInput.Checked);
            if (success)
            {
                MessageBox.Show("User creation succeeded.");
            }
            else
            {
                MessageBox.Show("User creaton failed.");
            }
        }
    }
}
