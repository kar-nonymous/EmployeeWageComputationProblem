using System;
using System.Collections;

namespace UC2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Hashtable wagesForCompanies = new Hashtable();  // Hash table to store the wages of different companies          
            Program program = new Program();
            wagesForCompanies["Reliance"] = Program.ComputeEmpWage("Reliance", 40, 25, 100);
            wagesForCompanies["Flipkart"] = Program.ComputeEmpWage("flipkart", 60, 15, 80);
            Console.WriteLine("Type the company name to find total wages"); //Searching for wage of a company
            string searchCompany = Console.ReadLine();
            Console.WriteLine("Total wage of {0} is {1}", searchCompany, wagesForCompanies[searchCompany]);

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
}
