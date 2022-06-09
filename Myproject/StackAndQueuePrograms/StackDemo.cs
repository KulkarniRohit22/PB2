using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Myproject.StackAndQueuePrograms
{
    class StackDemo
    {
        static void Main(string[] args)
        {
            //LIFO 
            Stack st = new Stack();
            st.Push("Aadarsh");
            st.Push("Jayraj");
            st.Push("Siddhant");

            //push = add
            //pop = remove and then returns the value

            foreach(object ob in st)
            {
                Console.WriteLine(ob);
            }

            string d = (string)st.Pop();
            Console.WriteLine("Removed ==>" + d);

            Console.WriteLine("Peek: "+ st.Peek()); // the difference between pop and peek is that, pop removes the data from the stack and then returns it.
                                                     //whereas peek just shows what is present at the top of the stack. peek does not remove the data that is stored inside the stack.

            foreach(object ob in st)
            {
                Console.WriteLine(ob);
            }
        }
    }


    class QuequeDemo
    {
        static void Main(string[] args)
    {
        Queue q = new Queue();
        q.Enqueue(10);
        q.Enqueue("raj");
        q.Enqueue("shree");
        Console.WriteLine(q);

        int d = (int)q.Dequeue();
        Console.WriteLine(q.Peek());
        Console.WriteLine("remove" + d);

        foreach (var i in q)
        {
            Console.WriteLine(i);
        }

    }
}
}
