using Fujitsu.CSharpConcept.Calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fujitsu.CSharpConcept
{
    class Demo2Array
    {
        static void Main1(String[] args)
        {
            //10, 20, 30, 40, 50
            int[] numbers = new int[5]; //5*32 bits of memory

            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;


            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            //Create a String array for storing values red, green, yellow
            string[] colors=new string[3];
            colors[0] = "red";
            colors[1]= "yellow";
            colors[2] = "green";

            Console.WriteLine(colors[2]);

            String[] fruits = { "apple", "mango", "orange","jackfruit" };
            Console.WriteLine(fruits[2]);

            int size=fruits.Length;
            Console.WriteLine(size);

            Console.WriteLine(numbers);
            Console.WriteLine(colors);
            Console.WriteLine(fruits);
        }

    } 
}
