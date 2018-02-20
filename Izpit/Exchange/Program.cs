using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange
{
    class Program
    {
        static void Main(string[] args)
        {
            var moneyInvested = double.Parse(Console.ReadLine());
            var bitcoinPrice = double.Parse(Console.ReadLine());
            var satoshiForByte = int.Parse(Console.ReadLine());


            var potentialBitcoins = moneyInvested / bitcoinPrice;
            var taxInBitcoin = potentialBitcoins * (satoshiForByte * 1024)/100000000;
            var totalBitcoin = potentialBitcoins - taxInBitcoin;
            var progSalary = totalBitcoin /10;
            double taxInDollars = taxInBitcoin * bitcoinPrice;
            var clearBitcoin = totalBitcoin - progSalary;

            Console.WriteLine($"Total bitcoin after expenses: {clearBitcoin:f5} BTC");
            Console.WriteLine($"Tax payed: {taxInDollars:f2} USD");
            Console.WriteLine($"Programmer`s payment: {progSalary:f5} BTC");

        }
    }
}
