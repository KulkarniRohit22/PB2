using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Inheritance
{
    class Bike
    {
        public string engine = "150cc";
    }


    class pulsar: Bike
    {
        public void Display()
        {
            Console.WriteLine(engine);
        }
        public string color = "red";
        public string company = "bajaj";
        public int price = 90000;



        public void show()
        {
            Console.WriteLine(color+" "+ company+" "+ price);
        }
    }


    class SingleDemo2
    {
        static void Main(string[] args)
        {
            pulsar p = new pulsar();
            p.Display();
            p.show();
        }
        
    }
}
