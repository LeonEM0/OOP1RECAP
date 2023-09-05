using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorandBaseKeyword
{
    public class Test
    {
       public bool a;
       public int b;
       public string c;
       public float d;
        private Test(bool a, int b) //1
        {
            this.a = a;
            this.b = b;
            Console.WriteLine("Base Constructor");
            Console.WriteLine(this.a+" "+this.b);


        }
        public Test(bool a,int b,string c):this(a, b)//2
        {
            this.c = c;
            Console.WriteLine("Derived Constructor");

            Console.WriteLine("{0}{1}{2}",a,b,c);

        }
        public Test(bool a, int b, float d):this(a,b) //2
        {
            this.d = d;
            Console.WriteLine("Derived Constructor");
            Console.WriteLine("{0}{1}{2}", a, b, d);


        }


        public override string ToString()
        {
            return "Value in a"+a+"value in b"+b+"value in c"+c+"value in d"+d;
        }
    }
}
