using System;
using System.Text.RegularExpressions;

namespace UC4MobileNumber
{
    class pattern
    {
        static void Main(string[] args)
        {
            PhoneNum pattern = new PhoneNum();
            Console.Write("Enter Mobile Number - ");
            string name = Console.ReadLine();
            bool result = pattern.ValidateName(name);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
