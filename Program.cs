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
            int NUM_OF_WORKING_DAYS = 20;

            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            Random random = new Random();

            for (int day = 1; day <= NUM_OF_WORKING_DAYS; day++)
            {
                int empCheck = random.Next(0, 3); // 0,1,2

                switch (empCheck)
                {
                    case 1:
                        empHrs = 4;   // part-time
                        break;

                    case 2:
                        empHrs = 8;   // full-time
                        break;

                    default:
                        empHrs = 0;   // absent
                        break;
                }

                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
            }

            Console.WriteLine("Total Employee Wage for 20 Days: " + totalEmpWage);
        }
    }
}