using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            int result = RaiseToPower(n, power);

            Console.WriteLine(result);
        }
        static int RaiseToPower(int number,int power)
        {
            int result = number;
            for (int i = 2; i <= power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
