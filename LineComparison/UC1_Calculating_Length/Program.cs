using NPOI.SS.Formula.Functions;
using System;
using static System.Math;

namespace UC1_Calculating_Length
{
    class Program
    {
        private static object num;

        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter number ");

            string num = Console.ReadLine();
            float num2 = float.Parse(num);
           float a =num2 + 1 ;
            Console.WriteLine(a);




        }

        private static int Sqrt(int num2)
        {
            throw new NotImplementedException();
        }
    }
}
