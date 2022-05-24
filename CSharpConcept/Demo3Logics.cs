using Fujitsu.CSharpConcept.Calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fujitsu.CSharpConcept
{
    class Demo3Logics
    {
        static void Main1w(String[] args)
        {
            String input = Console.ReadLine();
            int res = Convert.ToInt32(input);
            Console.WriteLine(res + res);
            int mark = 75; 

            int num = 0;

            if(num<0)
            {
                Console.WriteLine("It's Negative:"+num);
            }
            else if(num==0)
            {
                Console.WriteLine("It's zero");
            }
            else
            {
                Console.WriteLine("It's positive:"+num);
            }

            int pageNum = 150;

            if(pageNum>100)
            {
                if(pageNum<200)
                {
                    Console.WriteLine("between 100 and 200");
                }
            }

            if(pageNum > 100 && pageNum < 200)
            {
                Console.WriteLine("between 100 and 200");
            }

            string browser = "CH";

            if(browser=="ch" || browser=="CH")
            {
                Console.WriteLine("launch chrome");
            }
            else
            {
                Console.WriteLine("launch edge");
            }
        }

    } 
}
