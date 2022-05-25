using CSharpConcept;
using Fujitsu.CSharpConcept.Calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fujitsu.CSharpConcept
{
    class Program1
    {
        public static int aS = 10; //static variable or class variable 
        public static int bS = 20;
        public int aNS = 10; //non-static variable or instance variable 
        public int bNS = 20;

        static void Mainww(String[] args)
        {
            Program1.aS = 8000;
            Console.WriteLine(Program1.aS);
            Console.WriteLine(Program1.bS);

            Program1 p1 = new Program1(); //instance


            Program1 p2 = new Program1(); //instance 

            p1.aNS = 5000;
            p1.bNS = 6000;
            
            Console.WriteLine(p1.aNS);
            Console.WriteLine(p1.bNS);

            Console.WriteLine(p2.aNS);
            Console.WriteLine(p2.bNS);
        }

    }
}
