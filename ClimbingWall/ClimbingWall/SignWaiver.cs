using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ClimbingWall
{
    public partial class SignWaiver : Form
    {
        Bitmap bmp ;
        Color drawColor = Color.White;
        bool draw = false;
        bool signed = false;
        int x, y, lx, ly = 0;
        string first, last, mInitial, phoneNum, eAddress;
        int ID;
        bool modify = false;
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, Point.Empty);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
           if (draw)
            {
                signed = true;
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.FillEllipse(Brushes.Black, e.X, e.Y, 5, 5);
                }
                pictureBox1.Invalidate();
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            bmp.Save(ms, ImageFormat.Bmp);
            byte[] img = ms.ToArray();

            if (signed)
            {
                if(modify)
                {
                    mod(img);
                }
                else
                {
                    create(img);
                }
            }
            else
            {
                MessageBox.Show("Please sign the waiver");
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
            lx = e.X;
            ly = e.Y;
        }

        public SignWaiver(string fname, string lname, string middle, string phone, string email, int id, bool m)
        {
            InitializeComponent();
            first = fname;
            last = lname;
            mInitial = middle;
            phoneNum = phone;
            eAddress = email;
            ID = id;
            modify = m;
            bmp = new Bitmap(432, 116);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            x = e.X;
            y = e.Y;
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.FillEllipse(Brushes.Black, e.X, e.Y, 5, 5);
            }
            pictureBox1.Invalidate();
        }
        private void create(byte[] img)
        {
            bool success = Database.Instance.createPatron(first, last, mInitial, phoneNum, eAddress, ID, img);
            if (success)
            {
                MessageBox.Show("User creation succeeded.");
                this.Close();
            }
            else
            {
                MessageBox.Show("User creaton failed.");
            }
        }
        private void mod(byte[] img)
        {
            bool status = Database.Instance.modifyPatron(first, last, mInitial, phoneNum, eAddress, ID, img);
            if (status == true)
            {
                MessageBox.Show("User data updated.");
                this.Close();
            }
            else
            {
                MessageBox.Show("User modification failed.");
            }
        }
    }
}
