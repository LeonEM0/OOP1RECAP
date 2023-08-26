using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() {100,200,300,400,500};
            List<string> subjects = new List<string> {"1 - Operating systems","2 - Knowledge","3 - Databases","4 - oop2","5 - Applied Math","6 - French","7 - Physical education","8 - Game Engine" };
            var activities = new List<string> {"Sleep","Study","Play Video Games","Coding","Exercise"};
            List<Players> player = new List<Players>();
            char[] symbology = { 'Z', '$', '%' };
            string[] MarriedPeople = {"Yes","No","No","No","No","Yes","Yes"};
            int married = 0;
            int unmarried = 0;

            Console.WriteLine("COLLECTIONS!");
            Console.WriteLine("You need to add system collections. Generic library");
            Console.WriteLine("Similar to an array but, IT CAN DYNAMICALLY INCREASE OR DECREASE IN SIZE ");

            Players player1 = new Players("Leon", 2210228, 76.5f,'m'); ;
            Players player2 = new Players("Christian",2210229,90.60f,'m');
            Players player3 = new Players("Chona",221011,99.92f,'f');

            player.Add(player1);
            player.Add(player2);
            player.Add(player3);
            //Console.WriteLine("Elemento 1\t"+numbers[2]); 
            //Console.WriteLine("Elemento 1\t"+subjects[7]);

            subjects.Add("9 - English");
          //  subjects.Remove("5 - Applied Math"); // or subjects.Remove(subjects[5]);

            subjects.Insert(9,"Litery genres");
            subjects.Remove("9 - English");
            subjects.RemoveAt(6);

            foreach (int numeros in numbers)//foreach
            {
                Console.WriteLine("Collection of Numbers");
                Console.WriteLine(numeros);
            }
            Console.WriteLine("\n");

            for(int i = 0; i<subjects.Count;i++)//for
            {
                Console.WriteLine("Collection of objects");
                Console.WriteLine(subjects[i]);

            }
            Console.WriteLine("\n");
            foreach (string act in activities)
            {
                Console.WriteLine(act);
            }
            Console.WriteLine("\n");
            foreach(Players p in player)
            { 
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("\n");
            
            foreach(char symbol in symbology)
            {
                Console.WriteLine(symbol);
            }
            Console.WriteLine();
            foreach(string civil_status in MarriedPeople)
            {
                 
                Console.WriteLine(civil_status);
                if(civil_status == "Yes")
                {
                    married++;
                    
                }
                else if(civil_status == "No")
                {
                    unmarried ++;
                }

            }
            Console.WriteLine("\n");

            Console.WriteLine("The amount of Married people is: "+married);
            Console.WriteLine("The amount of Unmarried people is: "+unmarried);



            Console.WriteLine("AMOUNT OF NUMBERS "+numbers.Count); //Count indicates tbe amount of elements in the List
            Console.WriteLine("AMOUNT OF SUBJECTS "+subjects.Count); //Count 


            Console.ReadKey();
        }
    }
}

//accessing elements name of the collection + []
//OPERATIONS Add, Insert, Remove