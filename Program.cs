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
            int empCheck = random.Next(0, 3);  // 0,1,2

            int empHrs = 0;
            int empWage = 0;

            switch (empCheck)
            {
                case 1:
                    empHrs = 4;    // part time
                    break;

                case 2:
                    empHrs = 8;    // full time
                    break;

                default:
                    empHrs = 0;
                    break;
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage: " + empWage);
        }
    }
}