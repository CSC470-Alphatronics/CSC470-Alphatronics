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
    public partial class SearchForm : Form
    {
        private string selectedTable;
        public SearchForm()
        {
            InitializeComponent();
            selectedTable = "climbing_wall.employee";
            tableSelectBox.SelectedIndex = 0;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (databaseSearchValidation() == true)
            {
                string whereStatement = formWhereStatement();
                DataTable dataset = Database.Instance.searchDatabase(selectedTable, whereStatement);
                try
                {
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = dataset;
                    tableDataView.DataSource = bSource;
                    tableDataView.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            else
            {
                MessageBox.Show("There was an error with the input. Please check the fields for invalid characters and try again.");
            }
        }

        private string formWhereStatement()
        {
            string whereStatement = "";
            //logic
            switch (tableSelectBox.SelectedIndex)
            {
                case ((int)DatabaseSearchVal.EMPLOYEE):
                    bool firstEmp = true;
                    if (!string.IsNullOrEmpty(empIdBox.Text))
                    {
                        whereStatement += " where employee_id=" + empIdBox.Text;
                        firstEmp = false;
                    }
                    if (!string.IsNullOrEmpty(empLevelBox.Text))
                    {
                        if (firstEmp == true)
                        {
                            whereStatement += " where ";
                            firstEmp = false;
                        }
                        else
                        {
                            whereStatement += " and ";
                        }
                        whereStatement += "level=" + empLevelBox.Text;
                    }
                    if (!string.IsNullOrEmpty(empNameBox.Text))
                    {
                        if (firstEmp == true)
                        {
                            whereStatement += " where ";
                            firstEmp = false;
                        }
                        else
                        {
                            whereStatement += " and ";
                        }
                        whereStatement += "Employee_Username='" + empNameBox.Text + "'";
                    }
                    break;//employee

                case ((int)DatabaseSearchVal.PATRON):
                    bool firstPat = true;
                    if (!string.IsNullOrEmpty(patronIdBox.Text))
                    {
                        whereStatement += " where patronid=" + patronIdBox.Text;
                        firstPat = false;
                    }
                    if (!string.IsNullOrEmpty(patronFirstNameBox.Text))
                    {
                        if (firstPat == true)
                        {
                            whereStatement += " where ";
                            firstPat = false;
                        }
                        else
                        {
                            whereStatement += " and ";
                        }
                        whereStatement += "FName='" + patronFirstNameBox.Text + "'";
                    }
                    if (!string.IsNullOrEmpty(patronLastNameBox.Text))
                    {
                        if (firstPat == true)
                        {
                            whereStatement += " where ";
                            firstPat = false;
                        }
                        else
                        {
                            whereStatement += " and ";
                        }
                        whereStatement += "LName='" + patronLastNameBox.Text + "'";
                    }
                    break;//patron

                case ((int)DatabaseSearchVal.LOGINS):
                    bool firstLog = true;
                    if (!string.IsNullOrEmpty(loginPatronIdBox.Text))
                    {
                        whereStatement += " where FK_Patron_ID=" + loginPatronIdBox.Text;
                        firstLog = false;
                    }
                    break;//logins

                case ((int)DatabaseSearchVal.SUSPENSIONS):
                    bool firstSus = true;
                    if (!string.IsNullOrEmpty(susPatronIdBox.Text))
                    {
                        whereStatement += " where FK_Patron_ID=" + susPatronIdBox.Text;
                        firstSus = false;
                    }
                    break;//suspensions
            }
            return whereStatement;
        }

        private void tableSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tableSelectBox.SelectedIndex)
            {
                case ((int)DatabaseSearchVal.EMPLOYEE):
                    tablePageControl.SelectedIndex = 0;
                    selectedTable = "climbing_wall.employee";
                    break;
                case ((int)DatabaseSearchVal.PATRON):
                    tablePageControl.SelectedIndex = 1;
                    selectedTable = "climbing_wall.patron";
                    break;
                case ((int)DatabaseSearchVal.LOGINS):
                    tablePageControl.SelectedIndex = 2;
                    selectedTable = "climbing_wall.log_table";
                    break;
                case (int)DatabaseSearchVal.SUSPENSIONS:
                    tablePageControl.SelectedIndex = 3;
                    selectedTable = "climbing_wall.suspensions";
                    break;
            }
        }

        private bool databaseSearchValidation()
        {
            bool isValid = false;
            switch (tableSelectBox.SelectedIndex)
            {
                case ((int)DatabaseSearchVal.EMPLOYEE):
                    if (DatabaseInputValidation.uintIsValid(empIdBox.Text) &&
                        DatabaseInputValidation.uintIsValidWithinRange(empLevelBox.Text, 0, 2) &&
                        DatabaseInputValidation.stringIsValid(empNameBox.Text))
                        isValid = true;
                    break;
                case ((int)DatabaseSearchVal.PATRON):
                    if (DatabaseInputValidation.uintIsValid(patronIdBox.Text) &&
                        DatabaseInputValidation.nameIsValid(patronFirstNameBox.Text) &&
                        DatabaseInputValidation.nameIsValid(patronLastNameBox.Text))
                    {
                        isValid = true;
                    }
                    break;
                case ((int)DatabaseSearchVal.LOGINS):
                    if (DatabaseInputValidation.uintIsValid(loginPatronIdBox.Text))
                    {
                        isValid = true;
                    }
                    break;
                case ((int)DatabaseSearchVal.SUSPENSIONS):
                    if (DatabaseInputValidation.uintIsValid(susPatronIdBox.Text))
                    {
                        isValid = true;
                    }
                    break;
            }
            return isValid;
        }
    }
}
