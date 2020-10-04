using System;

namespace UC12
{
    class Program
    {
        static void Main(string[] args)
        {
           
            EmpWageBuilderObject ewbObj = new EmpWageBuilderObject();
            ewbObj.AddCompanyEmpWage("Flipkart", 500, 20, 80);
            ewbObj.AddCompanyEmpWage("Amazon", 250, 20, 90);
            ewbObj.ComputeEmpWage();
        }

    }
}