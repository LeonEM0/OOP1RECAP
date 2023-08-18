using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO_51_OOP_RECAP
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathname = @"C:\Users\Admin\Desktop\OOP_recap\Files_Exercises\DemoFile.txt";
            string randstring = "This is a Random String";
            string read_txt;
            Player player1 = new Player("CLIO", 3, 100);
            var valores = new[] {75,85,10,12,15.5,9.2,7,8,3,10};
            int[] numeros = new int[6];
            Enemy[] arrayenemy1 = new Enemy[3];

            /*
            
            arrayenemy1[0] = new Enemy("soldier","glock");
            arrayenemy1[1] = new Enemy("robot","laser");
            arrayenemy1[2] = new Enemy("general","machine gun");

            */
            
            
            Enemy soldier = new Enemy("soldier","glock",3,4.5f);
            Enemy robot = new Enemy("robot","laser",2,1.5f);
            Enemy general = new Enemy("general","machine gun",5,1.1f);  //4 parameters

            arrayenemy1[0] = soldier;
            arrayenemy1[1] = robot;
            arrayenemy1[2] = general;


            numeros[0] = 3;
            numeros[1] = 4;
            numeros[2] = 5;
            numeros[3] = 6;
            numeros[4] = 7;
            numeros[5] = 8;

            ProcesaDatos(numeros);

            foreach(int num in numeros)
            {
                Console.WriteLine(num);
            }



            FileStream fs = File.Create(pathname);
           



           
            if(File.Exists(pathname))
            {
                Console.WriteLine("File is created");
            }
            else
            {
                Console.WriteLine("File is not created");
            }
            fs.Close();

            ProcesaDatos(numeros);
            /*
            for(int i = 0; i<arrayenemy1.Length; i++)
            {
                Console.WriteLine(arrayenemy1[i].GetInfo());
            }
            */
            foreach(Enemy variable in arrayenemy1)
            {
                Console.WriteLine(variable.GetInfo());
            }

            /*
            #region PROPERTY ARRAY.LENGTH
            for (int i = 0; i<valores.Length;i++)
            {
                Console.WriteLine(valores[i]);
            }
            #endregion
            */
            Console.WriteLine("\n\n\n\n");
            /*
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arrayenemy1[i].name  +" "+ arrayenemy1[i].gun+" " + arrayenemy1[i].lives +" "+ arrayenemy1[i].cooldown);
            }
            */


            Console.WriteLine("\n\n\n\n");


            Console.WriteLine("Files");
            


            player1.DisplayPlayerData();

            player1.InitialAmmunition();

            player1.ShowAmmunition();

            File.WriteAllText(pathname,player1.playerdata+" READ WITH METHOD ReadAllText" );

            read_txt = File.ReadAllText(pathname);

            Console.WriteLine(read_txt);



            Console.ReadKey();

        }
        
        static void ProcesaDatos(int [] datos)
        {
            for(int i =0;i<datos.Length;i++)
            {
                datos[i] = datos[i] + 10;
            }
        }
    }
}
