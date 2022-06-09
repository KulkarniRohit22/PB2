using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Myproject
{
    class Student
    {
        private int id;
        private string name;
        private double percentage;
        public Student(int id, string name, double percentage)
        {
            this.id = id;
            this.name = name;
            this.percentage = percentage;
        }
        public override string ToString()
        {
            if (percentage > 75)
            {
                return $" {id} {name} {percentage}";

            }
            return "0";
        }
    }
    class Demo
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(new Student(1, "Aadarsh", 90));
            al.Add(new Student(2, "Jayraj", 72));
            al.Add(new Student(3, "Siddhant", 89));
            al.Add(new Student(4, "Dheeraj", 68.78));
            al.Add(new Student(5, "Onkar", 78.65));


            foreach (var x in al)
            {
                Console.WriteLine(x);
            }
        } 
    }
}
