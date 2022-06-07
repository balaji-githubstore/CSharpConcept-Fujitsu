//using CSharpConcept;
//using Fujitsu.CSharpConcept.Calc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Fujitsu.CSharpConcept
//{
//    abstract class Emp
//    {
//        public int empId;
//        public String empName;
//        public double salary;

//        public string GetName(int empId)
//        {
//            return "name of the employee";
//        }
//        public string GetAddress(int empId)
//        {
//            return "address";
//        }
//        public abstract double CalculateSalary();
//    }

//    class ConEmp : Emp
//    {
//        public override double CalculateSalary()
//        {
//            return 8 * 300;
//        }
//    }
//    class PerEmp : Emp
//    {
//        public override double CalculateSalary()
//        {
//            return 30 * 20;
//        }
//    }

//    class XX : Emp
//    {
//        public override double CalculateSalary()
//        {
//            return 9 * 9;
//        }
//    }
//    class Programss
//    {
//        public static void PayRoll(Emp e)
//        {
//            Console.WriteLine(e.empName);
//        }
//        static void Mainss(String[] args)
//        {
//            Emp e = new ConEmp();
//            Console.WriteLine(e.empId);
//            Console.WriteLine(e.GetName(10));
//            Console.WriteLine(e.CalculateSalary());  //runtime 

//            Program.PayRoll(e);

//            e =new PerEmp();
//            Console.WriteLine(e.CalculateSalary());

//            Program.PayRoll(e);
//        }

//    }
//}
