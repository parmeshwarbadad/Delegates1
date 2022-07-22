using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates1
{
    class Demo2
    {
        //declare deligate
        //set target
        //invoke 

        public delegate int Delegare1(int a);
        public static int Factorial(int a)
        {
            int f = 1;
            for(int i=1;i<=a;i++)
                {
                    f = f * 1;
                }
            return f;
        }
        public static void Cube(int x)
        {
            Console.WriteLine("cube "+x*x*x);
        }
        static void Main(string[] args)
        {
            Delegare1 d1 = Factorial;
            
            Console.WriteLine(d1(5));
        }
    }
}
