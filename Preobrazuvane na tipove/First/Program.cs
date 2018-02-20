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
            int count = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = count / capacity;
            int bonus = count - (capacity * courses);
            if (bonus != 0)
                bonus = (int) Math.Ceiling((double) bonus / capacity);
            courses += bonus;
            Console.WriteLine(courses);
        }
    }
}
