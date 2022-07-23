using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_05
{
    internal class UserFactory
    {
        public User CreateUser()
        {
            Console.Write("Input new user login: ");
            string login = Console.ReadLine();

            Console.Write("Input new user first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Input new user last name: ");
            string lastName = Console.ReadLine();

            int age = 0;
            do
            {
                Console.Write("Input new user age (integer number): ");
            } while (!int.TryParse(Console.ReadLine(), out age) || age <= 0); ;

            return new User(login, firstName, lastName, age);
        }
    }
}
