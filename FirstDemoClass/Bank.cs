using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a class Bank with acc no, name, account type, balance .
//assign the value using non parametric & parametric constructor & display the details
namespace FirstDemoClass
{
    internal class Bank
    {
        private int account_no;
        private string holder_name , account_type;
        private double account_balance;

        public Bank()
        {
            account_no = 1234567;
            holder_name = "Snehal";
            account_type = "Saving";
            account_balance = 10000;
        }

        public Bank(int a_no , string h_name , string a_type ,  double a_balance)
        {
            account_no = a_no;
            holder_name = h_name;
            account_type = a_type;
            account_balance = a_balance;
        }

        public string PrintBank()
        {
            return $"Account No = {account_no} \nHolder Name = {holder_name} \nAccount Type = {account_type} \nAccount Balance = {account_balance}";
        }
    }
}
