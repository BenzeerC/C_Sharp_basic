using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ternary
{
    internal class marks
    {
        //Write a program to enter marks of five subjects and calculate total, average and percentage.
        static void Main(string[] args)
        {
            int sub1, sub2, sub3, sub4, sub5, total;
            float average;
            double   percentage ;

            Console.WriteLine("Enter English Marks: ");
            sub1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter Math Marks: ");
            sub2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter Science Marks: ");
            sub3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter SST Marks: ");
            sub4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter ICT Marks: ");
            sub5 = Convert.ToInt32(Console.ReadLine());

            total = sub1 + sub2 + sub3 + sub4 + sub5;
            Console.WriteLine("\nTotal marks of five subject is:" + total);

            average = total / 5;
            Console.WriteLine("\nAverage Marks: " + average);

            percentage = (total / 500.0) * 100;
            Console.WriteLine("\nPercentage: " + percentage);

        }

        

        

    }
}
