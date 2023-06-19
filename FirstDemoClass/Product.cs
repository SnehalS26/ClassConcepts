using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemoClass
{
    internal class Product
    {
        private int code;
        private string p_name;
        private double p_price;

        //Property Syntax --> access specifier property type property name

        public int Code
        {
            set { code = value; } // value is a built in keyword which assign the value
            get { return code; }
        }
        public string Prod_name
        {
            set { p_name = value; }
            get { return p_name; }
        }

        public double Prod_price
        {
            set { p_price = value; }
            get { return p_price; }
        }




        /*
        //Dafault Constructor
        public Product()
        {
            code = 10001;
            p_name = "Mobile";
            p_price = 100000;
        }

        //Parameterized Cpnstructor
        public Product(int cd, string name , double price)
        {
            code=cd;
            p_name = name;
            p_price = price;
        }
        public void AcceptProduct(int cd, string name, double price)
        {
            code = cd;
            p_name = name;
            p_price = price;
        }
        */

        // to display product.. will write method

        public string PrintProduct()
        {
            return $"Product Code is {code} \nProduct Name is {p_name} \nProduct Price is {p_price}";
        }
    }
}
