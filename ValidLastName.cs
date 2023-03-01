using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class ValidLastName
    {
        public static string REGEX_FIRSTNAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX_FIRSTNAME);
        }


        public static string REGEX_LASTTNAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public bool ValidateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, REGEX_LASTTNAME);
        }

    }
}
