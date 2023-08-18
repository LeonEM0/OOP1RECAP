using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_51_OOP_RECAP
{
    class Player
    {
        public string playerdata = string.Empty;
        public string name = String.Empty;
        public int lives = 0;
        public int points = 0;
        private int speed = 0;
        private int jumpheight = 0;
        public int[] ammunition = new int[5];  // arrays estructura de datos que contiene una coleccion de valores del mismo tipo
        //public int[] ammunition = new int[5] { 25, 50, 10, 5, 1 }; another way to declare the size of the array and also initialize the values 
        //var ammunition = new[] {"juan","pepe","Leonardo  "};

        public Player(string nombre, int vidas, int puntos)
        {
            name = nombre;
            lives = vidas;
            points = puntos;
 
        }
        public string DisplayPlayerData()
        {
            playerdata = "PLAYER 1: " + name + " " + "LIVES: " + lives + " POINTS: " + points;

            Console.WriteLine(playerdata);

            return playerdata;
        }

        public void Shoot()
        {
            Console.WriteLine("The player Shoots");
        }
        public void ShowAmmunition()
        {
            Console.WriteLine("La municion dentro del cartucho 0 es: " + ammunition[0]);
            Console.WriteLine("La municion dentro del cartucho 1 es: " + ammunition[1]);
            Console.WriteLine("La municion dentro del cartucho 2 es: " + ammunition[2]);
            Console.WriteLine("La municion dentro del cartucho 3 es: " + ammunition[3]);
            Console.WriteLine("La municion dentro del cartucho 4 es: " + ammunition[4]);
        }
        public void InitialAmmunition()
        {
            for(int i = 0; i < 5; i++)
            {
                ammunition[i] = 75;
            }
        }
        public void Jump()
        {
            Console.WriteLine("The enemy jumps");
        }
        
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int Jumpheight
        {
            get { return jumpheight; }
            set { jumpheight = value; }
        }

    }
}
