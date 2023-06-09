using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternary
{
    internal class rectangle
    {
        static void Main(string[] args)
        {
            //Accept length and breadth of a rectangle and find perimeter.

            double length, breadth, perimeter;
            Console.WriteLine("Enter the value of Length: ");
            length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enther the value of Breadth: ");
            breadth = Convert.ToDouble(Console.ReadLine());

            perimeter = 2 * (length + breadth);

            Console.WriteLine("\nThe perimeter of rectangle is:" + perimeter);
            Console.ReadLine();



        }
    }
}
