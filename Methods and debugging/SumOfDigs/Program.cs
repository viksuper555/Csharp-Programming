using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);
            int evens = GetSumOfEvenDigits(n);
            int odds = GetSumOfOddDigits(n);
            int multi = GetSumOfEvensAndOdds(evens, odds);
            Console.WriteLine(multi);
        }
        static int GetSumOfEvensAndOdds(int evens,int odds)
        {
            return evens * odds;
        }
        static int GetSumOfEvenDigits(int n)
        {
            int sum = 0,m;
            do
            {
                m = n % 10;
                if (m % 2 == 0)
                    sum += m;
                n /= 10;
                
            } while (n > 0);
            return sum;
        }
        static int GetSumOfOddDigits(int n)
        {
            int sum = 0, m;
            do
            {
                m = n % 10;
                if (m % 2 != 0)
                    sum += m;
                n /= 10;

            } while (n > 0);
            return sum;
        }
    }
}
