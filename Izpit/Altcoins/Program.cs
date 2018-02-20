using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altcoins
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoins = double.Parse(Console.ReadLine());
            var bitcoinStartPrice = double.Parse(Console.ReadLine());
            var bitcoinCurrentPrice = double.Parse(Console.ReadLine());
            var etheriumCount = double.Parse(Console.ReadLine());
            var neoCount = double.Parse(Console.ReadLine());

            var bitcoinProfit = bitcoins * bitcoinCurrentPrice - bitcoins * bitcoinStartPrice;
            var etheriumPrice = bitcoinCurrentPrice * 7.5 / 100;
            var neoPrice = etheriumPrice * 40 / 100;
            var totalPrice = etheriumCount * etheriumPrice + neoPrice * neoCount;
            var moneyLeft = bitcoinProfit - totalPrice;
            if (bitcoinProfit > totalPrice)
            {
                Console.WriteLine($"Stefcho bought {etheriumCount:f4} Ethereum at a price of {etheriumPrice:f4}");
                Console.WriteLine($"Stefcho bought {neoCount:f4} Neo at a price of {neoPrice:f4}");
                Console.WriteLine($"Stefcho has {moneyLeft:f2} profits left to spend.");
            }
            else
            {
                Console.WriteLine("Stefcho does not have enough money to make this investment.");
                Console.WriteLine($"He needs {-moneyLeft:f2} more in profits.");
            }

        }
    }
}
