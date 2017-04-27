using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using System.IO;

namespace ClimbingWall
{
    public partial class Schedule : Form
    {
        string currentClinicID;
        public Schedule()
        {
            InitializeComponent();
			this.CertPatsBtn.Visible = false;
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
            mailButton.Visible = false;
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

            int hourNumEnd = Int32.Parse(newHourEnd.Text);
            string hourEnd;
            string minuteEnd = newMinuteEnd.Text;
            if (newPeriodEnd.Text == "PM")
            {
                hourNumEnd += 12;
            }
            if (hourNumEnd >= 24)
                hourEnd = "00";
            else
                hourEnd = hourNumEnd.ToString();
            string dateTimeEnd = newDate.Text + " " + hourEnd + ":" + minuteEnd + ":00";

            string sql = "INSERT INTO climbing_wall.clinics (FK_Instruct_ID, Topic, Time, Time_End) VALUES (" + empID + ",'" + descriptionBox.Text + "','" + dateTime + "','" + dateTimeEnd + "')";
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
            try
            {
                currentClinicID = dataView.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Error: no row selected");
                return;
            }
            string where = "where FK_Clinic_ID = " + currentClinicID;
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
            mailButton.Visible = true;
			if (Globals.empLevel >= EmployeeLevel.MANAGER)
			{
				this.CertPatsBtn.Visible = true;
			}
		}

        private void mailButton_Click(object sender, EventArgs e)
        {
            List<MailRecipient> mailingList = new List<MailRecipient>();

            if (dataView.RowCount == 0)
            {
                MessageBox.Show("Error: no users registered");
                return;
            }
            string idlist = "";
            for (int i = 0; i < dataView.RowCount-1; i++)
            {
                string id = dataView.Rows[i].Cells[1].Value.ToString();
                if (id != "")
                {
                    if (i > 0)
                        idlist += ",";
                    idlist += id;
                }
            }
            string where = "where PatronID in(" + idlist + ");";
            DataTable dt = Database.Instance.searchDatabase("patron", "Email, PatronID", where);

            MailRecipient m;
            m.address = "";
            m.name = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                m.address = dt.Rows[i][0].ToString();
                m.name = dt.Rows[i][1].ToString();
                if (m.address != "")
                    mailingList.Add(m);
            }

            StreamWriter writer = File.CreateText("Clinic_" + currentClinicID + ".csv");
            writer.AutoFlush = true;
            var csv = new CsvWriter(writer);
            foreach (MailRecipient rec in mailingList)
            {
                csv.WriteField(rec.address);
                csv.WriteField(rec.name);
                csv.NextRecord();
            }
        }

		private void CertPatsBtn_Click(object sender, EventArgs e)
		{
			if (dataView.RowCount == 0)
			{
				MessageBox.Show("Error: no users registered");
				return;
			}
			string idlist = "";
			for (int i = 0; i < dataView.RowCount - 1; i++)
			{
				string id = "";
				if (dataView.Rows[i].Cells[2].Value.ToString() == "1")
				{
					// Patron has earned certification
					id = dataView.Rows[i].Cells[1].Value.ToString();
					if (id != "")
					{
						if (i > 0)
							idlist += ",";
						idlist += id;
					}
				}
			}
            if (idlist != "")
            {
                var CertMenu = new CertifyPatrons(idlist);
                CertMenu.Show();
            }
            else
            {
                MessageBox.Show("Error: No patrons in attendance");
            }
		}
	}
}
