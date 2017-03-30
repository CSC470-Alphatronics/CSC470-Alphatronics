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
        public EmployeeInterface(EmployeeLevel empLevel)
        {
            InitializeComponent();
            this.adminPanel.Visible = false;
            if (empLevel >= EmployeeLevel.MANAGER)
            {
                levelBox.SelectedIndex = 0;
                this.adminPanel.Visible = true;
            }
            DataTable dataset = Database.Instance.getNotes();
            try
            {
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dataset;
                dataView.RowHeadersVisible = false;
                dataView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                
                dataView.DataSource = bSource;
                dataView.Columns[1].Width = 178;
                dataView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
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
		private void empChk_Click(object sender, EventArgs e) //This is a breif Debug Tool to show what Level we currently are
		{
			string msg = "Employee: " + Globals.currEmployeeName + "\nEmployee ID: " + Globals.currEmployeeId.ToString() + "\nCurrentLevel: " + Globals.empLevel.ToString();
			MessageBox.Show(msg);
		}

        private void noteButton_Click(object sender, EventArgs e)
        {
            var note = new Note();
            note.Show();
        }

		private void Change_Employee_Button_Click(object sender, EventArgs e) //This Allows the switching of User 
		{
			this.Hide();
			var form = new EmployeeLogin();
			form.Closed += (s, args) => this.Close();
			form.Show();
		}

		private void addUserButton_Click(object sender, EventArgs e)
		{
			var addPatron = new NewPatronForm();
			addPatron.Show();
		}

        private void resetPassButton_Click(object sender, EventArgs e)
        {
            var form = new ResetPass();
            form.Show();
        }

        private void searchDatabaseButton_Click(object sender, EventArgs e)
        {
            var form = new SearchForm();
            form.Show();
        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            var schedule = new Schedule();
            schedule.Show();
        }

		private void SusRequestButton_Click(object sender, EventArgs e)
		{
			//var suspendReq = new Note();
			var suspendReq = new SuspensionRequest();
			suspendReq.Show();
		}

		private void ClinicRegButton_Click(object sender, EventArgs e)
		{
			var clinicReg = new ClinicRegistration();
			clinicReg.Show();
		}

		private void reportButton_Click(object sender, EventArgs e)
		{
			var report = new reportGenerator();
			report.Show();
		}

        private void refreshButton_Click(object sender, EventArgs e)
        {
            DataTable dataset = Database.Instance.getNotes();
            try
            {
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dataset;
                dataView.RowHeadersVisible = false;
                dataView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                dataView.DataSource = bSource;
                dataView.Columns[1].Width = 178;
                dataView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
