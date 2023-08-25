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
            Console.WriteLine("COLLECTIONS!");
            Console.WriteLine("You need to add system collections. Generic library");
            Console.WriteLine("Similar to an array but, IT CAN DYNAMICALLY INCREASE OR DECREASE IN SIZE ");

            Players player1 = new Players("Leon");
            Players player2 = new Players("Christian");
            Players player3 = new Players("Maximo");

            player.Add(player1);
            player.Add(player2);
            player.Add(player3);
            //Console.WriteLine("Elemento 1\t"+numbers[2]); 
            //Console.WriteLine("Elemento 1\t"+subjects[7]);

            subjects.Add("9 - English");
          //  subjects.Remove("5 - Applied Math"); // or subjects.Remove(subjects[5]);

            subjects.Insert(9,"10 - Literary Genres");
            subjects.Remove("9 - English");
            subjects.RemoveAt(6);

            foreach (int numeros in numbers)//foreach
            {
                Console.WriteLine(numeros);
            }
            Console.WriteLine("\n");

            for(int i = 0; i<subjects.Count;i++)//for
            {
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
                Console.WriteLine(p.username);
            }
            Console.WriteLine("\n");


            Console.WriteLine("AMOUNT OF NUMBERS "+numbers.Count); //Count indicates tbe amount of elements in the List
            Console.WriteLine("AMOUNT OF SUBJECTS "+subjects.Count); //Count 

             

        }
    }
}

//accessing elements name of the collection + []
//OPERATIONS Add, Insert, Remove