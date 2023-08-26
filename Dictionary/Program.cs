using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> countries = new Dictionary<int,string>();
            countries.Add(0, "Mexico");
            countries.Add(1, "Usa");
            countries.Add(2, "Canada");

            Console.WriteLine(countries[0]); //You access with the key of the dictionary
            Console.WriteLine(countries[1]);
            Console.WriteLine(countries[2]);

            foreach(KeyValuePair<int, string> country in countries)
            {
                Console.WriteLine("Place: \t"+country.Key+" Country:"+country.Value);
            }

            Console.ReadKey();
        }
    }
}
