using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_05
{
    internal class User
    {
        string login;
        string firstName;
        string lastName;
        int age;
        readonly DateTime formFillingDate;
        public User(string userLogin, string userFirstName, string userLastName, int userAge)
        {
            login = userLogin;
            firstName = userFirstName;
            lastName = userLastName;
            age = userAge;
            formFillingDate = DateTime.Now;
        }
        public void Show()
        {
            Console.WriteLine($"Login:             {login}");
            Console.WriteLine($"First name:        {firstName}");
            Console.WriteLine($"Second name:       {lastName}");
            Console.WriteLine($"Age on {formFillingDate:dd.MM.yyyy}: {age}");
        }
    }
}
