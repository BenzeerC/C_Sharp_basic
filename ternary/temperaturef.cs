using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternary
{
    internal class temperaturef
    {
        //Write a  program to enter temperature in Fahrenheit(°F) and convert it into Celsius(°C)
        static void Main(string[] args)
        {
            float cel, fahr;

            Console.WriteLine("Enter the Fahrenheit : ");
            fahr = Convert.ToSingle(Console.ReadLine());

            cel = (fahr - 2) * 5 / 9;
            Console.WriteLine("\nTemperature in Celsius is: " + cel);
        }
    }
}
