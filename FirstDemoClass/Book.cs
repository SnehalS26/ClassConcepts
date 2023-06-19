using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a class Book with book id , name, price & author name.
//Assign value using non parametric & parametric constructor & display the details
namespace FirstDemoClass
{
    internal class Book
    {
        private int book_id;
        private string book_name, author_name;
        private double book_price;

        public Book()
        {
            book_id = 101;
            book_name = "Yayati";
            author_name = "Khandekar";
            book_price = 500;
        }

        public Book(int id, string name, string a_name, double price)
        {
            book_id = id;
            book_name = name;
            author_name = a_name;
            book_price = price;
        }
        public string PrintBook()
        {
            return $"Book id = {book_id} \nBook Name = {book_name} \nBook Author = {author_name} \nBook Price = {book_price}";
        }
    }
}
