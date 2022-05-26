using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class Employee
    {
        
        public string empName;
        public double empSalary;
        public static string companyName;

        private int empId;
        public int EmpId
        {
            get 
            { 
                return empId; 
            }
            set { 
                if(value>100)
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
            Console.WriteLine(empId);
            Console.WriteLine(empName);
            Console.WriteLine(empSalary);
            Console.WriteLine(Employee.companyName);
            Console.WriteLine("------------------------");
        }

        //public static Employee GetEmployeeInstance()
        //{
        //    Employee emp = new Employee();
        //    return emp;
        //}
    }
}
