using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] intMatrix = new int[3, 4];
            int[,] matrix =
            {
                {1,2,3,4 },
                {1,2,3,4 }
            };
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            Console.WriteLine(row);
            Console.WriteLine(col);

            // Filling a Matrix

            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int[,] matrix2 = new int[r, c];

            for (int row2 = 0; row2 < r; row2++)
            {
                for (int col2 = 0; col2 < c; col2++)
                {
                    matrix[row2, col2] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
