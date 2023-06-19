using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemoClass
{
    internal class Student
    {
        private int roll_no;
        private string stud_name;
        private double percentage;

        //Default Constructor
        public Student()
        {
            roll_no = 101;
            stud_name = "Sneha";
            percentage = 90;
        }

        //Parameterized Constructor
        public Student(int no, string name, double perc)
        {
            roll_no = no;
            stud_name = name;
            percentage = perc;
        } 
        public void AcceptStudent(int roll, string name, double perc)
        {
            roll_no = roll;
            stud_name = name;
            percentage = perc;
        }

        public string PrintStudent()
        {
            return $"Roll_No is {roll_no}  \nStudent Name is {stud_name} \nPercentage is {percentage}";
        }
    }
}
