using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            string currency = "";
            var coins = 0.0;
            double dogeCoins = 0.0, neoCoins = 0.0, estdCoins = 0.0, iotaCoins = 0.0;
            int dogeCount = 0, neoCount = 0, estdCount = 0, iotaCount = 0;

            for (int i = 0; i < n; i++)
            {
                currency = Console.ReadLine();
                coins = double.Parse(Console.ReadLine());
                if (currency == "DOGE")
                {
                    dogeCoins += coins;
                    dogeCount++;
                }
                else if (currency == "NEO")
                {
                    neoCoins += coins;
                    neoCount++;
                }
                else if (currency == "ESTD")
                {
                    estdCoins += coins;
                    estdCount++;
                }
                else
                {
                    iotaCoins += coins;
                    iotaCount++;
                }
            }
            var dogePrice = dogeCoins * 0.07;
            var neoPrice = neoCoins * 28.5;
            var estdPrice = estdCoins * 25;
            var iotaPrice = iotaCoins * 1.44;

            var totalMoney = dogePrice + estdPrice + iotaPrice + neoPrice;

            Console.WriteLine($"Total votes = {n}, Money in market = {totalMoney:f2} EUR");
            Console.WriteLine($"DOGE's contribution: {dogePrice/totalMoney * 100:f2}%; People who use DOGE: {dogeCount}");
            Console.WriteLine($"IOTA's contribution: {iotaPrice / totalMoney * 100:f2}%; People who use IOTA: {iotaCount}");
            Console.WriteLine($"NEO's contribution: {neoPrice / totalMoney * 100:f2}%; People who use NEO: {neoCount}");
            Console.WriteLine($"ESTD's contribution: {estdPrice / totalMoney * 100:f2}%; People who use ESTD: {estdCount}");
        }
    }
}
