using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entru
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();

            phonebook["John Smith"] = "+1-555-8975";
            phonebook["Ivan"] = "+359-899-555-592";
            phonebook["Jane Smith"] = "+1-555-8975";
            phonebook.Add("Jane Smith2", "+1-555-8975");
            phonebook.Clear();
            phonebook.Remove("John Smith");

            foreach(var pair in phonebook)
            {
                Console.WriteLine($"{pair.Key} --> {pair.Value}");
            }
        }
    }
}
