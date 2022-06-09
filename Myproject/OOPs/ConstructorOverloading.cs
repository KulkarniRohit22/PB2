using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.OOPs
{
    class ConstructorOverloading
    {
        public  ConstructorOverloading()
        {
            Console.WriteLine("This is a default constructor");
        }

        public ConstructorOverloading(int x)
        {
            
            Console.WriteLine(x);
        }

        public ConstructorOverloading(int x , int y)
        {
            Console.WriteLine(x + y);
        }

        public ConstructorOverloading(int a, float b,double c)
        {
            Console.WriteLine(a - b -c);
        }

        static void Main(string[] args)
        {
            ConstructorOverloading c = new ConstructorOverloading();
            ConstructorOverloading c1 = new ConstructorOverloading(400);
            ConstructorOverloading c3 = new ConstructorOverloading(3, 4);
            ConstructorOverloading c4 = new ConstructorOverloading(12, 3.3f,11.01);
        }
    }
}
