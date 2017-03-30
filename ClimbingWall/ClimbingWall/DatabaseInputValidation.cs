using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClimbingWall
{
    public static class DatabaseInputValidation
    {
        public static bool mandatoryStringIsValid(string input, int minCharCount)
        {
            return (Regex.IsMatch(input, @"^[a-zA-Z\s.!?_@]*$") && (input.Length >= minCharCount));
        }
        public static bool nameIsValid(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z\s]*$");
        }
        public static bool stringIsValid(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z\s.!?_@]*$");
        }
        public static bool uintIsValid(string input)
        {
            return Regex.IsMatch(input, @"^[0-9]*$");
        }
        public static bool uintIsValidWithinRange(string input, int min, int max)
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
