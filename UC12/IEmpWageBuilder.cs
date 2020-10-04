using System;
using System.Collections.Generic;
using System.Text;

namespace UC12
{
    interface IEmpWageBuilderObject
    {
        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxWorkingHours);
        public void ComputeEmpWage();
    }
}