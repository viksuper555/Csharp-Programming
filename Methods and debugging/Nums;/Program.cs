using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nums_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }
        static void PrintSign(int n)
        {
            if(n < 0)
                Console.WriteLine("Negative");
            else if(n > 0)
                Console.WriteLine("Positive");
            else
                Console.WriteLine("Zero");
        }
    }
}
