using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternary
{
    internal class equitriangle
    {
        //Write a program to calculate area of an equilateral triangle.
        static void Main(string[] args)
        {
            double area, side, root;

            Console.WriteLine("Enter the length of side: ");
             side = Convert.ToDouble(Console.ReadLine());

            root = (float)Math.Sqrt(3) / 4;

            area = root * side * side;

            Console.WriteLine("\nArea of an equilateral triangle is: " + area);


        }


    }
}
