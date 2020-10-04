using System;
using System.Collections.Generic;
using System.Text;

namespace UC9
{
    public class EmpWageBuilder
    {
        string company;
        int empRatePerHour;
        int numOfWorkingDays;
        int maxHrsPerMonth;
        int totalEmpWage;
        
        public EmpWageBuilder(string company, int empRatePerHour, int numOfWorkingDays, int maxHrsPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHrsPerMonth = maxHrsPerMonth;
            this.totalEmpWage = 0;
        }
        const int IS_ABSENT = 0; 
        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 2;
        public static int ComputeEmpWage()
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
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
    }
}
