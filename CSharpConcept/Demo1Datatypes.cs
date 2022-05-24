using Fujitsu.CSharpConcept.Calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fujitsu.CSharpConcept
{
    class Demo1
    {
        static void Main123(String[] args)
        {
            //worked on datatypes
            //created by bala
            int a = 100; //a is reserved for int (32bits) ;

            sbyte b = 127;//8 bits

            int z = b; //8 bits to 32 bits // implicit conversion // no data loss

            byte c = 100; //8 bits

            uint d = 100; //32 bits

            long e = 19L;

            //1000 students
            //sbyte,byte - 1000* 8 bits = 8000 bits of memory
            //int,uint -- 1000*32bits = 32000 bits of memory  
            float f = 1.123456789f;
            double g = 1.123456789;

            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(22.0/7);
            
            char letter = 'R';
            Console.WriteLine(letter);

            bool check = true;

            double x1 = f; //32 bit to 64 bits //implicit conversion 

            double d1 = 10.233434343344334;

            float x2 = (float) d1; //64 bit to 32 bit //explicit conversion//might lead to data loss

            Console.WriteLine(x2);

            int d2 = (int)d1;
            Console.WriteLine(d2);

            String name = "balaji"; //6*16 bits of memory 
            Console.WriteLine(name);

            Console.WriteLine(name.ToUpper());
           // Console.WriteLine(name.ElementAt(10));

           String input= Console.ReadLine();
            Console.WriteLine(input);
        }

    } 
}
