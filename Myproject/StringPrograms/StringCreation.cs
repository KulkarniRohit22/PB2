using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.StringPrograms
{
    class StringCreation
    {
        static void Main(string[] args)
        {
            string s = "Hello C#"; //using keyword
            String str = "Welcome C#"; //using System.String

            String s2 = new string("My C#");// using new keyword.


            char[] ch = { 'I', 'N', 'D', 'I', 'A' };

            string s3 = new string(ch);
            Console.WriteLine(s3);
        }
    }
}
