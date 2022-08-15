using L02_07;

const int LIMIT = 100;
EmployeeFactory employeeFactory = new EmployeeFactory();
Employee[] employees = new Employee[LIMIT];
int employeesNumber = 0;
do
{
    Console.WriteLine($"Number of employees: {employeesNumber}");
    Console.WriteLine(employeesNumber != LIMIT ? "1 - create new employee." : "Creating employees unavailable. Limit is reached.");
    if (employeesNumber > 0)
    {
        Console.WriteLine("2 - show information about all employees.");
        if (employeesNumber > 1)
        {
            Console.WriteLine("3 - show information about employee #{number}.");
        }
    }
    Console.WriteLine("e - exit.");
    Console.Write("Choose one of this: ");

    var choose = Console.ReadLine();
    Console.WriteLine();
    if (choose == "1" && employeesNumber != LIMIT)
    {
        employees[employeesNumber] = employeeFactory.CreateEmployee();
        Console.WriteLine("Ok");
        employeesNumber++;
    }
    else if (choose == "2" && employeesNumber > 0)
    {
        for (int i = 0; i < employeesNumber; i++)
        {
            Console.Write($"{i}. ");
            employees[i].Show();
        }
    }
    else if (choose == "3" && employeesNumber > 1)
    {
        int employeeNumber = -1;
        do
        {
            Console.Write($"Input employee number form 0 to {employeesNumber - 1}: ");
        } while (!int.TryParse(Console.ReadLine(), out employeeNumber) || employeeNumber < 0 || employeeNumber >= employeesNumber);
        Console.WriteLine();
        Console.Write($"{employeeNumber}. ");
        employees[employeeNumber].Show();
    }
    else if (choose == "e")
    {
        break;
    }
    Console.WriteLine();
} while (true);
