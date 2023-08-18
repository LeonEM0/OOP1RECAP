using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1_MethodOverloading
{
    
    class Motorcycle:Vehicle
    {
        public int wheels_number;
        public string wheels_brand;

        public int Wheels_number
        {
            get { return wheels_number; }
            set { wheels_number = value; }
        }

        public Motorcycle(int wheelsn):base("black ","ninja","yamaha") //Same name and public
        {
            Wheels_number = wheelsn;
        }

        public Motorcycle(string wheels_b):base("black ","ninja","yamaha")
        {
            wheels_brand = wheels_b;

        }
        public Motorcycle():base("black ", "ninja", "yamaha")
        {
            Console.WriteLine("motorcycle Constructor with no parameters");
        }

        public void MotoRun()
        {
            Console.WriteLine("The motorcycle is running!!!!");
        }
        public void MotorcycleElements()
        {
            Console.WriteLine("{0}{1}{2}{3}{4}", wheels_number, color, model, distribuitor);
        }
    }
    class Animal
    {
        public string especie = "mamifero";
        public virtual void Eat()
        {
            Console.WriteLine("The animal has the capacitiy to eat");
        }
    }
    class Dog: Animal
    {
        public void loop()
        {
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine(i);

            }

        }
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("the dog eats DOG food");
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            /*

            Console.WriteLine("A class defines a *TEMPLATE* or blueprint for creating objects that are functional in a program\n");

            Console.WriteLine("Value types => bool, byte, char, decimal, double, float, int, long, uint, ulong, ushort, enum, struct STACK");
            Console.WriteLine("Reference types => class, interface, delegate, string, object, dynamic, arrays HEAP");


            Console.WriteLine("A pointer its a variable that stores the memory adress ");
            */
            Dog GermanSheppard = new Dog();
            Vehicle carro1 = new Vehicle("rojo");
            Motorcycle moto1 = new Motorcycle();


            GermanSheppard.loop();
            Console.WriteLine("\n\n");

            Console.WriteLine(Vehicle.counter);
            //you can the static variables and methods with the class







            Console.ReadKey();
        }
        #region
        //Memory stack == static it stores variables, functions and local variables in the functions THE STACK cant be changed 
        // stackoverflow stackfull
        // structs and pointers are created in the stack 


        //Heap Memory is dynamical it can change his size, objects are allocated in the heap 
        //Objects and Classes are allocated on the heap

        /*
        Memoria Cache = En informática, una memoria caché es una capa de almacenamiento de datos de alta velocidad
        que almacena un subconjunto de datos, normalmente transitorios, de modo que las solicitudes
        futuras de dichos datos se atienden con mayor rapidez que si se debe acceder a los datos desde la ubicación de almacenamiento principal.


        // Property is a member that uses accesors methods getters and setters 
        S
        
        */
        #endregion
    }


    //CLASSES DONT OCUPPY MEMORY -
    //OBJECTS OCCUPY MEMORY
}
/*• One C# property is an accessor, a get property (or a getter) and is configured for READONLY operation.
• Another C# property is a mutator, a set property (or a setter) and is configured for WRITEONLY operations.
*/