using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_to_N_in_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int num = 1; num <= n; num++)
            {   
                Console.WriteLine(num);
                num *= 2;
            }
        }
    }
}
