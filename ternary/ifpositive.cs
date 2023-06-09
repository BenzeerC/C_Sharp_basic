using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternary
{
    internal class ifpositive
    {
        static void Main(string[] args)
        {
            //WAP to accept a number from user & find number is +ve or -ve number

            int num;
            Console.WriteLine("\nEnter any number: ");
            num = Convert.ToInt32(Console.ReadLine());

           if(num > 0) 
            {
                Console.WriteLine($"{num} is Positive.");
            }
           else
            {
                Console.WriteLine($"{num} is Negative");
            }

        }
    }
}
