using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3_maxN
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var greatestNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                if (greatestNumber < currentNumber)
                    greatestNumber = currentNumber;
            }
            Console.WriteLine(greatestNumber);
        }
    }
}
