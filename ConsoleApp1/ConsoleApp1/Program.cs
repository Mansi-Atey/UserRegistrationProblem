using System;

namespace ConsoleApp1
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Regex regexValidation = new Regex();
            Console.WriteLine("Enter Your First Name");
            string FirstName = Console.ReadLine();
            Console.WriteLine(regexValidation.validateFirstName(FirstName));
            Console.WriteLine("Enter Your Last Name");
            string LastName = Console.ReadLine();
            Console.WriteLine(regexValidation.validateLastName(LastName));
        }
    }
}
