using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forbidden
{
    class Program
    {
        static void Main(string[] args)
        {
            string banWord = Console.ReadLine().Split(',');

            string text = Console.ReadLine();
            foreach(var word in banWord)
            {
                if(text.Contains(word))
                text = text.Replace(word,new string('*', word.Lenght));
            }
            Console.WriteLine(text);
        }
    }
}
