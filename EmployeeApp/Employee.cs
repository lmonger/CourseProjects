using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp

{
    class Employee
    {
        #region Data Members
        private int empNum;         //Employee Number Format: XXXX
        private string empName;    //Employee Name Format: First Last
        private string hireDate;    //Hire Date Format: MM/DD/YYYY
        private string jobDesc;     //Job Description Format: Accountant, Marketer, HR Recruiter etc.
        private string dept;        //Department Format: Accounting, Marketing, Human Resources etc.
        private double mnthSal;     //Monthly Salary Format: XXXX.XX
        #endregion


        #region Constructors

        public Employee() { }

        public Employee(int empNum1, string empName1, string hireDate1, string jobDesc1, string dept1, double mnthSal1)

        {
            empNum = empNum1; 
            empName = empName1; 
            hireDate = hireDate1;
            jobDesc = jobDesc1;
            dept = dept1;
            mnthSal = mnthSal1;
        }

        #endregion

        #region Accessor/Mutators
        public int EmployeeNum
        {
            get { return empNum; }
            set { empNum = value; }
        }

        public string EmployeeName
        {
            get { return empName; }
            set { empName = value; }
        }

        public string HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }

        public string JobDescription
        {
            get { return jobDesc; }
            set { jobDesc = value; }
        }

        public string Department
        {
            get { return dept; }
            set { dept = value; }
        }

        public double MonthlySalary
        {
            get { return mnthSal; }
            set { mnthSal = value; }
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return "\nEmployee Number: " + empNum + "\nEmployee Name: " + empName +
                    "\nHire Date: " + hireDate + "\nJob Description: " + jobDesc +
                    "\nDepartment: " + dept + "\nMonthly Salary: " + mnthSal;
        }

        #endregion
    }
}

