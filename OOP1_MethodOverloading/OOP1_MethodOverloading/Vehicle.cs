using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1_MethodOverloading
{
    class Vehicle
    {
        public static string modelcar = "subaru";
        public static int counter = 1;


        public string color;  //when you dont put an accesor modifier it will take it as private
        public string model;
        public string distribuitor;
        private int size_x = 100;
        public int size_y = 50;

        public Vehicle(string the_color, string the_model, string the_distribuitor)
        {
            color = the_color;
            model = the_model;
            distribuitor = the_distribuitor;

            Console.WriteLine("{0} {1} {2} ", color, model, distribuitor);

        }
        public Vehicle(string color_vehicle)
        {
            color = color_vehicle;

            Console.WriteLine("Constructor with one parameter" + color);

        }

        public Vehicle()
        {
            Console.WriteLine("Constructor without parameter");
        }

        public static void DisplayVehicles()
        {
            Console.WriteLine("CIVIC, MUSTANG, ROLL ROYCE");
        }

        public int Size_x
        {
            set { size_x = value; }
            get { return size_x; }
        }
        public int Size_y
        {
            get { return size_y; }
            set { size_y = value; }
        }

        public void fullthrottle() //METHODS MUST BE DECLARED AS PUBLIC INSIDE THE CLASS
        {
            Console.WriteLine("The car is going as fast as it can!!!!!!!!!!!!!");
            Console.WriteLine(size_x);
        }
    }
}
