using System;

namespace UC2
{
    class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
       // public const int EMP_RATE_PER_HOUR = 20;
       // public const int NUM_OF_WORKING_DAYS = 20;
       // public const int MAX_HRS_IN_MONTH = 100;
        public static int ComputeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHrsPerMonth)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            int totalEmpWage = 0;
            while (totalEmpHrs <= maxHrsPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day: " + totalWorkingDays + " Emp hours: " + empHrs);
            }
            totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total emp wage for company: " + company + " is: " + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {

            ComputeEmpWage("Flipkart", 20, 20,50);
            ComputeEmpWage("Amazon", 20, 50, 10);
            ComputeEmpWage("Google", 10, 20, 30);
           

        }
    }
}
