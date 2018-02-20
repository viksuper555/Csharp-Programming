using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] var = word.ToArray();
            char[] var2 = new char[100];
            for (int i = var.Length-1; i >= 0; i--)
            {
                int index = var.Length - i-1;
                var2[index] = var[i];
            }
            var2.ToString();
            Console.WriteLine(var2);

        }
    }
}
