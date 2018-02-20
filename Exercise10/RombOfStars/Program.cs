using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RombOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizeOfRhombus = int.Parse(Console.ReadLine());
            //First Half
            for (int row = 1; row <= sizeOfRhombus; row++)
            {
                var numberOfStars = row;
                var numberOfStartSpaces = sizeOfRhombus - row;
                Console.Write(new string(' ', numberOfStartSpaces));
                for (int col = 0; col < numberOfStars; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }
            //Second Half
            for (int row = sizeOfRhombus -1; row >= 1; row--)
            {
                var numberOfStars = row;
                var numberOfStartSpaces = sizeOfRhombus - row;
                Console.Write(new string(' ', numberOfStartSpaces));
                for (int col = 0; col < numberOfStars; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
    }
}
