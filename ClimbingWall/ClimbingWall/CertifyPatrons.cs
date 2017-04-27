using System;
using System.Windows.Forms;
using System.Data;
using System.Text;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ClimbingWall
{
	public partial class CertifyPatrons : Form
	{
		bool belay = false;
		bool lead = false;
		bool bouldering = false;
		string patrons;
		public CertifyPatrons(string patronIDs)
		{
			InitializeComponent();
			patrons = patronIDs;
		}
		private void Belay_chkBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Belay_chkBox.Checked)
				belay = true;
			else
				belay = false;
		}

		private void Lead_chkBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Lead_chkBox.Checked)
				lead = true;
			else
				lead = false;
		}

		private void Bouldering_chkBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Bouldering_chkBox.Checked)
				bouldering = true;
			else
				bouldering = false;
		}

		private void cancelBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			return;
		}

		private void certifyBtn_Click(object sender, EventArgs e)
		{
			string cmd_str = "";
			if (belay)
			{
				cmd_str = "UPDATE climbing_wall.patron SET BelayCert = 1 WHERE PatronID in('" + patrons + "')";
				if (Database.Instance.nonQuery(cmd_str))
				{
					MessageBox.Show("Successfully applied patron belay certifications");
				}
			}
			if (lead)
			{
				cmd_str = "UPDATE climbing_wall.patron SET LeadCert = 1 WHERE PatronID in('" + patrons + "')";
				if (Database.Instance.nonQuery(cmd_str))
				{
					MessageBox.Show("Successfully applied patron lead certifications");
				}
			}
			if (bouldering)
			{
				cmd_str = "UPDATE climbing_wall.patron SET BoulderingCert = 1 WHERE PatronID in('" + patrons + "')";
				if (Database.Instance.nonQuery(cmd_str))
				{
					MessageBox.Show("Successfully applied patron bouldering certifications.");
				}
			}
		}
	}
}
