using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SumOfDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var deci = 0;
            var sum = 0;
            do
            {
                deci = n % 10;
                n /= 10;

                sum += deci;
            } while (n != 0);
            Console.WriteLine(sum);
        }
    }
}
