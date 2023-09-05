using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorandBaseKeyword
{
    //Constructor and base keyword
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Base");
            Test test1 = new Test(true,5,2.5f);
            Console.ReadLine();
        }
    }
}
//Check pivot position unity