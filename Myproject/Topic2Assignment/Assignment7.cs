using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Topic2Assignment
{
    class Assignment7
    {
        //Write a programme to check whether a character is alphabate ,digit or special character.

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character.");
            char ch = Console.ReadLine()[0];

            if((ch >= 'A' && ch <= 'Z' ) || (ch >= 'a' && ch <= 'z'))
            {
                Console.WriteLine("The character is an alphabet.");
            }
            else if((ch >= 0 && ch <=9 ))
            {
                Console.WriteLine("The character is a number or digit.");
            }
            else
            {
                Console.WriteLine("The character is special symbol");
            }

        }
    }
}
