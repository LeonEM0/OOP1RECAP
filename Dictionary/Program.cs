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
            var fertility_rate = new Dictionary<string, float>();

            countries.Add(0, " Mexico");
            countries.Add(1, " Usa");
            countries.Add(2, " Canada");
            countries.Add(3, " India");
            countries.Add(4, " China");
            countries.Add(5," Russia");
            countries.Add(6," Ukraine");

            fertility_rate.Add("Mexico",1.9f);
            fertility_rate.Add("Usa",1.6f);
            fertility_rate.Add("Canada",1.4f);
            fertility_rate.Add("India",2.1f);
            fertility_rate.Add("China",1.3f);
            fertility_rate.Add("Russia",1.55f);
            fertility_rate.Add("Ukraine",1.1f);

            countries.Remove(5);
            countries.Remove(6);

           // countries.Clear(); Clear function to REMOVE ALL THE ELEMENTS OF the dictionary
           
            Console.WriteLine(countries[0]); //You access with the key of the dictionary
            Console.WriteLine(countries[1]);
            Console.WriteLine(countries[2]);

            foreach (KeyValuePair<int, string> country in countries) //KeyValuePair<int,string >
            {
                Console.WriteLine("Place: \t"+country.Key+" Country:"+country.Value);
            }
            Console.WriteLine();
            foreach (KeyValuePair<string, float> birthrate in fertility_rate)
            {
                Console.WriteLine("Country {0} Fertility rate {1}", birthrate.Key, birthrate.Value);


            }
            Console.ReadKey();
        }
        //Remove and Change with the key

        //SORT METHOD IS NOT AVAILABLE IN A DICTIONARY
    }
}
