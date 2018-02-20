using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder5
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder(100);

            sb.Append("Hello, Mr Kolev!");
            Console.WriteLine(sb);
            sb.Replace("Mr ", "Mr. ");
            Console.WriteLine(sb);
            sb.Remove(11, 5);
            Console.WriteLine(sb);
            sb.Insert(11, "Gope");
            Console.WriteLine(sb);
        }
    }
}
