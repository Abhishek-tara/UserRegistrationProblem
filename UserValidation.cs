using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class UserValidation
    {
        //-------First-Name---------//
        public static string REGEX_FIRSTNAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX_FIRSTNAME);
        }

        //-------Last-Name---------//

        public static string REGEX_LASTTNAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public bool ValidateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, REGEX_LASTTNAME);
        }

        //-------Email---------//

        public const string Regex_Email = "^[a-zA-Z0-9]+([._#][a-zA-Z0-9]+)*[@][a-zA-Z]+[.][A-Za-z]{2,}([.][a-z]{2})?$";
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, Regex_Email);
        }

    }
}
