using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates1
{
    public delegate int mydel1(int a, int b);
    class Class2
    {
        static void Main(string[] args)
        {
            mydel1 d1 = delegate (int x, int y)
            {
                Console.WriteLine("sum= " + (x + y));
                return x + y;
            };
            d1(10, 20);


            //lambda expression
            mydel1 d2 = (x, y) =>
              {
                  Console.WriteLine("Addition= "+(x+y));
                  return x + y;
              };
            d2(10, 20);
        }
    }
}
