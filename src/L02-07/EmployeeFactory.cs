using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_07
{
    internal class EmployeeFactory
    {
        public Employee CreateEmployee()
        {
            Console.WriteLine("Input new employee data");
            Console.Write("First name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last name: ");
            string lastName = Console.ReadLine();

            Employee newEmployee = new Employee(firstName, lastName);

            int choice = 0;
            do
            {
                Console.WriteLine($"Position. Input one number from 0 to {Common.positions.Length}: ");
                for (int i = 0; i < Common.positions.Length; i++)
                {
                    Console.WriteLine($"{i} - {Common.positions[i]}");
                }
                Console.Write("Position: ");
            } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice >= Common.positions.Length);
            newEmployee.SetPosition(choice);

            double experience = -1;
            do
            {
                Console.Write("Experience in years (number): ");
            } while (!double.TryParse(Console.ReadLine(), out experience) || experience < 0);
            newEmployee.SetExperience(experience);

            return newEmployee;
        }
    }
}
