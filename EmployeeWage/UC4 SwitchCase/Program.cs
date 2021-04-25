using System;

namespace UC4_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {


          //nt IS_FULL_TIME = 2;
          //nt IS_PART_TIME = 1;
            int EMP_RATE_PER_HR = 20;
            int empHrs = 0;
           int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case 2:

                    Console.WriteLine("Employee is Full Time");
                    empHrs = 8;

                    break;

                case 1:

                    Console.WriteLine("Employee is Part Time");
                    empHrs = 4;
                    break;

                case 0:
                    Console.WriteLine("Employee is Abscent");
                    empHrs = 0;
                    break;
            }
                    empWage = empHrs * EMP_RATE_PER_HR;
                    Console.WriteLine("Employee Wage "+ empWage);

          
                    Console.ReadKey();
            
        }
    }
}
