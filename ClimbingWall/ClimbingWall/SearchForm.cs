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

        private string formWhereStatement()
        {
            string whereStatement = "";
            //logic
            switch(tableSelectBox.SelectedIndex)
            {
                case (0): //Employee
                    bool first = true;
                    if (!string.IsNullOrEmpty(empIdBox.Text))
                    {
                        whereStatement += " where employee_id=" + empIdBox.Text;
                        first = false;
                    }
                    if (!string.IsNullOrEmpty(empLevelBox.Text) && first == true)
                    {
                        whereStatement += " where level=" + empLevelBox.Text;
                        first = false;
                    }
                    else if (!string.IsNullOrEmpty(empLevelBox.Text))
                    {
                        whereStatement += " and level=" + empLevelBox.Text;
                    }
                    if (!string.IsNullOrEmpty(empNameBox.Text) && first == true)
                    {
                        whereStatement += " where employee_name=" + empNameBox.Text;
                        first = false;
                    }
                    else if (!string.IsNullOrEmpty(empNameBox.Text))
                    {
                        whereStatement += " and employee_name=" + empNameBox.Text;
                    }
                    break;
                case (1): //Patron
                    if (!string.IsNullOrEmpty(patronIdBox.Text))
                    {
                        whereStatement += " where patronid=" + patronIdBox.Text;
                    }
                    break;
            }
            return whereStatement;
        }

        private void tableSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        { //needs to be reworked into an enum or something pls
            switch (tableSelectBox.SelectedIndex)
            {
                case (0): //Employee
                    tablePageControl.SelectedIndex = 0;
                    selectedTable = "climbing_wall.employee";
                    break;
                case (1): //Patron
                    tablePageControl.SelectedIndex = 1;
                    selectedTable = "climbing_wall.patron";
                    break;
            }
        }
    }
}
