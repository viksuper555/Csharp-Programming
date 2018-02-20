using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "Amstel, Pirinsko,Zagorka Burgazko.";

             string[] beers = input.Split(new char[] { ',', ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(string.Join(" ",beers));
        }
    }
}
