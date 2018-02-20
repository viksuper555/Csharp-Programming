using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refacture
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());
            double width;
            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());
            double heigth;
            Console.Write("Heigth: ");
            heigth = double.Parse(Console.ReadLine());
            double volume = (length + width + heigth) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);

        }
    }
}
