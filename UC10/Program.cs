using System;

namespace UC10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            EmpWageBuilderObject ewbObj = new EmpWageBuilderObject();
            ewbObj.AddCompanyEmpWage("Flipkart", 200, 20, 100);
            ewbObj.AddCompanyEmpWage("Amazon", 250, 20, 70);
            ewbObj.ComputeEmpWage();
        }

    }
}