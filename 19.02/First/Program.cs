using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Maria e tupa i hubava";
            name= name.Remove(8,7);
            string entry = "I like Windows, Linux and Apple";
            entry = entry.Replace("Apple", "****");
            Console.WriteLine(name);
        }
    }
}
