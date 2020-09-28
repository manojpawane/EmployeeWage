using System;

namespace CalculateDailyWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int EMP_PART_TIME = 1;
            int EMP_FULL_TIME = 2;
            int EMP_RATE_PER_HR = 20;

            int empHours = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if(empCheck == EMP_FULL_TIME)
            {
                empHours = 8;
            }
            else if(empCheck == EMP_PART_TIME)
            {
                empHours = 4;
            }
            else
            {
                empHours = 0;
            }

            empWage = empHours * EMP_RATE_PER_HR;
            Console.WriteLine("Employee Wage per hour is.."+empWage);
            Console.ReadKey();
        }
    }
}
