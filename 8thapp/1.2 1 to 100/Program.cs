using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_1_to_100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Latin alphabet:");

            for (var i = 'a'; i <= 'z'; i++)
            {
                Console.Write($" {i}");
            }
        }
    }
}
