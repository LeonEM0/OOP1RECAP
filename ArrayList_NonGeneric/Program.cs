using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // You will need the library system.Collections to use ArrayList
namespace ArrayList_NonGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            var contain = true;
            ArrayList jugadores = new ArrayList();
            Console.WriteLine(" ArrayList NonGeneric");
            Console.WriteLine(" An ArrayList stores elements of 'MULTIPLE' data types whose size can be changed dinamically");
            jugadores.Add(" Leon ");
            jugadores.Add(100);
            jugadores.Add('$');
            jugadores.Add(1.75f+"cm"); //you can introduce multiple data types 
            jugadores.Add(25+" Years");
            jugadores.Add(3+" Lives");
            jugadores.Add("$"+6000+" CAD");
            jugadores.Add("$"+100 +" MXN");
            jugadores.Add(100 + "Bullets");
            jugadores.Add("item");

            jugadores.Remove('$');
            for(int i = 0; i<jugadores.Count;i++)
            {
                Console.WriteLine(jugadores[i]);
            }
            /*
            foreach(var jugadordata in jugadores)
            {
                Console.WriteLine(jugadordata);
            }
            */
            Console.WriteLine("Los datos de los jugadores es "+jugadores.Count);

            //To Access with the index
            Console.WriteLine(jugadores[5]);
            Console.WriteLine(jugadores[7]);
            Console.WriteLine(jugadores[6]);
            //Tochange the values in the index
            jugadores[0] = "Emmanuel";
            jugadores[1] = 200;

            Console.WriteLine(jugadores[0]);
            Console.WriteLine(jugadores[1]);
            //
            contain = jugadores.Contains(200);

            Console.WriteLine("The element exists? " + contain);

            Console.WriteLine("\n");

            Console.ReadKey();

        }
    }
}
