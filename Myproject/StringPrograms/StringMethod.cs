using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.StringPrograms
{
    class StringMethod
    {
        static void Main(string[] args)
        {
            String str = "India is my country";
            int l = str.Length;
            Console.WriteLine(str.Length);
            Console.WriteLine("No of char in a string are :  " + l);

            Console.WriteLine(str);
            String st1 = str.Substring(6);
            Console.WriteLine("My String is :" +st1);

            String st2 = str.Substring(0,6); //substring (Char initial, char final)
            Console.WriteLine("My String is :" + st2);

            // Index OF Method;

            Console.WriteLine("......"+str.IndexOf('i'));

            Console.WriteLine("......."+str.LastIndexOf('i'));


            Console.WriteLine("////////////////////////////////////////////");


            String str1 = "India is the best ";
            String merge = str + str1;
            Console.WriteLine(merge);


            String joinstring = string.Concat(str, ",", str1);
            Console.WriteLine("Concat string = " +joinstring);
        }
    }
}
