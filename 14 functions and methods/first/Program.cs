using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
           /* int n = int.Parse(Console.ReadLine());
            PrintSignOfNumber(n);
            */

            var areaOfRect = GetRectArea(5, 10);
            Console.WriteLine(areaOfRect);
        }

       /* static void PrintSignOfNumber(int number)
        {
            if(number > 0)
                Console.WriteLine("The number {0} is positive.", number);
            else if (number < 0)
                Console.WriteLine("The number {0} is negative.", number);
            else
                Console.WriteLine("The number {0} is zero.", number);


        }*/
        static double GetRectArea(double width, double height)
        {
            if (false)
            {
                var area = width * height;
                return area;
            }
            return 0;
        }
        
    }
}
