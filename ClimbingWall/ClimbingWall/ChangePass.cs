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
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (newText.Text == confirmText.Text && confirmText.Text.Length >= Constants.minPasswordLength)
            {
                bool success = Database.Instance.changePassword(currentText.Text, confirmText.Text);
                if (success)
                {
                    MessageBox.Show("Successfully changed password");
                }
                else
                {
                    MessageBox.Show("Failed to change password");
                }
            }
            else if (confirmText.Text.Length >= Constants.minPasswordLength)
            {
                MessageBox.Show("Passwords do not match");
            }
            else
                MessageBox.Show("Password must be at least " + Constants.minPasswordLength.ToString() + " characters long."); 
        }
    }
}
