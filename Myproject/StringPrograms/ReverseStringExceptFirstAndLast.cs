using System;

namespace Myproject.StringPrograms
{
    class ReverseStringExceptFirstAndLast
    {
        static void Main(string[] args)
        {
            string str = "My favoriate movie is the dark knight ";
            string reverse = " ";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse = reverse + str[i];

              /*  if(str[0] || str[])*/
                {

                }
            }
            Console.WriteLine(reverse);
        }
    }
}
