using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.OOPs
{
    class StudentInfo
    {

        int id;
        string name;
        int marks;

        public StudentInfo(int sid, string sname, int smk)
        {
            id = sid;
            name = sname;
            marks = smk;
        }
        void display()
        {
            Console.WriteLine(id + " " + name + " " + marks);
        }

        static void Main(string[] args)
        {
            StudentInfo s = new StudentInfo(101, "Aadarsh ", 89);
            s.display();
        }
    }
}
