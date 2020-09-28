using System;

namespace EmployeeWageProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int FULL_TIME = 1;
            int empWagePerHour = 20;
            int empHours = 0;
            int totalWage = 0;
            Random random = new Random();

            int empCheck = random.Next(0, 2);
            if(empCheck == FULL_TIME)
            {
                empHours = 8;
            }
            else
            {
                empHours = 0;
            }
            totalWage = empHours * empWagePerHour;
            Console.WriteLine("Total Wage.. "+totalWage);
            Console.ReadKey();
        }
    }
}
