using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClimbingWall
{
	public partial class ClinicRegistration : Form
	{

		public ClinicRegistration()
		{
			InitializeComponent();
			DateTime today = DateTime.Today;
			string todayStr = today.Year.ToString() + "-" + today.Month.ToString() + "-" + today.Day.ToString() + " " + today.TimeOfDay.ToString();
			string where = "WHERE Time >= '" + todayStr +"';";

			DataTable dataset = Database.Instance.searchDatabase("clinics ", where);
			try {
				BindingSource bSource = new BindingSource();
				bSource.DataSource = dataset;
				availClinicTable.DataSource = bSource;
				availClinicTable.Refresh();

				//MessageBox.Show(dataset.Rows[0]["Time"].ToString() + "\n" + DateTime.Today.ToString());
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
				return;
			}
		}

		private void regButton_Click(object sender, EventArgs e)
		{
			string patron = patronTextBox.Text;
			string clinic = clinicTextBox.Text;
            if (!DatabaseInputValidation.uintIsValidWithinRange(patron, 0, 9999999) || !DatabaseInputValidation.uintIsValidWithinRange(clinic, 0, 99999999)
                || String.IsNullOrEmpty(patron) || String.IsNullOrEmpty(clinic))
            {
                MessageBox.Show("Please enter valid patron and clinic IDs!");
                return;
            }
			string status = "";
			bool valid = false;
            

			//Check if Patron Valid
			string where = " Where PatronId = " + patron + ";"; //find clinic where clinic_Id = clinic && time >= today
			//MessageBox.Show(where);
			DataTable dataset = Database.Instance.searchDatabase("patron", "PatronID, FK_Suspend" ,where);
			if (dataset.Rows.Count == 1) { //If Patron found
				if (dataset.Rows[0]["FK_Suspend"].ToString() == "") { //check for suspension
					valid = true;
				}
				else
					status = "Patron is Suspeneded";
			}
			else { //If Patron not found
				status = "Patron Not found! ";
				valid = false;
			}
			//Check if Clinic Valid
			if (valid) {
				DateTime today = DateTime.Today;			//need to check if the clinic is still available
				string todayStr = today.Year.ToString() + "-" + today.Month.ToString() + "-" + today.Day.ToString() + " " + today.TimeOfDay.ToString();
				where = " WHERE Clinic_ID = "+ clinic + ";"; //find clinic where clinic_Id = clinic && time >= today
				
				dataset = Database.Instance.searchDatabase("clinics ", where);

				if (dataset.Rows.Count == 1) { //If we have a Clinic with the Proper ID
					string stmt = "Insert Into climbing_wall.clinic_registration (FK_Clinic_ID, FK_Patron_ID) VALUES (" + clinic + ", " + patron + ");";
					if (Database.Instance.nonQuery(stmt)) {
						status = "Regristration Successful!";
					}
					else {
						status += "Registration Failed!";
					}
				}
				else {
					status += "Clinic " + clinic + "Not Found or has already occured!";
				}
			}
			//Add Registration to reg Table


			MessageBox.Show(status);
		}
	}
}
