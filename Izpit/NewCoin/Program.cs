using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = n * 6;
            
            //FirstPart
            for (int row = 0; row < n; row++)
            {
                var spaces = n * 2 - row * 2;
                var slashes = n - row;
                var tireta = width - 2 * spaces - 2 * slashes;
                Console.WriteLine(new string(' ', spaces) + new string('\\', slashes) +
                                  new string('-', tireta) +  
                                  new string('/', slashes) + new string(' ', spaces)
                                  );
            }
            //Mid
            var midRows = 0;
            if (n % 2 == 0)
                midRows = n - 1;
            else
                midRows = n - 2;
            for (int i = 0; i < midRows; i++)
            {
                var waves = n - 1;
                var htag = width - waves * 2 - 2;
                var slashes = (htag - 6) / 2;
                if(i == midRows/2)
                    Console.WriteLine("|" + new string('~', waves) + new string('/',slashes) + " " + "ESTD" + " " + new string('\\', slashes) + new string('~', waves) + "|");
                else
                Console.WriteLine("|" + new string('-',waves) + new string('#',htag) + new string('-', waves) + "|");

            }
            //LastPart
            for (int row = n; row >= 0; row--)
            {
                var spaces = n * 2 - row * 2;
                var slashes = n - row;
                var tireta = width - 2 * spaces - 2 * slashes;
                Console.WriteLine(new string(' ', spaces) + new string('\\', slashes) +
                                  new string('-', tireta) +
                                  new string('/', slashes) + new string(' ', spaces)
                                  );
            }
        }
    }
}
