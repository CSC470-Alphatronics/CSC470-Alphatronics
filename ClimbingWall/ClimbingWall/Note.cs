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
    public partial class Note : Form
    {
        public Note()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            int priority;
            switch(priorityBox.Text)
            {
                case "Normal":
                    priority = 1;
                    break;
                case "High":
                    priority = 10;
                    break;
                default:
                    MessageBox.Show("Select message priority");
                    return;
            }
            if (validateNote() && Database.Instance.addNote(noteText.Text, priority))
                MessageBox.Show("Success");
            else
                MessageBox.Show("Failed to enter note");
        }
        private bool validateNote()
        {
            if (DatabaseInputValidation.stringIsValid(noteText.Text)){
                return true;
            }
            return false;
        }
    }
}
