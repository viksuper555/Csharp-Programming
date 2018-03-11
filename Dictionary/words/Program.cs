using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace words
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split(' ');

            var wordsCount = new Dictionary<string, int>();
            foreach(var word in words)
            {
                if (!wordsCount.ContainsKey(word))
                    wordsCount.Add(word, 0);
                wordsCount[word] += 1;
                
            }
            foreach (var word in wordsCount)
            {
                Console.WriteLine(word.Key + " --> " + word.Value);
            }
            

        }
    }
}
