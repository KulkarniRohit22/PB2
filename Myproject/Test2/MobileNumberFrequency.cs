using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Test2
{
    class MobileNumberFrequency
    {
        static int Digitsfrequency(int a,int d)
        {
            int x = 0;

            while (a > 0)
            {
                if (a % 10 == d)
                    x++;
      
                a = a / 10;
            }
            return x;
        }

        static public void Main(String[] args)
        {
            Console.WriteLine("Enter a mobile number.");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Which number's frequency would you like to find?");
            int D = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Digitsfrequency(N, D));

        }
    }


}

