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
        static void Main (String[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90,100 };

            //0 to 7,
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            Console.WriteLine("---------------------");
            //print the value which are greater than or equal to 50
            foreach(int val in numbers)
            {
                if(val==50)
                {
                    Console.WriteLine(val);
                    break;
                }
            }

        }

    }
}
