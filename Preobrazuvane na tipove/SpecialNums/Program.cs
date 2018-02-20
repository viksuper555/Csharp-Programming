using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int currentNum = i;
                int sum = 0;
                while(currentNum > 0)
                {
                    sum += currentNum % 10;
                    currentNum /= 10;
                }
                bool sumOfDigitsIsOk = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {sumOfDigitsIsOk}");
            }
        }
    }
}
