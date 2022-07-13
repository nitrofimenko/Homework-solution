using L02_05;

const int CAPACITY = 100;
User[] users = new User[CAPACITY];
int usersNumber = 0;
do
{
    Console.WriteLine(usersNumber != CAPACITY ? "1 - create new user" : "1 is unavailable (Can't create new user. Maximum capacity reached)");
    if (usersNumber > 0)
    {
        Console.WriteLine($"2 - show all {usersNumber} users");
        if (usersNumber > 1)
        {
            Console.WriteLine("3 - show #{your number} user");
        }
    }
    Console.Write("e - exit\nChoose one of this: ");

    var choose = Console.ReadLine();
    Console.WriteLine();

    if (choose == "1" && usersNumber != CAPACITY)
    {
        Console.WriteLine("Creation new user");

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

        users[usersNumber] = new User(login, firstName, lastName, age);

        Console.WriteLine($"User #{usersNumber} was succesfully created\n");

        usersNumber++;
    }
    else if (choose == "2" && usersNumber > 0)
    {
        for (int i = 0; i < usersNumber; i++)
        {
            Console.WriteLine($"About user #{i} information");
            users[i].Show();
            Console.WriteLine();
        }
    }
    else if (choose == "3" && usersNumber > 1)
    {
        int userNumber = 0;
        do
        {
            Console.Write($"\nInput user number from 0 to {usersNumber - 1}: ");
        } while (!int.TryParse(Console.ReadLine(), out userNumber) || userNumber < 0 || userNumber >= usersNumber);
        
        Console.WriteLine($"About user #{userNumber} information");
        users[userNumber].Show();
        Console.WriteLine();
    }
    else if (choose == "e")
    {
        break;
    }
} while (true);