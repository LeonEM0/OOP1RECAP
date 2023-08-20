using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayint = { 1, 2, 3 };
            double[] doublearray = { 1.1, 1.2, 1.3 };
            string[] stringarray = { "uno", "dos", "tres" };
            char[] chararray = {'|','Z','E'};


            Console.WriteLine("Generics\n");
            DisplayElements(arrayint);
            DisplayElements(doublearray);
            DisplayElements(stringarray);
            DisplayElements(chararray);

            Console.ReadKey();
        }

        public static void DisplayElements<T>(T[] array)
        {
            foreach(T number in array)
            {
                Console.WriteLine(number);
            }
        }
/*
        public static void DisplayElements(int[] array)
        {
            foreach(int numbers in array)
            {
                Console.WriteLine(numbers);
            }
        }
        public static void DisplayElements(double[] array)
        {
            foreach (double numbers in array)
            {
                Console.WriteLine(numbers);
            }
        }
        public static void DisplayElements(string[] array)
        {
            foreach (string numbers in array)
            {
                Console.WriteLine(numbers);
            }
        }
*/
    }
}
