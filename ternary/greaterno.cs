using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternary
{
    internal class greaterno
    {
        //Accept two numbers & find the greater number.
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter the 1st no: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the 2nd no:");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {

                Console.WriteLine("1st no is the greater no:" + num1);
            }

            else
            {
                Console.WriteLine("2nd no is the greater no:" + num2);
            }
            

        }
    }
}
