using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class MockExam2
    {
        private string name;
        private int roll_number;
        



        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Roll_number
        {
            get { return roll_number; }
            set { roll_number = value; }

        }

        static void Main(string[] args)
        {
            MockExam2 m = new MockExam2();
            m.Name = "Rohit";
            m.Roll_number = 21;

            Console.WriteLine(m.Name +" " +m.Roll_number);
        }
    }
}
