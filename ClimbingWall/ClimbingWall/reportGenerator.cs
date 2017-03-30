using System;
using System.Collections.Generic;
using System.IO;
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

			string outName = start + "to" + end + " Report.txt";
			saveLabel.Text = "Saved as: " + outName;
			using (StreamWriter outFile = new StreamWriter(outName)) {
				outFile.WriteLine("Report for {0} to {1}", start, end);
			}

			string where = "where Log_DateTime >= '" + start + " 00:00:00' and Log_DateTime <= '" + end + " 23:59:59';";
			
			//Show total/Unique Logs
			logData = Database.Instance.searchDatabase("log_table", where);

			int totLogs = 0;
			int uniqueLogs = 0;
			int chkID;
			List<int> iDlist = new List<int>();

			foreach(DataRow dr in logData.Rows) {
				chkID = Convert.ToInt32(dr["FK_Patron_ID"].ToString());
				totLogs++;
				if (!iDlist.Contains(chkID)) {
					iDlist.Add(chkID);
					uniqueLogs++;
				}
			}

			using (StreamWriter outFile = new StreamWriter(outName, true)) {
				outFile.WriteLine("Total Log-Ins :{0} \nUnique Log-Ins: {1}\n", totLogs, uniqueLogs);
			}


			//First Logs
			string field = "PatronID, FK_FirstLog";
			where = "Where FK_FirstLog >= '" + start + " 00:00:00' and FK_FirstLog <= '" + end + " 23:59:59';";

			logData = Database.Instance.searchDatabase("patron", field, where);
			int firstLogs = logData.Rows.Count;

			using (StreamWriter outFile = new StreamWriter(outName, true)) {
				outFile.WriteLine("First Time Log-Ins: {0}\n", firstLogs);
			}

			//BreakDown

		}
	}
}
