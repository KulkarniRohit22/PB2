using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.OOPs
{
    class StaticMethodDemo
    {
        static int y = 10;
        int x = 30;


        static StaticMethodDemo()
        {
            Console.WriteLine("Hii this is defualt");
        }


        void show()
        {
            y = 40;
            Console.WriteLine("hi this is show " + y + " " + x);
        }


        static void read()
        {
            StaticMethodDemo m = new StaticMethodDemo();
            Console.WriteLine("Hi this is read " + y + " " + m.x);
        }


        static void Main(string[] args)
        {
            StaticMethodDemo d = new StaticMethodDemo();
            d.show();
           // StaticMethodDemo.read();
           // StaticMethodDemo d1 = new StaticMethodDemo();
            //StaticMethodDemo d2 = new StaticMethodDemo();
            //read();
        }
    }
}
