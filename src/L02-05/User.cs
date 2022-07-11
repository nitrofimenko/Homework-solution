using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_05
{
    internal class User
    {
        string login = "";
        string firstName = "";
        string secondName = "";
        int age;
        readonly DateTime formFillingDate;
        public User()
        {
            Console.WriteLine("Creation new user");

            Console.Write("Input new user login: ");
            login = Console.ReadLine();

            Console.Write("Input new user first name: ");
            firstName = Console.ReadLine();

            Console.Write("Input new user second name: ");
            secondName = Console.ReadLine();

            do
            {
                Console.Write("Input new user age (integer number): ");
            } while (!int.TryParse(Console.ReadLine(), out age) || age <= 0); ;

            formFillingDate = DateTime.Now;
        }
        public void Show()
        {
            Console.WriteLine($"Login:             {login}");
            Console.WriteLine($"First name:        {firstName}");
            Console.WriteLine($"Second name:       {secondName}");
            Console.WriteLine($"Age on {formFillingDate:dd.MM.yyyy}: {age}");
        }
    }
}
