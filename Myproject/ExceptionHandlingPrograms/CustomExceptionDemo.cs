using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.ExceptionHandlingPrograms
{
    class Demo:ApplicationException
    {
       
            public Demo(string msg) : base(msg)
            {

            }
        
        class User
        {
            string nm;
            long mobile;
            string password;
            public void accept()
            {
                Console.WriteLine("Enter mobile number,name,Passs");
                nm = Console.ReadLine();
                mobile = long.Parse(Console.ReadLine());
                password = Console.ReadLine();
                validate();

            }
           public void validate()
            {
                if (password.Length < 8)
                {
                    throw new Demo("Password size should br greater than 8");
                }

            }
        }

        class CustomExceptionDemo
        {
            static void Main(string[] args)
            {
                User u = new User();
                while (true)
                {
                    try
                    {
                        u.accept();
                        break;
                    }
                    catch (Demo e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                Console.WriteLine("Main ends");
            }
        }
    }
}
