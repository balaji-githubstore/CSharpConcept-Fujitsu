using CSharpConcept;
using Fujitsu.CSharpConcept.Calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fujitsu.CSharpConcept
{
    class Program
    {
        static void Main(String[] args)
        {
            Employee e1 = Employee.GetEmployeeInstance();

            Employee e2 = Employee.GetEmployeeInstance();

            e1.PrintEmployeeDetails();
            e2.PrintEmployeeDetails();

           // Employee.DisplayEmployeeDetails(Employee.GetEmployeeInstance());

            Employee.companyName = "Fujitsu";

            Employee emp1 = new Employee();
            Employee emp2 = new Employee(); 
            Employee emp3=new Employee();

            emp1.empId = 101;
            emp1.empName = "John";
            emp1.empSalary = 8000;
           
            emp2.empId = 102;
            emp2.empName = "Peter";
            emp2.empSalary = 5000;

            Employee.DisplayEmployeeDetails(emp1);
            Employee.DisplayEmployeeDetails(emp2);
            Employee.DisplayEmployeeDetails(emp3);

            emp2.PrintEmployeeDetails();
            emp3.PrintEmployeeDetails();
            emp1.PrintEmployeeDetails();
        }

    }
}
