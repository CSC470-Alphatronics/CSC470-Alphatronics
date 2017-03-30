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
	public partial class ClinicRegistration : Form
	{

		public ClinicRegistration()
		{
			InitializeComponent();

			DataTable dataset = Database.Instance.searchDatabase("clinics ", "");
			try {
				BindingSource bSource = new BindingSource();
				bSource.DataSource = dataset;
				availClinicTable.DataSource = bSource;
				availClinicTable.Refresh();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
				return;
			}
		}

		private void regButton_Click(object sender, EventArgs e)
		{

		}
	}
}
