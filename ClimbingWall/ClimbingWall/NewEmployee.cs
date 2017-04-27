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
    public partial class NewEmployee : Form
    {
        public NewEmployee()
        {
            InitializeComponent();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeLevel level = EmployeeLevel.EMPLOYEE;
            switch (levelBox.Text)
            {
                case "Employee":
                    level = EmployeeLevel.EMPLOYEE;
                    break;
                case "Manager":
                    level = EmployeeLevel.MANAGER;
                    break;
                case "Admin":
                    level = EmployeeLevel.ADMIN;
                    break;
            }
            if (DatabaseInputValidation.mandatoryStringIsValid(newUsernameInput.Text, 3) && newPasswordInput.Text.Length >= 4)
            {
                bool success = Database.Instance.createEmployee(newUsernameInput.Text, newPasswordInput.Text, level);
                if (success)
                {
                    MessageBox.Show("User creation succeeded.");
                }
                else
                {
                    MessageBox.Show("User creaton failed.");
                }
            }
            else
            {
                MessageBox.Show("Please enter the new user's username and password (passwords must be at least four characters).");
            }
        }
    }
}
