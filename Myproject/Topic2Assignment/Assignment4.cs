using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Topic2Assignment
{
    class Assignment4
    {
        //Write a programme to check whether an alphabate is vowel or consonant.

        static void Main(string[] args)
        {
            Console.WriteLine("Enter an alphabate");
            char ch = Console.ReadLine()[0];

            if(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("The character is vowel.");
            }
            else
            {
                Console.WriteLine("The character is a consonant");
            }
        }
    }
}
