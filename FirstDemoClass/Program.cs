using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstDemoClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Date date1 = new Date();
            //Console.WriteLine(date1.PrintDate()); //Default Constructor
            //Date date2 = new Date(17, "June" , 2023); //Parameterized Constructor
            //Console.WriteLine(date2.PrintDate()) ;
            //date1.AcceptDate(16, "June", 2023); 
            //string data = date1.PrintDate();
            //Console.WriteLine(data);
            //int year = date1.PrintYear();
            //Console.WriteLine(year);

            /*================================================================================*/

            //Create a class EMployee with empid, name, salary, accept the data & print it

            //Employee emp1 = new Employee();
            //Console.WriteLine(emp1.PrintEmployee()); //Default Constructor
            //Employee emp2 = new Employee(1001, "Snehal s" , 20000); //Parameterized Constructor
            //Console.WriteLine(emp2.PrintEmployee());
            //emp1.AcceptEmployee(1001, "Snehal s", 20000);
            //string emp = emp1.PrintEmployee();
            //Console.WriteLine(emp);

            // year parameter is optional to pass
            Employee emp1 = new Employee(201, "Raj" , 25000);
            Console.WriteLine(emp1.PrintEmployee());

            //can be pass explicit value, value will be override
            Employee emp2 = new Employee(201, "Raj", 25000, "Beed");
            Console.WriteLine(emp2.PrintEmployee());

            //named argument
            Employee emp3 = new Employee(id: 202, name: "Nikita", sal: 30000, city: "Nagar");
            Console.WriteLine(emp3.PrintEmployee());


            /*==============================================================================*/

            //Create class Student with rollno, name & percentage.Accept the data & print it

            //Student stud1 = new Student();
            //Console.WriteLine(stud1.PrintStudent()); //Default Constructor
            //Employee emp2 = new Employee(100, "Snehal s", 80); //Parameterized Constructor
            //Console.WriteLine(emp2.PrintEmployee());
            //stud1.AcceptStudent(100, "Snehal s", 87);
            //string stud = stud1.PrintStudent();
            //Console.WriteLine(stud);

            /*===============================================================================*/

            //Create class Product with code,name & price , accept the data & print it

            //Product prod1= new Product();
            //Console.WriteLine(prod1.PrintProduct());  //Default Constructor
            //Product prod2= new Product(201 , "Mouse" , 3000);
            //Console.WriteLine(prod2.PrintProduct());  //Parameterized Constructor
            //prod1.AcceptProduct(301, "Keyboard", 4000);
            //string prod = prod1.PrintProduct();
            //Console.WriteLine(prod);

            //Product Property Syntax [set get Method]
            /*
             Product prod1 = new Product();
             prod1.Code = 1001;    // call to set accessor
             prod1.Prod_name = "Machine";
             prod1.Prod_price = 5000;

             //get accessor
             Console.WriteLine($"Product Code = {prod1.Code} \nProduct Name = {prod1.Prod_name} \nProduct Price = {prod1.Prod_price}");

             // object initializer syntax

             Product prod2 = new Product() { Code = 1002 , Prod_name = "Freeze" , Prod_price = 25000};

             Console.WriteLine($"Product Code = {prod1.Code} \nProduct Name = {prod1.Prod_name} \nProduct Price = {prod1.Prod_price}");
             Console.WriteLine(prod2.PrintProduct());
            */
            /*==================================================================================*/

            // Create a class Book with book id , name, price & author name.
            //Assign value using non parametric & parametric constructor & display the details

            //Book b1 = new Book();
            //Console.WriteLine(b1.PrintBook());  //Default Constructor
            //Book b2 = new Book(102, "Mrutyunjay" , "Shivaji" , 350);   //Parameterized Constructor
            //Console.WriteLine(b2.PrintBook());  

            /*====================================================================================*/

            //Create a class Bank with acc no, name, account type, balance .
            //assign the value using non parametric & parametric constructor & display the details

            //Bank bank1 = new Bank();
            //Console.WriteLine(bank1.PrintBank());   //Default Constructor
            //Bank bank2 = new Bank(765432 , "Swapnil" , "Current" , 15000);  //Parameterized Constructor
            //Console.WriteLine(bank2.PrintBank());

            /*====================================================================================*/

            //Create class User with user id, user name, email & password. 
            // Assign value using parametric constructor &display the details

            //User u1 = new User();
            //Console.WriteLine(u1.PrintUser());  //Default Constructor
            //User u2 = new User(2 , "Viraj" , "viraj@123" , "pass12");  //Parameterized Constructor
            //Console.WriteLine(u2.PrintUser());
        }
    }
}
