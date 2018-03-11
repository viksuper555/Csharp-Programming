using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            float[,] matrix = new float[row, col+1];

            for (int r = 0; r < row; r++)
            {
                float sum = 0;int c;
                for (c = 0; c < col; c++)
                {
                    matrix[r, c] = int.Parse(Console.ReadLine());
                    sum += matrix[r, c];
                }
                matrix[r, c] = sum / col; 
            }

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col+1; c++)
                {
                    Console.Write("{0,10}", matrix[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}
