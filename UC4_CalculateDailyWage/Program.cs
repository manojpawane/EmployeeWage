using System;

namespace UC4_CalculateDailyWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Use case 4");
           const int EMP_PART_TIME = 1;
           const int EMP_FULL_TIME = 2;
            int EMP_RATE_PER_HR = 20;
                                  
            int empHours = 0;     
            int empWage = 0;      
                                  
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch(empCheck)
            {
                case EMP_FULL_TIME:
                    empHours = 8;
                    break;
                case EMP_PART_TIME:
                    empHours = 4;
                    break;
                default:
                    empHours = 0;
                    break;
            }

            empWage = empHours * EMP_RATE_PER_HR;
            Console.WriteLine("Employee Wage per hour is.." + empWage);
            Console.ReadKey();
        }
    }
}
