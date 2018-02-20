using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edno
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            PrintDiamond(n);
        }
        static void PrintDiamond(int n)
        {
            var width = 5 * n;
            var height = 3 * n + 2;
            //FirstRow
            Console.WriteLine(
                new string('.', n) +
                new string('*', n * 3) +
                new string('.', n)
                );

            //MidSection
            for (int i = n-1; i >= 1; i--)
            {
                Console.WriteLine(new string('.',i) + "*" + new string('.', width-2-i*2) + "*" + new string('.', i));
            }
            //MidRow
            Console.WriteLine(new string('*',width));
            //BotSection
            for (int i = 1; i <= 2*n; i++)
            {
                Console.WriteLine(new string('.',i) + "*" + new string('.', width - 2* i -2) + "*" + new string('.', i));
            }
            //BotRow
            var BotStars = n - 2;
            var AllBotDots = width - BotStars;
            Console.WriteLine(new string('.',AllBotDots/2) + new string('*',BotStars) + new string('.', AllBotDots / 2));
        }
    }
}
