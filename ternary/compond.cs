using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternary
{
    internal class compond
    {
        //Write a  program to enter P, T, R and calculate Compound Interest.
        static void Main(string[] args)
        {
            int n, t; // n- year, t-time
            double ci, amount, p, r;// ci-compond interest amount-value p-principal r-rate

            Console.WriteLine("Enter the principal: ");
            p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter the Rate: ");
            r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter compond year: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the year: ");
            t = Convert.ToInt32(Console.ReadLine());

            // compond value

            amount = p * Math.Pow((1 + r / (100 * n)), n * t);

            //Find the compound interest
            ci = amount - p;

            Console.WriteLine("\nCompound interest: " + ci);
        }
    }
}
