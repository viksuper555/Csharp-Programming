using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latino
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int first = 'a'; first < 'a' + n; first++)
            {
                for (int second = 'a'; second < 'a' + n; second++)
                {
                    for (int third = 'a'; third < 'a' + n; third++)
                    {
                        Console.WriteLine($"{(char)first}{(char)second}{(char)third}");
                    }
                }
            }
        }
    }
}
