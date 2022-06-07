using CSharpConcept;
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
        static void Main(String[] args)
        {
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();

            keyValuePairs.Add(101, "john");
            keyValuePairs.Add(102, "king");

            //keyValuePairs.Add(102, "ggg");
            Console.WriteLine(keyValuePairs[102]);

            foreach(int key in keyValuePairs.Keys)
            {
                Console.WriteLine(key);
                Console.WriteLine(keyValuePairs[key]);
            }
        }

    }
}
