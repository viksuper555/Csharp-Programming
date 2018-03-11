using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][,] jaggedArray = new int[2][,];
            jaggedArray[0] = new int[,] { { 1,2,3}, { 1,2,3} };
            jaggedArray[1] = new int[,] { { 3, 5, 2 }, { 8, 2, 9 } };

        }
    }
}
