using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public const string Regex_Email = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, Regex_Email);
        }

        ////------Mobile-Number-----////

        public const string Regex_MobileNumber = "^[0-9]{1,2}[ ][0-9]{10}$";
        public bool ValidateMobileNumber(string MobNum)
        {
            return Regex.IsMatch(MobNum, Regex_MobileNumber);
        }

        ////--------Password-Rule-4-------///

        public const string Regex_password = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[&%$#@^*!~]).{8,}$";
        public bool ValidatePassword(string Password)
        {
            return Regex.IsMatch(Password, Regex_password);
        }


        //----------Clear-Email-samples------------//

        public void ClearEmail()
        {
            UserValidation validate = new UserValidation();
            Console.WriteLine("A. Valid Emails: ");
            string[] validEmails = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc+100@gmail.com" };
            for (int i = 0; i < validEmails.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + validEmails[i] + " : " + validate.ValidateEmail(validEmails[i]));
            }
            Console.WriteLine("\nB. Invalid Emails: ");
            string[] invalidEmails = { "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc..2002@gmail.com", "abc.@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
            for (int i = 0; i < invalidEmails.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + invalidEmails[i] + " : " + validate.ValidateEmail(invalidEmails[i]));
            }
        }
    }
}
