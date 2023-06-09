using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternary
{
    internal class check
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("\nEnter a age:");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine($"{age} Valid for vote.");
            }

            else
            {
                Console.WriteLine($"{age} Not valid for vote.");
            }


        }
    }

}
