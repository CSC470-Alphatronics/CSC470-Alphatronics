﻿using System;
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
        public EmployeeInterface(EmployeeLevel empLevel)
        {
            InitializeComponent();
            this.adminPanel.Visible = false;
            if (empLevel >= EmployeeLevel.MANAGER)
            {
                this.adminPanel.Visible = true;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var login = new ManLogInForm();
            login.Show();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
           EmployeeLevel level = EmployeeLevel.EMPLOYEE;
           switch(levelBox.Text)
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

        private void suspendButton_Click(object sender, EventArgs e)
        {
            var suspend = new SuspendUser();
            suspend.Show();
        }

        private void changePassButton_Click(object sender, EventArgs e)
        {
            var login = new ChangePass();
            login.Show();
        }
    }
}
