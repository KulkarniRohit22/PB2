using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Containment
{

    class Nib1
    {
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }

    class Pen1
    {

        private string pcolor;
        private string pname;
        private Nib1 nib;

        public String Pcolor
        {
            get { return pcolor; }
            set { pcolor = value; }
        }

        public String Pname
        {
            get { return pname; }

            set { pname = value; }
        }


        public Nib1 Nib
        {
            get { return nib; }
            set { nib = value; }
        }

    }


    class Bag1
    {
        private string bname;
        private string bcolor;
        private Pen1 pen;

        public String Bname
        {
            get { return bname; }
            set { bname = value; }
        }

        public String Bcolor
        {
            get { return bcolor; }
            set { bcolor = value; }
        }

        public Pen1 Pen
        {
            get { return pen; }
            set { pen = value; }

        }

        static void Main(string[] args)
        {
            Nib1 n = new Nib1();
            n.Type = "metal";
            Pen1 p = new Pen1();
            p.Pcolor = "Black";
            p.Pname = "Fountain";
            p.Nib = n;
            Bag1 b = new Bag1();
            b.Bname = "American_tourister";
            b.Bcolor = "Blue";
            b.Pen = p;


            Console.WriteLine( p.Nib.Type+" "+b.Bname+" " +b.Bcolor+" "+b.Pen.Pcolor+" "+b.Pen.Pname);
        }
    }   
}