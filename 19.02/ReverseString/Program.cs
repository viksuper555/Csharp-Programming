using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(ReverseString(input));
        }
        static string ReverseString(string str)
        {
            // string result = "";
            StringBuilder sb = new StringBuilder(50);
            for (int i = str.Length -1 ; i >= 0; i--)
            {
                sb.Append(str[i]);
             //   result += str[i];
            }

            sb[0] = 'B';
            return sb.ToString();
        }
    }
}
