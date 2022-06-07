using CSharpConcept;
using Fujitsu.CSharpConcept.Calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fujitsu.CSharpConcept
{
    class Programww
    {
        static void Mainww(String[] args)
        {
            Calculator cal = new Calculator();

            cal.Add(1, 1);

            Console.WriteLine(5);

            double maxValue=Math.Max(10, 50.2);
            Console.WriteLine(maxValue);

          //  var e1 = Employee.GetEmployeeInstance();

            //Employee e2 = Employee.GetEmployeeInstance();

            //e1.PrintEmployeeDetails();
            //e2.PrintEmployeeDetails();

            // Employee.DisplayEmployeeDetails(Employee.GetEmployeeInstance());

            Employee.companyName = "Fujitsu";

            Employee emp1 = new Employee();
            Employee emp2 = new Employee(102, "Peter"); 
            Employee emp3=new Employee(103,5.2);

            emp1.EmpId = 150; //set 
            emp1.empName = "John";
            emp1.empSalary = 8000;

            emp2.EmpId = 102;
            emp2.empName = "Peter";
            emp2.empSalary = 5000;

            Console.WriteLine(emp1.EmpId);

            Employee.DisplayEmployeeDetails(emp1);
            Employee.DisplayEmployeeDetails(emp2);
            Employee.DisplayEmployeeDetails(emp3);

            emp2.PrintEmployeeDetails();
            emp3.PrintEmployeeDetails();
            emp1.PrintEmployeeDetails();

            //var a = "10.2"; //a is register for double
            //a = "balaji";
            //a = 10;

            //dynamic b = 10.2;
            //b = 10;
            //b = "ddd";

        }

    }
}
