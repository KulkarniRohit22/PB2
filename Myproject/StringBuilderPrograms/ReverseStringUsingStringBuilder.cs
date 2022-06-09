using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.StringBuilderPrograms
{
    public class ReverseStringUsingStringBuilder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string to reverse :");
            string name = Console.ReadLine();

            StringBuilder builder = new StringBuilder();
            for (int i = name.Length - 1; i >= 0; i--)
            {
                builder.Append(name[i]);
            }
            string newName = builder.ToString();

            Console.WriteLine(newName);
        }
    }
}
