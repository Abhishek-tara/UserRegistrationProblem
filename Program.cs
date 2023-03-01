using System.ComponentModel.DataAnnotations;

namespace UserRegistrationProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Problems using Regular Expression");

            UserValidation mobileNumber = new UserValidation();

            Console.Write("Enter Your mobileNumber : ");

            string number = Console.ReadLine();

            bool val = mobileNumber.ValidateMobileNumber(number);

            if (val)
            {
                Console.WriteLine("mobileNumber is Valid");
            }
            else
            {
                Console.WriteLine("Invalid mobileNumber");
            }
        }
    }
}