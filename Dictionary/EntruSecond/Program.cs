using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntruSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();
            var dict2 = new SortedDictionary<string, int>();
            dict.Add("Pesho", 15);
            dict.Add("Alice", 18);
            dict.Add("Ivan", 17);

            dict2.Add("Pesho", 15);
            dict2.Add("Alice", 18);
            dict2.Add("Ivan", 17);

            foreach (var word in dict)
            {
                Console.WriteLine(word.Key + " --> " + word.Value);
            }
            foreach (var word in dict2)
            {
                Console.WriteLine(word.Key + " --> " + word.Value);
            }

        }
    }
}
