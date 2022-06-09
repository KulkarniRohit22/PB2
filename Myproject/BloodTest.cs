using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class BloodTest
    {
        static void Main(string[] args)
        {
            int age, weight;
            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your weight: ");
            weight = Convert.ToInt32(Console.ReadLine());

            if (age > 18)
            { 
              if(weight > 50)
                {
                    Console.WriteLine("Congrats!! You are eligible to give the blood test.");
                }
                else
                {
                    Console.WriteLine("Sorry you are not eligible for blood test.");
                }
            }
            else if (age < 18)
            {
                Console.WriteLine("sorry you are not elilible for blood test.");
            }

            /*if(age > 18 && weight > 50)
            {

                Console.WriteLine("Congrats!!You are eligible to give a blood test.");
            }
            else
            {
                Console.WriteLine("Sorry!You are not eligible to give a blood test.");
            }*/

        }
    }
}
