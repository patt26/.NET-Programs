using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System;

namespace UC1_LineLength
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Start Points of Line");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter End Points of Line");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            float Length = (float)Math.Pow(x2 - x1, 2) + (float)Math.Pow(y2 - y1, 2);
            float finalLength = (float)Math.Sqrt(Length);

            Console.WriteLine("Length of Line =" + finalLength);
        }
    }
}
           
