using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string key = Console.ReadLine();

            Console.WriteLine(input);
            while(true)
            {
                int firstIndex = input.IndexOf(key);
                int lastIndex = input.LastIndexOf(key);
                if(firstIndex < 0 || lastIndex < 0 || firstIndex == lastIndex)
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);
                    break;
                }
                input = input.Remove(lastIndex, key.Length);
                input = input.Remove(firstIndex, key.Length);


                Console.WriteLine("Shaked it");
                key = key.Remove(key.Length / 2, 1);
            }
        }
    }
}
