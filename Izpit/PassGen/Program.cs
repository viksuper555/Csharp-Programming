using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGen
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            var count = 0;
            for (int firstDig = 0; firstDig < 10; firstDig++)
            {
                for (int secondDig = 0; secondDig < 10; secondDig++)
                {
                    for (int thirdDig = 0; thirdDig < 10; thirdDig++)
                    {
                        for (var firstLetter = 'a'; firstLetter <= 'z'; firstLetter++)
                        {
                            for (var secondLetter = 'a'; secondLetter <= 'z'; secondLetter++)
                            {
                                for (int lastDig = 0; lastDig < 10; lastDig++)
                                {
                                    if (firstDig + secondDig + thirdDig + firstLetter + secondLetter + lastDig == m)
                                    {
                                        Console.Write($"{firstDig}{secondDig}{thirdDig}{firstLetter}{secondLetter}{lastDig} ");
                                        count++;
                                    }
                                    if (count == n)
                                        break;
                                    
                                }
                                if (count == n)
                                    break;
                            }
                            if (count == n)
                                break;
                        }
                        if (count == n)
                            break;
                    }
                    if (count == n)
                        break;
                }
                if (count == n)
                    break;
            }
        }
    }
}
