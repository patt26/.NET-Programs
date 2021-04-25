using System;
using System.Text.RegularExpressions;

namespace UC2ValidLastName
{
    class Program
    {
        static void Main(string[] args)
        {
            LastName pattern = new LastName();
            Console.Write("Enter Last Name- ");
            string name = Console.ReadLine();
            bool result = pattern.ValidateName(name);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
    
