using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            int[,] matrix = new int[row+1, col+1];

            for (int r = 0; r < row; r++)
            {
                var VarRow = Console.ReadLine().Split().Select(int.Parse).ToList();
                for (int c = 0; c < col; c++)
                {
                    matrix[r, c] = VarRow[c];
                }
            }
            for (int c = 0; c < col; c++)
            {
                int min = int.MaxValue;
                for (int r = 0; r < row; r++)
                {
                    min = Math.Min(matrix[r, c], min);
                    matrix[row, c] = min;
                }
            }
            for (int r = 0; r < row+1; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    Console.Write("{0,5}", matrix[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}
