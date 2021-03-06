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
            this.Size = new Size(556, 420);
            if (empLevel >= EmployeeLevel.MANAGER)
            {
                this.adminPanel.Visible = true;
                this.Size = new Size(677, 420);
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
            var newEmp = new NewEmployee();
            newEmp.Show();
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

		private void noteDelete_Click(object sender, EventArgs e)
		{
			if (dataView.RowCount == 0 || dataView.SelectedRows.Count == 0) {
				MessageBox.Show("Error: no data selected");
				return;
			}
			
			string note = dataView.SelectedRows[0].Cells[1].Value.ToString();

			string where = "where Note_Text = '" + note + "';";
			Database.Instance.nonQuery("Delete from note " + where);
			refreshButton_Click(this, e);
		}

        private void modifyPatronButton_Click(object sender, EventArgs e)
        {
            var modifyPatron = new ModifyPatronForm();
            modifyPatron.Show();
        }
    }
}
