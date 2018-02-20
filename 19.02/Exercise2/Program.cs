using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string key = "";
            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i] >= '0' && input[i] <= '9')
                {
                    key = "";
                    int j = i;
                    i++;
                    for (; input[j] >= '0' && input[j] <= '9'; j++)
                    {
                        key += input[j];
                    }
                    char a = input[j + 1];
                    input.Replace(key, a.ToString());
                }
            }
           Console.WriteLine(key);
        }
    }
}
