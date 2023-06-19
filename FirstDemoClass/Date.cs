using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemoClass
{
    internal class Date
    {
        // assign to DAta member 
        private int date, year;
        private string month;

        //Default OR Non Paramatric Constructor
        public Date()
        {
            date = 17;
            month = "June";
            year = 2023;
        }

        //Paramatric Constructor
        public Date(int dd, string mm, int yy)
        {
            date=dd;
            month = mm;
            year = yy;
        }
        public string PrintDate()
        {
            return $"Date is -{date} -{month} - {year}";
        }

        //Using Method Class
        /*public void AcceptDate(int dd, string mm, int yy)//parameter List
        {
            date = dd;
            month = mm;
            year = yy;
        }

        public string PrintDate()
        {
            return $"Date is -{date} -{month} - {year}";
        }

        public int PrintYear()
        {
            return year;
        }*/
    }
}
