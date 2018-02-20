using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5PassGen
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            string all = "";
            for (int first = 1; first < n; first++)
            {
                for (int second = 1; second < n; second++)
                {
                    for (char firstChar = 'a'; firstChar < 'a' + l; firstChar++)
                    {
                        for (char secondChar = 'a'; secondChar < 'a' + l; secondChar++)
                        {
                            
                            for (int last = Math.Max(first, second) + 1; last <= n; last++)
                            {
                                all += $"{first}{second}{firstChar}{secondChar}{last} ";
                            }
                        }
                    }
                }
            }
            Console.WriteLine(all);
        }
    }
}
