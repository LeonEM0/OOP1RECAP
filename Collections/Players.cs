using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Players
    {
        public String username;
        public int id;
        public float score;
        public char gender;
        
        public Players(string username,int id, float score, char gender)
        {
            this.username = username;
            this.id = id;
            this.score = score;
            this.gender = gender; 
        }

        public override string ToString()
        {
            return "The username of the student is:\t" + username + "The id of the student is:\t" + id + "the score of the student is:\t" + score + "The gender of the student is:\t" + gender;
        }

        /*public override string ToString()
        {
            return base.ToString();
        }
        */

    }
}
