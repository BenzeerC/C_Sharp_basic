using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternary
{
    internal class evenorodd
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("\nEnter a number to check it's even or odd:");
            num = Convert.ToInt32(Console.ReadLine());

            string result = (num % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(result);
        }
    }
}
