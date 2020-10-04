using System;

namespace UC14
{
    class Program
    {
        static void Main(string[] args)
        {
            
            EmpWageBuilderObject ewbObj = new EmpWageBuilderObject();
            ewbObj.AddCompanyEmpWage("Sap Labs", 200, 20, 100);
            ewbObj.AddCompanyEmpWage("DE Shaw", 250, 20, 70);
            ewbObj.AddCompanyEmpWage("DMart", 100, 20, 20);
            ewbObj.ComputeEmpWage();
            Console.WriteLine("Total wage for DMart is: " + ewbObj.GetTotalWage("DMart"));
        }

    }
}