using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Myproject
{
    class Person
    {
        int id;
        string name;
        ArrayList hobbies;

        public Person(int id, string name, ArrayList hobbies)
        {
            this.id = id;
            this.name = name;
            this.hobbies = hobbies;
        }



    }
    class TestPerson
    {
        static void Main(string[] args)
        {
            ArrayList plist = new ArrayList();
            do
            {
                Console.WriteLine("Enter the id,name, hobbies");
                int id = int.Parse(Console.ReadLine());
                string name = Console.ReadLine();

                Console.WriteLine("Enter number of hobbies you have");
                int c = int.Parse(Console.ReadLine());

                ArrayList hobbies = new ArrayList();


                for (int i = 0; i < c; i++)
                {
                    Console.WriteLine($"{name} enter your hobbies");
                    string h = Console.ReadLine();
                    hobbies.Add(h);                
                }

                Person p = new Person(101, "Rohit", hobbies);
                plist.Add(p);

                Console.WriteLine("Do you want to add another person object yes/no");

                string choice = Console.ReadLine().ToLower();

                if(choice== "no")
                {
                    break;
                }

            } while (true);
        }
    }

}
