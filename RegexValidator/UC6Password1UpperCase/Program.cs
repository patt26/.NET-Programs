using System;

namespace UC6Password1UpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Password pattern = new Password();
            Console.Write("Enter Password - ");
            string name = Console.ReadLine();
            bool result = pattern.Validate(name);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
