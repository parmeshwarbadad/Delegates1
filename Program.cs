using System;

namespace Delegates1
{
    class Delegates2
    {
        
           // Decleare delegate
        public delegate void Mydelegate(int x);
        public void Square(int a)
        {
            Console.WriteLine("square "+a*a);
        }
        static void Main(string[] args)
        {
            //set delegare
            Delegates2 ob = new Delegates2();
            Mydelegate d1 = ob.Square;
            d1(7);
        }

        
    }
}
