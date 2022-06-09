using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Myproject.Test4
{
    class StudentWithArraylist
    {
        int stud_id;
        string sname;
        ArrayList hobbies;

        public StudentWithArraylist(int stud_id, string sname, ArrayList hobbies)
        {
            this.Stud_id = stud_id;
            this.Sname = sname;
            this.Hobbies = hobbies;
        }

        public int Stud_id { get => stud_id; set => stud_id = value; }
        public string Sname { get => sname; set => sname = value; }
        public ArrayList Hobbies { get => hobbies; set => hobbies = value; }


        static void Main(string[] args)
        {
            ArrayList h = new ArrayList();
            h.Add("Read");
            h.Add("swim");
            h.Add("chess");

            StudentWithArraylist s = new StudentWithArraylist(101,"Aadarsh",h);

            ArrayList a = new ArrayList();
            a.Add("cricket");
            a.Add("workout");

            StudentWithArraylist s1 = new StudentWithArraylist(102, "Vaibhav", a);

            Console.WriteLine(s.ToString());
            Console.WriteLine(s1.ToString());



        }
    }
}
