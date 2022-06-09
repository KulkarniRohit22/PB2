using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Containment
{

    class Nib
    {
        string ntype;

        public Nib(string ntype)
        {
            this.ntype = ntype;
        }

        public void display()
        {
            Console.WriteLine(ntype);
        }
    }

    class Pen
    {
        string color;
        string pname;
         Nib n;

        public Pen(string color,string pname,Nib n)
        {
            this.color = color;
            this.pname = pname;
           this.n = n;
        }

        public void show()
        {
            Console.WriteLine(color+" "+pname);
            n.display();
        }

    }

    
    class Bag
    {
        public string bname;
        public string color;
        Pen p;
        

        public Bag(string bname,string color,Pen p)
        {
            this.bname = bname;
            this.color = color;
            this.p = p;
            
        }


        public void print()
        {
            Console.WriteLine(bname+" "+color);
            p.show();
        }


        static void Main(string[] args)
        {
             Nib b = new Nib("metal");
            Pen n = new Pen("blue", "Fountain",b);
            Bag g = new Bag("American_Tourister","Black",n);
            g.print();

        }
    }
}
