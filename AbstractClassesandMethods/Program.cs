using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesandMethods
{
    interface IAcidAttack
    {
         void LaunchAcid();
        
    }


    class Enemy
    {
        public Enemy()
        {
            Console.WriteLine("Constructor ENEMIGO");
        }
    }
    class SoldierEnemy:Enemy,IAcidAttack;
    {
        public SoldierEnemy()
        {
            Console.WriteLine("Constructor SOLDADO! ENEMIGO!");
        }
        public void LaunchAcid()
        {
            Console.WriteLine("The enemy is launching acid");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SoldierEnemy soldadomalo1 = new SoldierEnemy();

            Console.ReadKey();
        }
    }
}
