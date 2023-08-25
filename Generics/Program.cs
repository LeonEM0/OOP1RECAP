using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Student<T> //Generic Class
    {
        public T data;
        public Student(T data)
        {
            this.data = data;
            Console.WriteLine("Data passed" + this.data);
        }
        public void GenericMethod(T numero)   //Generic Method
        {
            Console.WriteLine("Data Passed"+data);   
        }
        public T DisplayData(T data)  //Generic Method with Return Type 
        {
            return data;
        }

        public T Data  // Generic Properties
        {
            get { return data; }
            set { data = value; }
        }

    }
    public class Gadget //Non Generic class
    {
       
        public T DisplayDataClass<T>(T gadget)  // Generic Method with Non Generic Class
        {
            Console.WriteLine(gadget);
            return gadget;
        }

    }

    class Program
    {
        /*
          C# Generics allow us to create a single class or method that can be used with different types 
          of data. This helps us to reuse our code.

        */
        static void Main(string[] args)
        {
            int[] arrayint = { 1, 2, 3 };
            double[] doublearray = { 1.1, 1.2, 1.3 };
            string[] stringarray = { "uno", "dos", "tres" };
            char[] chararray = {'|','Z','E'};
            


            Console.WriteLine("Generics\n");
            Student<string> student_calificaciones = new Student<string>("FAIL");
            Student<int> student_id = new Student<int>(9);
            Gadget pc = new Gadget();

            Console.WriteLine(pc.DisplayDataClass(99));
            Console.WriteLine(pc.DisplayDataClass("Razer"));

            student_id.Data = 2210228;
            Console.WriteLine(student_id.Data);

            // var studentid = new Student<float>(8.5f); Instantiate the object with var to make the code cleaner
           /* student_id.GenericMethod(23);
            DisplayElements(arrayint);
            DisplayElements(doublearray);
            DisplayElements(stringarray);
            DisplayElements(chararray);
           */

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
