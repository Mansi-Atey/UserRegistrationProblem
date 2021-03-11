using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regexValidation = new Regex();
            Console.WriteLine("Enter Your First Name");
            string FirstName = Console.ReadLine();
            Console.WriteLine(regexValidation.validateFirstName(FirstName));
        }
    }
}
