using System;

namespace UC6_EmpWageForMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            // int IS_FULL_TIME = 2;
            // int IS_PART_TIME = 1;
            int EMP_RATE_PER_HR = 20;
            int empHrs = 0;
            int empWage = 0;
            int MAX_EMP_DAYS = 0;
            int MAX_EMP_HRS = 100;
            int totalwrkhrs = 0;
            int totalwrkdays = 0;


            while (totalwrkdays < 20 && totalwrkhrs < MAX_EMP_HRS)
            {
                totalwrkdays++;



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
                totalwrkhrs = totalwrkhrs + empHrs;
            }
            empWage = totalwrkhrs * EMP_RATE_PER_HR;
            
            Console.WriteLine("Employee Wage " + empWage);


            Console.ReadKey();
        }
    }
}
