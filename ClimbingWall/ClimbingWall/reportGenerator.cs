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
			where = "where FK_FirstLog >= '" + start + " 00:00:00' and FK_FirstLog <= '" + end + " 23:59:59';";

			logData = Database.Instance.searchDatabase("patron", field, where);
			int firstLogs = logData.Rows.Count;

			using (StreamWriter outFile = new StreamWriter(outName, true)) {
				outFile.WriteLine("First Time Log-Ins: {0}\n", firstLogs);
			}

			//BreakDown
			int startYear = startDate.Value.Year;
			int startMonth = startDate.Value.Month;
			int startDay = startDate.Value.Day;

			int endYear = endDate.Value.Year;
			int endMonth = endDate.Value.Month;
			int endDay = endDate.Value.Day;

			endDay++;							//Need to extend the range by one so every day gets hit.
			if (endDay == getDays(endMonth)) {
				endDay = 1;
				endMonth++;
				if (endMonth == 13) {
					endMonth = 1;
					endYear++;
				}
			} //*/

			int yearCounter = startYear;
			int monthCounter = startMonth;
			int dayCounter = startDay;

			int yearLogCount = 0;
			int monthLogCount = 0;
			int dayLogCount = 0;

			string hrStr;
			string dayStr;


			//where = "where Log_DateTime >= ' YYYY-MM-DD HH:00:00' and Log_DateTime <= ' YYYY-MM-DD HH:59:59';";
			
			using (StreamWriter outFile = new StreamWriter(outName, true)) {
				outFile.WriteLine("Breakdown\n");
			}
			while(yearCounter != endYear || monthCounter != endMonth || dayCounter != endDay) {
				for (int i = 0; i <= 22; i++) { //Each Hour
					where = "where Log_DateTime >= ' "+numToString(yearCounter)+"-"+numToString(monthCounter)+"-"+numToString(dayCounter)+" "+numToString(i)+":00:00' and Log_DateTime <= ' "+numToString(yearCounter)+"-"+numToString(monthCounter)+"-"+numToString(dayCounter)+" "+numToString(i)+":59:59';";
					hrStr = numToString(i) + ":00:00 to " + numToString(i) + ":59:59";
					logData = Database.Instance.searchDatabase("log_table", where);
					if(logData.Rows.Count != 0)
						using (StreamWriter outFile = new StreamWriter(outName, true)) {
							outFile.WriteLine("Hour {0}: {1} Log-Ins", hrStr ,logData.Rows.Count);
						}
					dayLogCount += logData.Rows.Count;
				}//Each Hour Loop end
				dayStr = getMonth(monthCounter) +" "+ dayCounter + ", "+ yearCounter;

				if(dayLogCount != 0)
				using (StreamWriter outFile = new StreamWriter(outName, true)) {
					outFile.WriteLine("{0}: {1} Log-Ins\n", dayStr, dayLogCount);
				}

				dayCounter++;
				monthLogCount += dayLogCount;
				dayLogCount = 0;

				if( dayCounter == getDays(monthCounter) + 1) {
					dayCounter = 1;
					dayStr = getMonth(monthCounter) + " " + yearCounter.ToString();


					if (monthLogCount != 0)
						using (StreamWriter outFile = new StreamWriter(outName, true)) {
						outFile.WriteLine("{0}: {1} Log-Ins\n", dayStr, monthLogCount);
					}

					monthCounter++;
					yearLogCount += monthLogCount;
					monthLogCount = 0;

					if(monthCounter == 13) {
						monthCounter = 1;

						if (yearLogCount != 0)
							using (StreamWriter outFile = new StreamWriter(outName, true)) {
							outFile.WriteLine("{0}: {1} Log-Ins\n", yearCounter, yearLogCount);
						}
						yearCounter++;
						yearLogCount = 0;
					}
				}
			}
		}

		private int getDays(int month)
		{
			switch (month) {
				case (1):
					return 31;
				case (2):
					return 28;
				case (3):
					return 31;
				case (4):
					return 30;
				case (5):
					return 31;
				case (6):
					return 30;
				case (7):
					return 31;
				case (8):
					return 31;
				case (9):
					return 30;
				case (10):
					return 31;
				case (11):
					return 30;
				case (12):
					return 31;
				default:
					return 30;
			}

		}

		private string numToString(int num)
		{
			if (num <= 9) {
				return "0" + num.ToString();
			}
			else
				return num.ToString();
		}

		private string getMonth(int month)
		{
			switch (month) {
				case (1):
					return "January";
				case (2):
					return "February";
				case (3):
					return "March";
				case (4):
					return "April";
				case (5):
					return "May";
				case (6):
					return "June";
				case (7):
					return "July";
				case (8):
					return "August";
				case (9):
					return "September";
				case (10):
					return "October";
				case (11):
					return "November";
				case (12):
					return "December";
				default:
					return "Smarch";
			}
		}
	}
}
