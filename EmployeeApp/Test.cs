using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Test
    {
        static void Main(string[] args)
        #region Initializations
        //Test Variable Initializations
        {
            int testEmpNum = 1352;
            string testEmpName = "Lorrie Martin";
            string testHireDate = "04/15/2019";
            string testJobDesc = "HR Recruiter";
            string testDept = "Human Resources";
            double testMnthSal = 4562.50;


            #endregion

            #region Object Instantiations
            //Instantiating New Object
            Banner banner = new Banner();
            Employee employee1 = new Employee();
            Employee employee2 = new Employee( 2987, "Kellie Truesdell", "12/28/2018", "Accountant", "Accounting", 4985.30);
            #endregion

            #region Setting Employee Object Data Members
            //Testing Mutators in Employee1 Employee Object by Setting Data Members
            employee1.EmployeeNum = testEmpNum;
            employee1.EmployeeName = testEmpName;
            employee1.HireDate = testHireDate;
            employee1.JobDescription = testJobDesc;
            employee1.Department = testDept;
            employee1.MonthlySalary = testMnthSal;

            #endregion


            #region Write to Console
            //Testing Both Objects by Writing them to Console

            banner.DisplayBanner();
            Console.WriteLine(employee1); 
            Console.WriteLine("\nEmployee Number: {0}" + "\nEmployee Name: {1}" +
                    "\nHire Date: {2}" + "\nJob Description: {3}" + "\nDepartment: {4}" +
                    "\nMonthly Salary: {5}",employee2.EmployeeNum, employee2.EmployeeName,
                    employee2.HireDate, employee2.JobDescription, employee2.Department, employee2.MonthlySalary);
            Console.ReadLine();
            #endregion          
        }

    }
        

}
