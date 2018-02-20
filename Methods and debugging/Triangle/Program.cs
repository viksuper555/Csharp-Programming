using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                Console.Write(i + " ");
            }
        }
        static void PrintTriangle(int n)
        {
            for (int line = 1; line <= n; line++)
            {
                PrintLine(1, line);
                Console.WriteLine();
            }
            for (int line = n-1; line >= 0; line--)
            {
                PrintLine(1, line);
                Console.WriteLine();
            }
        }
    }
}
