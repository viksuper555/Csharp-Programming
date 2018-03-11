using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainAir
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var flightsInfo = new Dictionary<string, List<int>>(); //customer name -> List of customer`s flights

            var command = Console.ReadLine();

            while(command != "I believe I can fly")
            {
                var commandArgs = command.Split().ToArray();

                if(commandArgs[1] == "=")
                {
                    //stamat = sony
                    var customerName1 = commandArgs[0];
                    var customerName2 = commandArgs[2];

                    List<int> flights = flightsInfo[customerName2];
                    flightsInfo[customerName1] = flights.ToList();
                }
                else
                {
                    var name = commandArgs[0];
                    List<int> flights = commandArgs.Skip(1).Select(int.Parse).ToList();
                    if (!flightsInfo.ContainsKey(name))
                        flightsInfo.Add(name, new List<int>());

                    flightsInfo[name].AddRange(flights.ToList());
                }
            }
            foreach(KeyValuePair<string,List<int>> customers in flightsInfo.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                string flights = string.Join(", ", customers.Value.OrderBy(x => x));
                Console.WriteLine($"#{customers.Key} ::: {customers.Value}");
            }
        }
    }
}
