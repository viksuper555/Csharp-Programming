using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2_sumOfNNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                var currentnumber = int.Parse(Console.ReadLine());
                sum += currentnumber;
            }
            Console.WriteLine(sum);
        }
    }
}
