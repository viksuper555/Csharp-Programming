using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int deci = n[0];
            int number = n[1];
            Console.WriteLine(number);
            Console.WriteLine(deci);
            string result = "";
            while (number > 0)
            {
                result += Convert.ToString(number % deci);
                number /= deci;
            }
            char[] arr = result.ToArray();
            Array.Reverse(arr);
            Console.WriteLine(arr);
        }
    }
}
