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
	public partial class NewPatronForm : Form
	{
		public NewPatronForm()
		{
			InitializeComponent();
		}

		private void CreatePatronButton_Click(object sender, EventArgs e)
		{
			if (termsRadio.Checked) {
				//createPatron(string fName, string lName, string midI, string phone, string email, string pat_Id)
				bool success = Database.Instance.createPatron(FirstNameTextbox.Text, LastNameTextbox.Text, MiddleInitTextbox.Text, PhoneTextbox.Text, EmailTextbox.Text,  Convert.ToInt32(IDTextbox.Text));
				if (success) {
					MessageBox.Show("User creation succeeded.");
					this.Hide();
				}
				else {
					MessageBox.Show("User creaton failed.");
				}
			}
			else {
				MessageBox.Show("You must agree to the terms and conditions \nto create a PatronAccount for the Rock Climbing wall.");
			}
		}
	}
}
