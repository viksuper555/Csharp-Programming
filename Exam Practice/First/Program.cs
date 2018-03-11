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
            int regionCount = int.Parse(Console.ReadLine());
            double density = double.Parse(Console.ReadLine());

            decimal sumCoefficients = 0;
            for (int i = 0; i < regionCount; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();

                double rainDropsCount = double.Parse(input[0]);
                double squareMeters = double.Parse(input[1]);
                sumCoefficients += (decimal)(rainDropsCount / squareMeters);
            }
            if(density == 0)
                Console.WriteLine($"{sumCoefficients:f3}");
            else
                Console.WriteLine($"{(sumCoefficients/(decimal)density):f3}");
        }
    }
}
