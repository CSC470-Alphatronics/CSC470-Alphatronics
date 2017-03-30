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
    public partial class SuspendUser : Form
    {
        public SuspendUser()
        {
            InitializeComponent();
        }

        private void suspendButton_Click(object sender, EventArgs e)
        {
            int userID;
            SuspendLength length;
            try
            {
                userID = Int32.Parse(idBox.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            switch (lengthBox.Text)
            {
                case "7 Days":
                    length = SuspendLength.SEVEN_DAYS;
                    break;
                case "30 Days":
                    length = SuspendLength.THIRTY_DAYS;
                    break;
                case "Semester":
                    length = SuspendLength.SEMESTER;
                    break;
                case "1 Year":
                    length = SuspendLength.YEAR;
                    break;
                default:
                    MessageBox.Show("Select a length for the suspension");
                    return;
                    break;
            }
            SuspendCode suspension = Database.Instance.suspendPatron(userID, reasonBox.Text, length);
            switch (suspension)
            {
                case SuspendCode.DB_FAIL:
                    MessageBox.Show("Failed to create suspension");
                    break;
                case SuspendCode.PATRON_NOT_EXIST:
                    MessageBox.Show("Patron ID does not exist");
                    break;
                case SuspendCode.SUCCESS:
                    MessageBox.Show("Sucessfully suspended user " + idBox.Text);
                    break;
                case SuspendCode.SUSPEND_EXISTS:
                    MessageBox.Show("There is already an active suspension for user " + idBox.Text);
                    break;
            }
        }
    }
}
