using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternary
{
    internal class divisible
    {
        //Write a C# program to check whether a number is divisible by 5 and 11 or not 
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if ((num % 5 == 0) && (num % 11 == 0))
            {
                Console.WriteLine("\nNumber is divisible by 5 & 11.");
            }
            else
            {
                Console.WriteLine("\n Number is not divisible by 5 & 11.");
            }
        }


    }
}
