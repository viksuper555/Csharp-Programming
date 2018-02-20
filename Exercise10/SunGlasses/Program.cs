using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunGlasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var row = size;

            //First row
            Console.WriteLine(
                $"{new string('*', size * 2)}" +
                $"{new string(' ', size)}" +
                $"{new string('*', size * 2)}"
                );
            //Mid row
            var middleRows = size - 2;
            var specialRow = (middleRows - 1) / 2;
            for (row = 0; row < size - 2; row++)
            {
                if (row == specialRow)
                {
                    Console.Write($"*{new string('/', (size * 2) - 2)}*");
                    Console.Write(new string('|', size));
                    Console.Write($"*{new string('/', (size * 2) - 2)}*");
                }
                else
                {
                    Console.Write($"*{new string('/', (size * 2) - 2)}*");
                    Console.Write(new string(' ', size));
                    Console.Write($"*{new string('/', (size * 2) - 2)}*");
                }
                Console.WriteLine();
            }
            //Last row
            Console.WriteLine(
                $"{new string('*', size * 2)}" +
                $"{new string(' ', size)}" +
                $"{new string('*', size * 2)}"
                );

        }
    }
}
