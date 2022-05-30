using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    public class Employee
    {
        private int empId;
        public string empName;
        public double empSalary;
        public static string companyName;

        public Employee()
        {
            Console.WriteLine("Object Created!!");
            Console.WriteLine("Launch Browser");
        }
        public Employee(int empId)
        {
            this.empId = empId;
            Console.WriteLine("Object Created!!");
            Console.WriteLine("Launch Browser");
        }

        public Employee(int empId, string empName)
        {
            this.empId = empId;
            this.empName = empName;
            Console.WriteLine("Object Created!!");
            Console.WriteLine("Launch Browser");
        }
        public Employee(string empName, int empId)
        {
            this.empId = empId;
            this.empName = empName;
            Console.WriteLine("Object Created!!");
            Console.WriteLine("Launch Browser");
        }

        public Employee(int empId, double sal)
        {
            this.empId = empId;
            Console.WriteLine("Object Created!!");
            Console.WriteLine("Launch Browser");
        }

        public int EmpId
        {
            get
            {
                return empId;
            }
            set
            {
                if (value > 100)
                {
                    empId = value;
                }
                else
                {
                    Console.WriteLine(" Employee Id is invalid!!");
                }
            }
        }

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
            Console.WriteLine(this.empId);
            Console.WriteLine(this.empName);
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
