using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_07
{
    internal class Employee
    {
        string firstName;
        string lastName;
        public string Position { get; set; }
        public double Experience { get; set; }
        double salary;
        double tax;

        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void CountSalaryAndTax()
        {
            string[] positions = { "Junior", "Middle", "Senior", "TeamLead", "Architect" };
            double[] salaries = { 300, 2000, 3000, 5000, 6700 };
            for (int i = 0; i < positions.Length; i++)
            {
                if (Position == positions[i])
                {
                    salary = salaries[i];
                    break;
                }
            }
            double[] experiences = { 0, 5, 10, 15, 20, 25 };
            double[] allowance = { 1, 1.05, 1.1, 1.15, 1.2, 1.25 };
            for (int i = 0; i < allowance.Length; i++)
            {
                if (Experience >= experiences[allowance.Length - 1 - i])
                {
                    salary = Math.Round(salary * allowance[allowance.Length - 1 - i], 2);
                    break;
                }
            }

            const double INCOME_TAX_RATE = 19.0 / 100;
            const double MILITARY_TAX_RATE = 1.5 / 100;
            tax = Math.Round((INCOME_TAX_RATE + MILITARY_TAX_RATE) * salary, 2);
        }

        public void Show()
        {
            Console.WriteLine($"Employee {firstName} {lastName}. Position: {Position}. Salary: {salary}. Tax: {tax}");
        }
    }
}
