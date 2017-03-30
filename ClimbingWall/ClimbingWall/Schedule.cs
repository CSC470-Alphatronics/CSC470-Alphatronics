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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string start = startDate.Text;
            string end = endDate.Text;
            string where = "where Time >= '" + start + " 00:00:00' and Time <= '" + end + " 23:59:59';";
            DataTable dataset = Database.Instance.searchDatabase("clinics ", where);
            try
            {
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dataset;
                dataView.DataSource = bSource;
                dataView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void newClinicButton_Click(object sender, EventArgs e)
        {
            int empID = Database.Instance.getEmployeeID(instructorBox.Text.Trim());
            if (empID < 0)
            {
                MessageBox.Show("Employee name not found");
                return;
            }
            int hourNum = Int32.Parse(newHourBox.Text);
            string hour;
            string minute = newMinuteBox.Text;
            if (newPeriodBox.Text == "PM")
            {
                hourNum += 12;
            }
            if (hourNum >= 24)
                hour = "00";
            else
                hour = hourNum.ToString();
            string dateTime = newDate.Text + " " + hour + ":" + minute + ":00";
            string sql = "INSERT INTO climbing_wall.clinics (FK_Instruct_ID, Topic, Time) VALUES (" + empID + ",'" + descriptionBox.Text + "','" + dateTime + "')";
            if (Database.Instance.nonQuery(sql))
            {
                MessageBox.Show("Successfully created clinic");
            }
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            if (dataView.RowCount == 0 || dataView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Error: no row selected");
                return;
            }
            string id = dataView.SelectedRows[0].Cells[0].Value.ToString();

            string where = "where FK_Clinic_ID = " + id;
            DataTable dataset = Database.Instance.searchDatabase("climbing_wall.clinic_registration ", where);
            try
            {
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dataset;
                dataView.DataSource = bSource;
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
