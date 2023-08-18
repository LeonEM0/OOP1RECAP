using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_51_OOP_RECAP
{
    class Enemy
    {
        private string name = string.Empty;
        private string gun = string.Empty;
        private int lives;
        private float cooldown;


        public Enemy(string name, string gun, int lives, float cooldown)
        {
            this.name = name;
            this.gun = gun;
            this.lives = lives;
            this.cooldown = cooldown;

        }


        public void DisplayEnemyInfo()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.gun);
        }

        public String GetInfo()
        {
            return "The name of the enemy is: "+this.name+" GUN type: "+this.gun+" amount of lives: "+this.lives+" reload time "+this.cooldown;
        }

    }
}