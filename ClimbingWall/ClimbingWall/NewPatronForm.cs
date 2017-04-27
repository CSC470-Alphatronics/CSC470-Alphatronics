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
			if (FirstNameTextbox.Text != "" && LastNameTextbox.Text != "" && MiddleInitTextbox.Text != "" && EmailTextbox.Text != "" && PhoneTextbox.Text != "" && IDTextbox.Text != "") {
				//First make sure all the text boxes are filled
				bool isValid = true;

				if (!DatabaseInputValidation.nameIsValid(FirstNameTextbox.Text) && isValid) {
					isValid = false;
					MessageBox.Show("First Name has Invalid Input!");
				}
				if (!DatabaseInputValidation.nameIsValid(FirstNameTextbox.Text) && isValid) {
					isValid = false;
					MessageBox.Show("Last Name has Invalid Input!");
				}
				if (!DatabaseInputValidation.nameIsValid(FirstNameTextbox.Text) && isValid) {
					isValid = false;
					MessageBox.Show("Middle Initial has Invalid Input!");
				}
				if (!DatabaseInputValidation.uintIsValid(PhoneTextbox.Text) && isValid) {
					isValid = false;
					MessageBox.Show("Phone Number has Invalid Input!");
				}
				if (!DatabaseInputValidation.uintIsValid(IDTextbox.Text) && isValid) {
					isValid = false;
					MessageBox.Show("ID number has Invalid Input!");
				}
				if (!DatabaseInputValidation.stringIsValid(EmailTextbox.Text) && isValid) {
					isValid = false;
					MessageBox.Show("Email has Invalid Input!");
				}


				if (isValid)
                {
                    var sign = new SignWaiver(FirstNameTextbox.Text, LastNameTextbox.Text, MiddleInitTextbox.Text, PhoneTextbox.Text, EmailTextbox.Text, Convert.ToInt32(IDTextbox.Text));
                    sign.Show();
				}
			}
			else 
{
				MessageBox.Show("Make sure all textboxes are filled out!");
			}
		}
	}
}
