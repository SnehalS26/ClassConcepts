using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemoClass
{
    internal class Employee
    {
        private int empid;
        private string empName, city;
        private double salary;

        // Employee class (id, name, salary, city) with default city as Pune &
        // use named argument & optional parameter to get the data.
        // Create object to get the optional value & also override the Pune with any another city
        //Add Display() to display emp data.

        //Default Parameter
        public Employee(int id, string name, double sal, string city = "Pune")
        {
            empid = id;
            empName = name;
            salary = sal;
            this.city = city;
        }



        /*
        //Default Constructor
        public Employee()
        {
            empid = 1;
            empName = "Snehal S";
            salary = 20000;
        }

        
        //Parameterized Constructor
        public Employee(int id, string name, double sal)
        {
            empid = id;
            empName = name;
            salary = sal;
        }
        public void AcceptEmployee(int id, string name, double sal)
        {
            this.empid = id;
            this.empName = name;
            this.salary = sal;
        }
        */

        public string PrintEmployee()
        {
            return $"Emp-id is {empid} \nEmp Name is {empName} \nEmp Salary is {salary} \nCity = {city}";

        }
    }
}
