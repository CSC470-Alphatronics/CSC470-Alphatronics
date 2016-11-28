using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaygroudForms
{
    
    public partial class ManLogInForm : Form
    {
        
        Patron[] patList = { new Patron(1998812, false), new Patron(1443321, false), new Patron(3522521, true, "Arson"), new Patron(1234567, true, "Being a Dick") };
            
        public ManLogInForm()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int chkId;
            Patron blankPat = new Patron(0, true, "");
            Patron findPat = blankPat;
            chkId = Convert.ToInt32(idTextbox.Text);
            resultLabel.Text = Convert.ToString(chkId);
            foreach (Patron p in patList)
            {
                if (p.isId(chkId))
                {
                    findPat = p;
                    break;
                }
            }
            if (findPat.isId(0))
                resultLabel.Text = "Patron " + Convert.ToString(chkId) + " Not Found";
            else
            {
                if (findPat.isSus())
                    resultLabel.Text = "Patron " + Convert.ToString(findPat.getId()) + " Is SUSPENDED For: " + findPat.getReason();
                else
                {
                    resultLabel.Text = "Patron " + Convert.ToString(findPat.getId()) + " Logged In!";
                    //OtherLoginStuff
                        //Display Patron Info
                        //Create Log
                            //If First Log isn't filled, fill it with the new log.
                            //set Latest log to the newest log made.
                }
            }
        }

        private void resultLabel_Click(object sender, EventArgs e)
        {

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
