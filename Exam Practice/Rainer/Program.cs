using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int currentIndex = input.Last();
            var initialValues = input.Take(input.Length - 1).ToArray();
            int steps = 0;
            var currentValues = initialValues.ToArray();

            bool isWet = false;

            while(!isWet)
            {
                for (int i = 0; i < currentValues.Length; i++)
                {
                    currentValues[i]--;
                }
                for (int i = 0; i < currentValues.Length; i++)
                {
                    if(currentValues[i] == 0 && currentIndex == i)
                    {
                        isWet = true;
                        break;
                    }
                }
                if (isWet)
                    break;
                for (int i = 0; i < currentValues.Length; i++)
                {
                    if (currentValues[i] == 0)
                        currentValues[i] = initialValues[i];
                }
                steps++;
                currentIndex = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", currentValues));
            Console.WriteLine(steps);
        }
    }
}
