 using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates1
{
    class Class4
    {
        static string greet()
        {
            return "good morning ";
        }

        static int product(int a, int b, int c)
        {
            return a * b * c;
        }
        static bool iseven(int x)
        {
            if (x % 2 == 0)
                return true;
            else
                return false;
            //return x % 2 == 0;
        }
        static void Main(string[] args)
        {
            Func<string> d1 = greet;

            Func<int, int, int, int> d2 = (a, b, c) => a * b * c;
            int prod = d2(2, 3, 4);
            Console.WriteLine("multiplication "+prod);

            Action<int, int> d3 = (a, b) => Console.WriteLine("Addition "+(a+b));
            d3(98, 1);

            Func<int, bool> d4 = iseven;
            bool b = d4(89);

            Predicate<int> d5 = iseven;
            bool bb = d5(78);

            // Func==> when a function compulsory return type value back
            // and can take zero or more parameter
            //action===> when function return type is void and can take zero or more parameter
            //Predicate when a function compulsory return boolean value and can take zero or more parameter
        }
    }
}
