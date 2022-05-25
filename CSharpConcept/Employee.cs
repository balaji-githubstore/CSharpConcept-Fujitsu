using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class Employee
    {
        public int empId;
        public string empName;
        public double empSalary;
        public static string companyName;

        public static void DisplayEmployeeDetails(Employee e)
        {
            Console.WriteLine(e.empId);
            Console.WriteLine(e.empName);
            Console.WriteLine(e.empSalary);
            Console.WriteLine(Employee.companyName);
            Console.WriteLine("------------------------");
        }

        public void PrintEmployeeDetails()
        {
            Console.WriteLine(empId);
            Console.WriteLine(empName);
            Console.WriteLine(empSalary);
            Console.WriteLine(Employee.companyName);
            Console.WriteLine("------------------------");
        }

        public static Employee GetEmployeeInstance()
        {
            Employee emp = new Employee();
            return emp;
        }
    }
}
