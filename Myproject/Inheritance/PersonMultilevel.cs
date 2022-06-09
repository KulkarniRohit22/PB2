using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Inheritance
{
    class PersonMultilevel
    {
        protected string address = "Pune";
        protected string name = "Aadarsh";


        public void Show()
        {
            Console.WriteLine(address+" "+name);
        }
    }

    class Student:PersonMultilevel
    {
        protected int id = 1;
        protected int marks = 90;


        public void Display()
        {
            Console.WriteLine(id+" "+marks);
        }
    }

    class Employee:Student
    { 
       protected int empid = 101;
       protected string position = ".Net Developer";

        public void Print()
        {
            Console.WriteLine(empid+" "+ position);
        }
    }


    class MultilevelDemo
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Show();
            e.Print();
            e.Display();

        }
    }

}
