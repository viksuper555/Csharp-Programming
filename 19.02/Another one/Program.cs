using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Another_one
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Stopwatch();

            timer.Start();

            var result = new StringBuilder();

            for (int i = 0; i < 50000; i++)
            {
                result.Append("a");
            }
            Console.WriteLine(result.Length);
            Console.WriteLine(timer.Elapsed);
        }
    }
}
