using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Containment
{


    class Engine
    {
        string etype;

        public Engine(string etype)
        {
            this.etype = etype;
        }


        public void show()
        {
            Console.WriteLine(etype);
        }
    }
    class Car
    {
        int id;
        string name;
        int price;
        Engine eng;

        public Car(int id,string name,int price,Engine eng)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.eng = eng;
        }

        void display()
        {
            Console.WriteLine(id + " " + name + " " + price );
            eng.show();
        }

        static void Main(string[] args)
        {
            Engine e = new Engine("petrol");
            Car c = new Car(1,"Aston Martin",6000000,e);
            c.display();
        }

    }
}
