using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;
            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber < 200)
                {
                    p1++;
                }
                else if (currentNumber <= 399)
                {
                    p2++;
                }
                else if (currentNumber <= 599)
                {
                    p3++;
                }
                else if (currentNumber <= 799)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }
            p1 = p1 / n * 100;
            p2 = p2 / n * 100;
            p3 = p3 / n * 100;
            p4 = p4 / n * 100;
            p5 = p5 / n * 100;
            Console.WriteLine(p1 + "%");
            Console.WriteLine(p2 + "%");
            Console.WriteLine(p3 + "%");
            Console.WriteLine(p4 + "%");
            Console.WriteLine(p5 + "%");


        }
    }
}
