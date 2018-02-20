using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestangleOStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int col = 0; col < n; col++)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
