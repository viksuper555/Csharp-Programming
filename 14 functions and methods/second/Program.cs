using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second
{
    class Program
    {
        static void Main(string[] args)
        {
            var side = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            GetTriangleArea(side, height);
            Console.WriteLine($"Area: {GetTriangleArea(side, height)}");
        }
        static double GetTriangleArea(double side, double height)
        {
            var area = side * height / 2;

            return area;
        }
    }
}
