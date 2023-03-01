using System.ComponentModel.DataAnnotations;

namespace UserRegistrationProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Problems using Regular Expression");

            UserValidation email = new UserValidation();

            Console.Write("Enter Your Email : ");

            string Email = Console.ReadLine();

            bool val = email.ValidateEmail(Email);

            if (val)
            {
                Console.WriteLine("Email is Valid");
            }
            else
            {
                Console.WriteLine("Invalid Email");
            }
        }
    }
}