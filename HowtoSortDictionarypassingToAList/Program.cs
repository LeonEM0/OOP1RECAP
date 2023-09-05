using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace Assignment4OOPSaulEmmanuel
{
    public abstract class WordSort
    {
        // Abstract method to sort words
        public abstract List<KeyValuePair<string, int>> Wordsort(Dictionary<string, int> word_count);
    }

    // Interface for sorting words alphabetically
    interface IAlphabeticalSort
    {
        List<KeyValuePair<string, int>> AlphabeticalSort(Dictionary<string, int> word_count);
    }
    //interface for sorting words by frecuency 
    interface IFrequencySort
    {
        List<KeyValuePair<string, int>> FrequencySort(Dictionary<string, int> word_count);
    }
    interface IFrequencySortInverse
    {
        List<KeyValuePair<string, int>> FrequencySortInverse(Dictionary<string, int> word_count);
    }
    public class AllSorts : WordSort, IAlphabeticalSort, IFrequencySort, IFrequencySortInverse
    {
        public override List<KeyValuePair<string, int>> Wordsort(Dictionary<string, int> word_count)
        {
            return AlphabeticalSort(word_count);
        }

        //Method to sort words alphabetically 
        public List<KeyValuePair<string, int>> AlphabeticalSort(Dictionary<string, int> word_count)
        {
            List<KeyValuePair<string, int>> sorted_words = new List<KeyValuePair<string, int>>(word_count);
            sorted_words.Sort((x, y) => x.Key.CompareTo(y.Key));

            return sorted_words;

        }
        public List<KeyValuePair<string, int>> FrequencySort(Dictionary<string, int> word_count)
        {
            List<KeyValuePair<string, int>> sorted_words = new List<KeyValuePair<string, int>>(word_count);
            sorted_words.Sort((x, y) => x.Value.CompareTo(y.Value)); // The lambda is used to sort the values

            return sorted_words;
        }

        public List<KeyValuePair<string, int>> FrequencySortInverse(Dictionary<string, int> word_count)
        {
            List<KeyValuePair<string, int>> sorted_words = new List<KeyValuePair<string, int>>(word_count);
            sorted_words.Sort((x, y) => y.Value.CompareTo(x.Value)); // The lambda is used to sort the values

            return sorted_words;
        }

    }

    class Program : AllSorts
    {
        static void Main(string[] args)
        {
            int totalwords = 0;
            int option;
            Dictionary<string, int> word_count = new Dictionary<string, int>(); // dictionary  <Tkey string><Tvalue int
            // dict cant have same keys
            //teacher path  @"C:\temp\WordCount\demography.txt"
            string pathname = @"C:\temp\WordCount\demography.txt"; //pathname 
            string[] words_in_text = File.ReadAllText(pathname).Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries); //  maybe change it to an array 

            AllSorts my_word_counter = new AllSorts(); // instantiate the class all sorts to use it 


            foreach (string word in words_in_text)
            {
                if (word_count.ContainsKey(word))
                {
                    word_count[word]++;
                    totalwords++;
                }
                else
                {
                    word_count[word] = 1;
                    totalwords++;
                }
            }
            Console.WriteLine("\nThe total number of the words is " + totalwords + " words");

            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();
            #region

            // word_count.Clear();  clear method name.Clear();
            Console.WriteLine("Alpha sorted list:");

            foreach (KeyValuePair<string, int> r in word_count) // KeyValue pair is used to specify when we have to 2 data type parameters key and value
            {
                Console.WriteLine("Key: " + r.Key + " Value: " + r.Value + "\n");
            }

            #endregion alphasortedlist

            option = DictionaryMenu(word_count, my_word_counter);  //Menu

            Console.ReadLine();
        }

        private static int DictionaryMenu(Dictionary<string, int> word_count, AllSorts my_word_counter)
        {
            int option = 0;

            Console.WriteLine("\nIntroduce the option");
            Console.WriteLine("1-Shows word frequency alphabetically");
            Console.WriteLine("2-Shows word frequency by most count to least count");
            Console.WriteLine("3-Shows word frequency by least count to most count");
            Console.WriteLine("4-Exit the app");

            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Data type introduced is incorrect..." + ex.Message);
            }

            while (option != 4)
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine("1-Shows word frequency alphabetically");

                        var kv_alpha_sort = my_word_counter.AlphabeticalSort(word_count);

                        foreach (KeyValuePair<string, int> key_value_pair in kv_alpha_sort)
                        {
                            Console.WriteLine("{0}: {1}", key_value_pair.Key, key_value_pair.Value);
                        }
                        Console.WriteLine("Frecuency Sorted List");
                        Console.WriteLine("Press a key.....");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("2-Shows word frequency by most count to least count");

                        var vk_freq_sort = my_word_counter.FrequencySortInverse(word_count);

                        foreach (KeyValuePair<string, int> key_value_pair in vk_freq_sort)
                        {
                            Console.WriteLine("{0}: {1}", key_value_pair.Key, key_value_pair.Value);
                        }
                        Console.WriteLine("Press a key.....");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("3-Shows word frequency by least count to most count");

                        var kv_freq_sort = my_word_counter.FrequencySort(word_count);

                        foreach (KeyValuePair<string, int> key_value_pair in kv_freq_sort)
                        {
                            Console.WriteLine("{0}: {1}", key_value_pair.Key, key_value_pair.Value);
                        }
                        Console.WriteLine("Press a key.....");
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("4-Option to quit application"); option = 4;
                        break;

                    default:
                        Console.WriteLine("The introduced value is incorrect please introduce a valid number");
                        break;

                }
                try
                {
                    Console.WriteLine("\nIntroduce the option\n");
                    option = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Data type introduced is incorrect ..." + ex.Message);
                }


            }

            Console.WriteLine("4- EXIT THE APPLICATION HAS BEEN SELECTED");
            return option;
        }
    }
}
// you have to use keyvaluepair in foreach loop string, int*
// interfaces    you can use multiple interfaces and multiple inheritances*
// interfaces DONT HAVE fields, and methods just partially *
// interface must have an I*
// add interfaces and word sort to the class Allsorts *

