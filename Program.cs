using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;

            Random random = new Random();
            int empCheck = random.Next(0, 3); // 0, 1, or 2

            int empHrs = 0;
            int empWage = 0;

            if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;   // as per UC3
            }
            else if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;   // as per UC3
            }
            else
            {
                empHrs = 0;
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;

            Console.WriteLine("Employee Wage: " + empWage);
        }
    }
}