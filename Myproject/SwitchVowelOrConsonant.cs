using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class SwitchVowelOrConsonant
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter a character: ");
            ch = Console.ReadLine()[0];

            switch (ch)
            {
                case 'a':
                    Console.WriteLine("This is a vowel.");
                    break;
                case 'e':
                    Console.WriteLine("This is a vowel.");
                    break;
                case 'i':
                    Console.WriteLine("This is a vowel.");
                    break;
                case 'o':
                    Console.WriteLine("This is a vowel.");
                    break;
                case 'u':
                    Console.WriteLine("This is a vowel.");
                    break;
                default:
                    Console.WriteLine("This is a consonant.");
                    break;
            }
        }
    }
}
