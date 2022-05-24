using Fujitsu.CSharpConcept.Calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fujitsu.CSharpConcept
{
    class Demo4Grade
    {
        static void Main2(String[] args)
        {
            //allocating grade for marks
            int mark = Convert.ToInt32(Console.ReadLine());

            if(mark < 0 || mark > 100)
            {
                Console.WriteLine("invalid mark");
            }
            else if (mark >= 90)
            {
                Console.WriteLine('A');
            }
            else if (mark >= 80 && mark <= 89)
            {
                Console.WriteLine("B");
            }
            else if(mark >= 60 && mark<=79)
            {
                Console.WriteLine("C");
            }
            else if (mark >= 45 && mark <= 59)
            {
                Console.WriteLine("D");
            }
            else 
            {
                Console.WriteLine("F");
            }

            Console.ReadLine();
        }

    }
}
