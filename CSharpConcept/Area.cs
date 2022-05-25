using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class Area
    {
        public double AreaOfCircle(int r)
        {
            double output = 3.14 * r * r;
            return output;
        }
        public static double AreaOfTriangle(double base1,double height)
        {
            return (base1 * height) / 2;
        }

        public static string GetAuthorName()
        {
            string name = "Balaji Dinakaran";
            return name;
        }

        public static void PrintClassDescription()
        {

        }

        public static void Quit()
        {

        }
    }
}


