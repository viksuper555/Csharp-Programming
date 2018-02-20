using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2NoOstatuk
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n;
            int heaight = n;
            //top
            int hutsSize = n / 2;
            string huts = new string('^', hutsSize);
            string roof = new string('_', width - hutsSize * 2 - 4);
            Console.WriteLine($"/{huts}\\{roof}/{huts}\\");
            //mid
            for (int i = 1; i <= n-2; i++)
            {
                if(i != n - 2)
                    Console.WriteLine("|" + new string(' ', width - 2) + "|");
                else
                    Console.WriteLine($"|" + new string(' ', hutsSize + 1) + roof + new string(' ', hutsSize + 1) + "|");
            }
            //bot
            Console.WriteLine($"\\{new string('_', hutsSize)}/{new string(' ', width - hutsSize * 2 - 4)}\\{new string('_', hutsSize)}/");
        }
    }
}
