using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.OOPs
{
    class ConstructorDemo
    {

        public ConstructorDemo()
        {
            Console.WriteLine("Hi i am defualt");
        }

        public ConstructorDemo(int x)
        {
            Console.WriteLine("This is my perimeterized constructor");
        }

       public void add()
        {
            
            Console.WriteLine("Addition:");

        }


        private ConstructorDemo(string name)
        {
            Console.WriteLine(name);
        }

        static void Main(string[] args)
        {
            ConstructorDemo d = new ConstructorDemo();
            ConstructorDemo d1 = new ConstructorDemo(400);
            ConstructorDemo d3 = new ConstructorDemo("pune");
            d3.add();

            //Demo demo = new Demo();

            //demo.print();
        }
    }
}
