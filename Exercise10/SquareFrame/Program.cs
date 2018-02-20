using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            //* My solutuion

            /* var n = int.Parse(Console.ReadLine());
            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");
            for (int row = 0; row < n-2; row++)
            {
                Console.Write("| ");
                for (int col = 0; col < n-2; col++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("|");
            }
            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");
            */
            var n = int.Parse(Console.ReadLine());
            var fill = "";
            var FLRow = "";
            for (int i = 0; i < n - 2; i++)
            {
                 fill += "- ";
            }
            FLRow += "+ ";
            FLRow += fill;
            FLRow += "+";
            Console.WriteLine(FLRow);
            for (int row = 0; row < n - 2; row++)
            {
                Console.Write("| ");
                Console.Write(fill);
                Console.WriteLine("|");
            }
            Console.WriteLine(FLRow);
        }
    }
}
