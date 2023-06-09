using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternary
{
    internal class leapyear
    {
        //Write a program to check whether a year is leap year or not
        static void Main(string[] args)
        {
            int year;

            Console.WriteLine("Enter a year:");
            year = Convert.ToInt32(Console.ReadLine());

            if((year % 4  == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"\n{year}is leap year.", year);

            }
            else
            {
                Console.WriteLine($"\n{year} is not a leap year.", year);
            }
        }

    }
}
