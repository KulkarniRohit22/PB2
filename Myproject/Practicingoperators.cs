using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class Practicingoperators
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 2;
            int c = 2;
            int x;

            x = a++ + b++ + c++;
            Console.WriteLine(x +" "+a+" "+b+" "+c);

            x = ++a + ++b + ++c;
            Console.WriteLine(x + " " + a + " " + b + " " + c);

            x = --a - b++ - c--;
            Console.WriteLine(x + " " + a + " " + b + " " + c);

            x = ++c - a - --b + a--;
            Console.WriteLine(x + " " + a + " " + b + " " + c);


            Console.WriteLine((4+4*2)/2+9);
            Console.WriteLine(7*2/1+1*8/2);
            Console.WriteLine(144/12+(9*8/2));
            Console.WriteLine(7+3-2*3);
        }
        

    }
}
