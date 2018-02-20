using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_Karate
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var sb = new StringBuilder(100);
            sb.Append(input);

            for (int i = 0; i < sb.Length; i++)
            {
                int power = 0;
                if (sb[i] == '>')
                {
                    i++;
                    power = sb[i];
                    sb.Remove(i, power);
                }
            }
            Console.WriteLine(sb);

        }
    }
}
