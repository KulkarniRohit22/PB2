using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.OOPs
{
    class ThisDemo
    {
        int x = 10;


        public ThisDemo() : this(78)
        {
            Console.WriteLine( "HI i am defualt");
        }

        public ThisDemo(int x)
        {
            Console.WriteLine("Hi x----" + x);
        }

        void read(int x)
        {
            this.x = x;
            this.show();
        }
        void show()
        {
            Console.WriteLine(x);
        }


        static void Main(string[] args)
        {
            ThisDemo d = new ThisDemo();
            ThisDemo d1 = new ThisDemo();
            d.read(500);
            d1.read(100);
            d.show();
        }
    }
}
