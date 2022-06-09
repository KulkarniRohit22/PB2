using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class Students
    {
        int id;
        string name;
        int mathematics, biology, physics;
        double percentage;

        public void acceptDetails()
        {
            id = 101;
            name = "Aadarsh";
            mathematics = 90;
            biology = 87;
            physics = 82;
        }

        public void percentageOfStudent()
        {
            int obtained_marks = mathematics + biology + physics;
           percentage = (obtained_marks)/300f * 100f;
            
        }
        public void display()
        {
            Console.WriteLine(id + " " +name+ " "+mathematics+ " "+ biology+ " " + physics+ " " + percentage );
        }
        static void Main(string[] args)
        {
            Students stud = new Students();
            stud.acceptDetails();
            stud.percentageOfStudent();
            stud.display();

        }
    }
}
