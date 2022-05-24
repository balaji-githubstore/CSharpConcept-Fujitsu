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
        //accessmodifier static returntype methodname(arguments)
        public static double AreaOfCircle(int r)
        {
            double output = 3.14 * r * r;
            return output;
        }
        static void Main(String[] args)
        {
            int radius = 10;

            double res = Program.AreaOfCircle(10);
            Console.WriteLine(res);

            res = Program.AreaOfCircle(20);
            Console.WriteLine(res);
        }

    }
}
