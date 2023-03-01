using System.ComponentModel.DataAnnotations;

namespace UserRegistrationProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Problems using Regular Expression");

            ValidFirstname firstname = new ValidFirstname();

            Console.Write("Enter Your First Name : ");

            string FirstName = Console.ReadLine();

            bool val = firstname.ValidateFirstName(FirstName);

            if (val)
            {
                Console.WriteLine("FirstName is Valid");
            }
            else
            {
                Console.WriteLine("Invalid FirstName");
            }
        }
    }
}