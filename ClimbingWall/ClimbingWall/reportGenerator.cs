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
	public partial class reportGenerator : Form
	{
		public reportGenerator()
		{
			InitializeComponent();
		}

		private void generateReport_Click(object sender, EventArgs e)
		{
			string start = startDate.Text;
			string end =  endDate.Text;
			DataTable logData;

			string where = "where Time >= '" + start + " 00:00:00' and Time <= '" + end + " 23:59:59';";
			
			//Show total/Unique Logs
			logData = Database.Instance.searchDatabase("log_table", where);

			int totLogs = 0;
			int uniqueLogs = 0;
			int chkID;
			List<int> iDlist = new List<int>();

			foreach(DataRow dr in logData.Rows) {

			}

			//First Logs
			//BreakDown

		}
	}
}
