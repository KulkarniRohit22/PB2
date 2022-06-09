using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.OOPs
{
    static class StaticClass
    {
        public static int x = 100;
        public static void read()
        {
            Console.WriteLine("Hi this is read!!");
        }


    }

    class StaticClassDemo
    {
        static void Main(string[] args)
        {
                Console.WriteLine(StaticClass.x);
                StaticClass.read();
        }
    }


    
}
