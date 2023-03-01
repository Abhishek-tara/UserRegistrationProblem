using System.ComponentModel.DataAnnotations;

namespace UserRegistrationProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Problems using Regular Expression");

            ValidLastName lastName = new ValidLastName();

            Console.Write("Enter Your Last Name : ");

            string LastName = Console.ReadLine();

            bool val = lastName.ValidateFirstName(LastName);

            if (val)
            {
                Console.WriteLine("LastName is Valid");
            }
            else
            {
                Console.WriteLine("Invalid LastName");
            }
        }
    }
}