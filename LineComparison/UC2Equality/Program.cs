using System;

namespace UC2Equality
{
    class Program 
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Points of 1st Line");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("X1=" + x1);

            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y1=" + y1);

            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("X2=" + x2);

            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y2=" + y2);

            Console.WriteLine("Enter Points of 2nd Line");

            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("X'1=" + x3);

            double y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y'1=" + y3);

            double x4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("X'2=" + x4);

            double y4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y'2=" + y4);



            float Length1 = (float)Math.Pow(x2 - x1, 2) + (float)Math.Pow(y2 - y1, 2);
            float finalLength = (float)Math.Sqrt(Length1);

            float Length2 = (float)Math.Pow(x4 - x3, 2) + (float)Math.Pow(y4 - y3, 2);
            float finalLength2 = (float)Math.Sqrt(Length2);


            Console.WriteLine("Length of 1st  Line =" + finalLength);
            Console.WriteLine("Length of 2nd Line =" + finalLength2);
            
           /* if (finalLength == finalLength2)
            {
                Console.WriteLine("Two Lines are equal");
            }

            else
            {
                Console.WriteLine("The Lines are not equal");
            }*/

            

        }
    }
}
