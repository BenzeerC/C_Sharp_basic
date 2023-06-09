using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternary
{
    internal class temperature
    {
        //Write a program to enter temperature in °Celsius and convert it into °Fahrenheit.
        static void Main(string[] args)
        {
            float cel, fahr;

            Console.WriteLine("Enter the Celsius: ");
            cel = Convert.ToSingle(Console.ReadLine());

            fahr = ((cel * 9) / 5) + 32;
            Console.WriteLine("\nTemperature in Fahrenheit is: " + fahr);

        }
    }
}
