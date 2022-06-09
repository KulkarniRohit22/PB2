using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class Friend
    {
        static void Main(string[] args)
        {
            int myage, friendsage;
            Console.WriteLine("Enter your age: ");
            myage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your friend's age: ");
            friendsage = Convert.ToInt32(Console.ReadLine());

            if(friendsage < myage)
            {
                Console.WriteLine("Hii!!!");
            }
            else if(friendsage > myage )
            {
                Console.WriteLine("Good Morning!!!");
            }
            else
            {
                Console.WriteLine("how are you!!!");
            }

        }
    }
}
