using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class AgeDetector
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter an age: ");
            age = Convert.ToInt32(Console.ReadLine());

            if(age >= 13 && age <= 19)
            {
                Console.WriteLine("The person is not a teenager anymore!");
            }
            else
            {
                Console.WriteLine("The person is teenager!!!");
            }
        }
    }
}
