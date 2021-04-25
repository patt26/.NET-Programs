using System;


namespace UC1UserName
{
   public class Program
    {
      public static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.Write("Enter First Name- ");
            string name = Console.ReadLine();
            bool result = pattern.ValidateName(name);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
