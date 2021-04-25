using System;

namespace UC3ValidEmailId
{
    
    class pattern
    {
        static void Main(string[] args)
        {
            EmailId pattern = new EmailId();
            Console.Write("Enter Email ID - ");
            string name = Console.ReadLine();
            bool result = pattern.ValidateName(name);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

}
