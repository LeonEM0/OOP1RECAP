using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CHAPTER1_2_3
{       
     //CHAPTER 1,2,3 OOP 
    class Program
    {
        static void Main(string[] args)
        {
           

            decimal valor = 123.908m;
            string s = String.Format("CurrentTime"+DateTime.Now );

            Console.WriteLine("CHAPTER 1,2,3 OOP"+DateTime.Now);
            Console.WriteLine("PascalCase or CamelCase == Structs and Methods");
            Console.WriteLine("snake_case ==  Classes");
            Console.WriteLine("\n");
            Console.WriteLine("The account balance is {0}", valor);

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(s);

            
            Console.ReadLine();
        }

    }
}
