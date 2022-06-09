using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.OOPs
{
    class Student1
    {
        private int id;
        private string name;
        private double percentage;

        public int Id
        {
            get { return id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public double Percentage
        {
            get { return percentage; }
            set { this.percentage = value; }
        }

        static void Main(string[] args)
        {
            Student1 stud = new Student1();
            stud.Id = 101;
            Console.WriteLine(stud.Id);
            stud.Name = "Aadarsh";
            Console.WriteLine(stud.Name);
            stud.Percentage = 89.34;
            Console.WriteLine(stud.Percentage);
        }
    }
}
