using System.ComponentModel.DataAnnotations;

namespace UserRegistrationProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Problems using Regular Expression");

            UserValidation validate = new UserValidation();


            validate.ClearEmail();
        }
    }
}