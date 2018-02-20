using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeBiuro
{
    class Program
    {
        static void Main(string[] args)
        {
            string currency = Console.ReadLine();
            var euros = double.Parse(Console.ReadLine());
            if (euros > 1000)
                euros += euros / 10;
            if (currency == "XRP" || currency == "ETH" || currency == "BTC")
            {

                var coins = 0.0;
                if (currency == "XRP")
                    coins = euros / 0.22;

                else if (currency == "BTC")
                    coins = euros / 6400;
                else
                    coins = euros / 250;

                if (currency == "XRP" && coins < 80)
                    Console.WriteLine("Insufficient funds");
                else if (currency == "BTC" && coins < 0.001)
                    Console.WriteLine("Insufficient funds");
                else if (currency == "ETH" && coins < 0.0099)
                    Console.WriteLine("Insufficient funds");
                else
                {
                    if (currency == "XRP")
                    {
                        if (coins >= 2500)
                            coins = coins + coins / 10;
                        else if (coins > 1000)
                            coins = coins + coins / 20;
                    }
                    else if (currency == "BTC")
                        if (coins > 10)
                            coins = coins + coins * 2 / 100;
                    Console.WriteLine($"Successfully purchased {coins:f3} {currency}");
                }

            }
            else
                Console.WriteLine($"EUR to {currency} is not supported.");
        }
    }
}
