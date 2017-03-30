using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClimbingWall
{
    public class DatabaseInputValidation
    {
        private static DatabaseInputValidation instance;
        public static DatabaseInputValidation Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseInputValidation();
                }
                return instance;
            }
        }
        public bool nameIsValid(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z\s]*$");
        }
        public bool stringIsValid(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z\s.!?_@]*$");
        }
        public bool uintIsValid(string input)
        {
            return Regex.IsMatch(input, @"^[0-9]*$*$");
        }
        public bool uintIsValidWithinRange(string input, int min, int max)
        {
            bool valid = false;
            if (Regex.IsMatch(input, @"^[0-9]+$"))
            {
                int testInt = Int32.Parse(input);
                if (testInt >= min && testInt <= max)
                {
                    valid = true;
                }
            }
            else if (Regex.IsMatch(input, @"^[0-9]*$*$")) //allow empty params
            {
                valid = true;
            }
            return valid;
        }
    }
}
