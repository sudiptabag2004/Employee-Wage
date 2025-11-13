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

            int MAX_HRS_IN_MONTH = 100;
            int NUM_OF_WORKING_DAYS = 20;

            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            Random random = new Random();

            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                int empHrs = 0;

                int empCheck = random.Next(0, 3); // 0,1,2

                switch (empCheck)
                {
                    case 1:
                        empHrs = 4;  // part-time
                        break;

                    case 2:
                        empHrs = 8;  // full-time
                        break;

                    default:
                        empHrs = 0;  // absent
                        break;
                }

                totalEmpHrs += empHrs;
            }

            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Working Days: " + totalWorkingDays);
            Console.WriteLine("Total Hours: " + totalEmpHrs);
            Console.WriteLine("Total Employee Wage: " + totalEmpWage);
        }
    }
}