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
            var arr = new char[] { 'A', 'l', 'e', 'x',' '};
            string a = new string(arr);
            string b = "Pesho";
            char[] arr1 = b.ToCharArray();

            int result = string.Compare(a, b);

            string fullname = string.Concat(a, b);

            Console.WriteLine(fullname);
            Console.WriteLine(result);
        }
    }
}
