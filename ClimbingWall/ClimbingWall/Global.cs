using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimbingWall
{
    public enum EmployeeLevel { EMPLOYEE, MANAGER, ADMIN };
    public enum SuspendLength { SEVEN_DAYS, THIRTY_DAYS, SEMESTER, YEAR};
    public enum SuspendCode {DB_FAIL, PATRON_NOT_EXIST, SUSPEND_EXISTS, SUCCESS};
    public enum NewPatronStatus { FAIL, UPDATE, CREATED };
    public enum PatronLoginStatus { MISCERROR, PATRONNOTFOUND, WAVEREXPIRED, PATRONSUSPENDED, SUCCESS, PATRONSUSPCLEAR };
    public enum DatabaseSearchVal { EMPLOYEE, PATRON, LOGINS, SUSPENSIONS }

    public struct MailRecipient
    {
        public string address;
        public string name;
    }
    static class Constants
    {
        public const int minPasswordLength = 4;
    }

	static class Globals
	{
        public static bool useConfigFile = true;
		public static EmployeeLevel empLevel = EmployeeLevel.EMPLOYEE;
		public static int currEmployeeId = 1;
		public static string currEmployeeName = "";
        public static string DBPort = "localhost";
        public static string DBID = "root";
        public static string DBPassword = "root";
        public static string DBName = "climbing_wall";
    }
}