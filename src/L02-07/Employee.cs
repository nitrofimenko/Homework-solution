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
        public void SetPosition(int positionNumber)
        {
            var length = Common.Positions.Length;
            if (positionNumber > length - 1 || positionNumber < 0)
            {
                Console.WriteLine("positionNumber is out of scope of available values");
                return;
            }
            Position = Common.Positions[positionNumber];
            CountSalaryAndTax();
        }

        public void SetExperience(double experience)
        {
            if (experience < 0)
            {
                Console.WriteLine("Experience can't be less that 0.");
                return;
            }
            Experience = experience;
            if (Position != null)
            {
                CountSalaryAndTax();
            }
        }
        private void CountSalaryAndTax()
        {
            for (int i = 0; i < Common.Positions.Length; i++)
            {
                if (Position == Common.Positions[i])
                {
                    salary = Common.Salaries[i];
                    break;
                }
            }
            for (int i = 0; i < Common.Allowance.Length; i++)
            {
                if (Experience >= Common.Experiences[Common.Allowance.Length - 1 - i])
                {
                    salary = Math.Round(salary * Common.Allowance[Common.Allowance.Length - 1 - i], 2);
                    break;
                }
            }

            tax = Math.Round((Common.IncomeTaxRate + Common.MilitaryTaxRate) * salary, 2);
        }

        public void Show()
        {
            Console.WriteLine($"Employee {firstName} {lastName}. Position: {Position}. Salary: {salary}. Tax: {tax}");
        }
    }
}
