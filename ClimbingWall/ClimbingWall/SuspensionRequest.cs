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
	public partial class SuspensionRequest : Form
	{
		public SuspensionRequest()
		{
			InitializeComponent();
		}

		private void reqButton_Click(object sender, EventArgs e)
		{
            //Patron ID validation goes here
            if (!DatabaseInputValidation.uintIsValidWithinRange(idTextBox.Text, 0, 9999999))
            {
                MessageBox.Show("Please enter a valid patron ID!");
            }
            if (!String.IsNullOrEmpty(idTextBox.Text)
                && DatabaseInputValidation.mandatoryStringIsValid(reasonTextBox.Text, 1) && DatabaseInputValidation.mandatoryStringIsValid(lengthTextBox.Text, 1)){
                String reqText = "Suspension Request for Patron: " + idTextBox.Text + " For: " + reasonTextBox.Text + ". Suggested Suspension: " + lengthTextBox.Text;
                Database.Instance.addNote(reqText, 10);
            }
            else
            {
                MessageBox.Show("Please enter information for all fields!");
            }

		}
	}
}
