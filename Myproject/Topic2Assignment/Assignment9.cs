using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Topic2Assignment
{
    class Assignment9
    {
        /* Write a program to input basic salary of an employee and calculate its
             Gross salary according to following:
                     Basic Salary <= 10000 : HRA = 20%, DA = 80% 
                     Basic Salary <= 20000 : HRA = 25%, DA = 90% 
                     Basic Salary >20000 : HRA = 30%, DA = 95% 
*/

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the basic salary.");
            int basic_salary = Convert.ToInt32(Console.ReadLine());
            int gross_salary = 0;
            int HRA = 0;
            int DA = 0;

            if(basic_salary <= 10000)
            {
                HRA = (basic_salary * 20) / 100;
                DA = (basic_salary * 80) / 100;
            }
            else if(basic_salary <= 20000)
            {
                HRA = (basic_salary * 25) / 100;
                DA = (basic_salary * 90) / 100;
            }
            else if(basic_salary > 20000)
            {
                HRA = (basic_salary * 30) / 100;
                DA = (basic_salary * 95) / 100;
            }

            gross_salary = basic_salary + HRA + DA;
            Console.WriteLine(gross_salary);
        }
    }
}
