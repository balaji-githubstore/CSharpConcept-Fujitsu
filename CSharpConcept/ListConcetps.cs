using CSharpConcept;
using Fujitsu.CSharpConcept.Calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fujitsu.CSharpConcept
{
  

    class ListConcetps
    {
        static void Maieen(String[] args)
        {
            List<string> colors = new List<string>();
            colors.Add("red");
            colors.Add("blue");

            colors.Remove("red");
            colors.Insert(0, "orange");

            Console.WriteLine(colors[0]);
            Console.WriteLine(colors.ElementAt(0));
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            List<int> numbers = new List<int>();
            numbers.Add(10);
           
        }

    }
}
