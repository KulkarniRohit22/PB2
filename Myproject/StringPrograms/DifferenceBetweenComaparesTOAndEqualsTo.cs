using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.StringPrograms
{
    class DifferenceBetweenComaparesTOAndEqualsTo
    {
        static void Main(string[] args)
        {
            string s = "Hello";
            string s1 = "hello";

            String s2 = new string("Hello");

            //Using "==" operator.

            Console.WriteLine(s==s1);// "==" operator is used to check address comparison.
            Console.WriteLine(s==s2);

            //Using "Equals" Method.

            Console.WriteLine(s.Equals(s2));
            Console.WriteLine(s.Equals(s1));

            //Using "Comspare To" Operator.

            Console.WriteLine(s.CompareTo(s2));
            Console.WriteLine(s.CompareTo(s1));
            Console.WriteLine(s1.CompareTo(s2));


            // INTERPOLATION.

            String msg = "  Welcome To India  ";
            String mymsg = $"Hello {msg}";//To perform an interpolation we have to take "$".
            Console.WriteLine(mymsg);


            char[] ch = msg.ToCharArray();
            Console.WriteLine(String.Join(" ",ch));


            //Upper and Lower string Demo.

            Console.WriteLine("Upper String is : " +msg.ToUpper());
            String newmsg = msg.ToLower();
            Console.WriteLine("Lower String is: " +newmsg);


            // Spliting string.

            String[] splitword = msg.Split(" ");

            foreach(String st in splitword)
            {
                Console.WriteLine(st);
            }


            // Trim Method.
            Console.WriteLine(String.Join(" ",msg));
            Console.WriteLine(msg.Trim());// you can use TrimStart to delete the extra spaces from the start of the msg and TrimEnd will delete the extra spaces that are present at the end of an array.


            // Replace Method.
           
            Console.WriteLine(msg.Replace('W','w'));

            
        }
    }
}
