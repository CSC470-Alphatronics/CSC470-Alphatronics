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
    
    public partial class ManLogInForm : Form
    {
        
        Patron[] patList = { new Patron(1998812, false), new Patron(1443321, false), new Patron(3522521, true, "Arson"), new Patron(1234567, true, "Being a Dick") };
            
        public ManLogInForm()
        {
            InitializeComponent();
            
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            PatronLoginStatus loggedIn = PatronLoginStatus.MISCERROR;
            if (String.IsNullOrEmpty(idTextbox.Text))
            {
                MessageBox.Show("Please input an ID!");
            }
            else if (!DatabaseInputValidation.uintIsValid(idTextbox.Text))
            {
                MessageBox.Show("User ID must be a number!");
            }
            else
            {
                loggedIn = Database.Instance.patron_login(idTextbox.Text);
                string status;
                switch (loggedIn)
                {
                    case PatronLoginStatus.MISCERROR:
                        status = "Login failed!"; break;
                    case PatronLoginStatus.PATRONNOTFOUND:
                        status = "Patron not found!"; break;
                    case PatronLoginStatus.PATRONSUSPENDED:
                        status = "Patron currently suspended!"; break;
                    case PatronLoginStatus.SUCCESS:
                        status = "Login successful!"; break;
                    default:
                        status = "what"; break;
                }
                MessageBox.Show(status);
            }
        }

        private void idTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logButton.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
    public class Patron
    {
        private int id;
        private bool suspended;
        private string reason;

        public Patron(int idIn, bool susIn)
        {
            this.id = idIn;
            this.suspended = susIn;
            this.reason = "";
        }
        public Patron(int idIn, bool susIn, string reasonIn)
        {
            this.id = idIn;
            this.suspended = susIn;
            this.reason = reasonIn;
        }
        public bool isId(int idIn)
        {
            if (this.id == idIn)
                return true;
            else
                return false;
        }
        public bool isSus() { return this.suspended; }
        public int getId() { return this.id; }
        public string getReason() { return this.reason; }
    }
}
