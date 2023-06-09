using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ternary
{
    internal class triangle
    {
        //Accept two angles of triangle and find third angle.
        static void Main(string[] args)
        {
            int ang1, ang2, ang3;
            Console.WriteLine("Enter the value of 1st angle: ");
            ang1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the value of 2nd angle: ");
            ang2 = Convert.ToInt32(Console.ReadLine());

            ang3 = 180 - (ang1 + ang2);
            Console.WriteLine("\nThird angle of the tringle is:" + ang3);
            //Console.WriteLine($"\n{ang3} Third angle of the tringle is:");
        }


      
    }
}
