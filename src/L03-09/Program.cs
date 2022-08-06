using L03_09.Pupil;

Console.WriteLine("Thnx MS for help");

string choice;
do
{
    ClassRoom Class = new ClassRoom(new Pupil());
    Console.WriteLine("Constructor 1 (one base pupil)");
    Class.Show();
    Console.Write("Key to show next ");
    Console.ReadKey();
    Console.WriteLine();
    Class = new ClassRoom(new Pupil(), new Pupil());
    Console.WriteLine("Constructor 2 (two base pupil)");
    Class.Show();
    Console.Write("\"x\" to exit, another to continue: ");
    choice = Console.ReadLine();
} while (choice != "x");

