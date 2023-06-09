using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternary
{
    internal class areaofcircle
    {
        static void Main(string[] args)
        {
            //Accept radius of a circle. Display area of a circle.

            double r, area;
            Console.WriteLine("Enter radius:");
             r = Convert.ToDouble(Console.ReadLine());
             area = Math.PI * r * r;
            Console.WriteLine("\nArea of circle is:" + area);
        }
    }
}
