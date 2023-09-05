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
            List<KeyValuePair<string, float>> fertiliy_rate_list = new List<KeyValuePair<string, float>>();

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
            
           for (int i = 1; i <5; i++)
           {
                fertility_rate["Mexico"] = fertility_rate["Mexico"]-0.2f  ;
                fertility_rate["Usa"] = fertility_rate["Usa"] - 0.2f;
                fertility_rate["Canada"] = fertility_rate["Canada"] - 0.2f;
                fertility_rate["India"] = fertility_rate["India"] - 0.2f;
                fertility_rate["China"] = fertility_rate["China"] - 0.2f;
                fertility_rate["Russia"] = fertility_rate["Russia"] - 0.2f;
                fertility_rate["Ukraine"] = fertility_rate["Ukraine"] - 0.2f;

                Console.WriteLine("\n");

                DisplayDictionary(fertility_rate);

           }
           
           
            Console.WriteLine("\n");

          
           


            Console.ReadKey();
        }
        //Remove and Change with the key

        public static void DisplayDictionary(Dictionary<string,float> birthrate)
        {
            foreach (KeyValuePair<string, float> pais in birthrate)
            {
                Console.WriteLine("country" + pais.Key + "fertulity" + pais.Value);
            }

        }
        //SORT METHOD IS NOT AVAILABLE IN A DICTIONARY
    }
}
