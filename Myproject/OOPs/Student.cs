using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.OOPs
{
    class Student
    {
        int id;
        string name;
     
        public Student()
        {
            Console.WriteLine("This is a default construction!!");
        }

        public Student(int id,string name)  //: this()
        {
            this.id = id;
            this.name = name;
            

        }
        static Student()
        {
            Console.WriteLine("This is a static construction");
        }
        public void multiplication(ref int a)
        {
              a *= a;
        }
        public void display()
        {
            Console.WriteLine(id+ " " + name );
        }
        static void Main(string[] args)
        {
            Student stu = new Student(101,"Aadarsh");
            // Student stud = new Student();
            Student stu1 = new Student(); 

            stu.display();
            int a = 10;
            Console.WriteLine("Variable Value Before Calling the Method:" + a);
            stu.multiplication(ref  a);
            Console.WriteLine("Variable Value After Calling the Method: " + a);
           
        }
    }
}
