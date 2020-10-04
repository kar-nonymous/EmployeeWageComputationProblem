using System;
using System.Collections.Generic;
using System.Text;

namespace UC12
{
    class CompanyWageDetails
    {
        public string company;
        public int empRatePerHour, numOfWorkingDays, maxWorkingHours;
        public int totalEmpWage;

        public CompanyWageDetails(string company, int empRatePerHour, int numOfWorkingDays, int maxWorkingHours)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxWorkingHours = maxWorkingHours;
            this.totalEmpWage = 0;
        }

        public void GetDetails()
        {
            
            Console.WriteLine("Total Wage for " + company + " Employee is: " + totalEmpWage);
            
        }
    }
}