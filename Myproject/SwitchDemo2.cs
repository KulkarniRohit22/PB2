
using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class SwitchDemo2
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter value");

            input = Console.ReadLine();

            switch(input)
            {
                case "happy": Console.WriteLine("Happy");
                    break;
                case "new": Console.WriteLine("New");
                    break;
                case "year": Console.WriteLine("Year");
                    break;
                default: Console.WriteLine("Invalid input.");
                    break;
            }
        }
    }
}
