using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var prime = 1;
            if (n > 1)
            {
                for (int currentN = 2; currentN < n; currentN++)
                {
                    if (n % currentN == 0)
                    {
                        prime = 0;
                        break;
                    }
                }

            }
            else
                prime = 0;

            if (prime == 1)
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not Prime");

        }
    }
}
