using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                if (n >= 1 && n <= 100)
                {
                    Console.WriteLine(n);
                    break;
                }
            }
        }
    }
}