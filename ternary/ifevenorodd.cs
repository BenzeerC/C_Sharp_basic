using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternary
{
    internal class ifevenorodd
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("\nEnter a number to check it's even or odd:");
            num = Convert.ToInt32(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine($"{num} is even.");
            }

           else
            {
                Console.WriteLine($"{num} is odd");
            }


        }
    }
    
}
