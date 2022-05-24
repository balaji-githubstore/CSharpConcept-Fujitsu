﻿using CSharpConcept;
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
        
        static void Main(String[] args)
        {
            int radius = 10;

            double res = Area.AreaOfCircle(10);
            Console.WriteLine(res);

            res = Area.AreaOfCircle(20);
            Console.WriteLine(res);

            double output=Area.AreaOfTriangle(10.5, 62.2);
            Console.WriteLine(output);

            double powerOutput = Math.Pow(5, 3);
            Console.WriteLine(powerOutput);

            res = Math.Sqrt(64);
            Console.WriteLine(res);
        }

    }
}
