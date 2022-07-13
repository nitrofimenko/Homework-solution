using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_05
{
    internal class User
    {
        string Login { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        DateTime FormFillingDate { get; }
        public User(string login, string firstName, string lastName, int age)
        {
            Login = login;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FormFillingDate = DateTime.Now;
        }
        public void Show()
        {
            Console.WriteLine($"Login:             {Login}");
            Console.WriteLine($"First name:        {FirstName}");
            Console.WriteLine($"Second name:       {LastName}");
            Console.WriteLine($"Age on {FormFillingDate:dd.MM.yyyy}: {Age}");
        }
    }
}
