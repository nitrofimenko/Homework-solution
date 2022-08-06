using L03_09.Pupil;
using L03_09.Pupil.DerivedClasses;

Console.WriteLine("Thnx MS for help");

string choice;
do
{
    ClassRoom Class = new ClassRoom(new ExcelentPupil(), new Pupil());
    Console.WriteLine("Constructor 1 (two base pupils)");
    Class.Show();
    Console.Write("Key to show next ");
    Console.ReadKey();
    Console.WriteLine();
    Class = new ClassRoom(new ExcelentPupil(), new GoodPupil(), new BadPupil());
    Console.WriteLine("Constructor 2 (three base pupils)");
    Class.Show();
    Console.Write("\"x\" to exit, another to continue: ");
    choice = Console.ReadLine();
} while (choice != "x");

