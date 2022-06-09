using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class Employee
    {
        int id;
        string name;
        int salary;

        public void accept_Details()
        {
            id = 1;
            name = "amit";
            salary = 890000;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.accept_Details();
            e.display();
        }
    }
}
