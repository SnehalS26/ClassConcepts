using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create class User with user id, user name, email & password. 
   // Assign value using parametric constructor &display the details
namespace FirstDemoClass
{
    internal class User
    {
        private int user_id;
        private string user_name, user_email , user_password;

        public User()
        {
            user_id = 1;
            user_name = "Raj";
            user_email = "raj@123";
            user_password = "password";
        }

        public User(int id, string name, string email, string password)
        {
            user_id = id;
            user_name = name;
            user_email = email;
            user_password = password;
        }

        public string PrintUser()
        {
            return $"User id = {user_id} \nUser Name ={user_name} \nUser Email = {user_email} \nUser Password = {user_password}";
        }
    }
}
