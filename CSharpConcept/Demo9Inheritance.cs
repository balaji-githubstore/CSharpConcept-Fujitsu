using CSharpConcept;
using Fujitsu.CSharpConcept.Calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fujitsu.CSharpConcept
{

    class Father
    {
        public int fAge;

        public Father(int fatherAge)
        {
            this.fAge = fatherAge;
            Console.WriteLine("Father Constructor");
        }

        public void FatherStyle()
        {
            Console.WriteLine("Father Style");
        }
    }

    class Son : Father
    {
        public int sAge;
        public Son(int fAge,int sAge):base(fAge)
        {
            this.sAge = sAge;
            Console.WriteLine("Son Constructor");
           
        }
        public void SonStyle()
        {
            Console.WriteLine("Son Style");
        }
    }

    class Program22
    {
        static void Main22(String[] args)
        {
            //Father father = new Father();   
            //father.FatherStyle();
            //Console.WriteLine(father.fAge);

            Son son = new Son(68,30);
            Console.WriteLine(son.fAge);
            Console.WriteLine(son.sAge);

            son.SonStyle();
            son.FatherStyle();

        }

    }
}
