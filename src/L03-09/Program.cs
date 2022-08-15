using L03_09.Pupil;
using L03_09.Pupil.DerivedClasses;

Console.WriteLine("Thnx MS for help");

string choice;
do
{
    ClassRoom classRoom = new ClassRoom(new ExcelentPupil(), new Pupil());
    Console.WriteLine("Constructor 1 (two base pupils)");
    classRoom.Show();
    Console.Write("Key to show next ");
    Console.ReadKey();
    Console.WriteLine();
    classRoom = new ClassRoom(new ExcelentPupil(), new GoodPupil(), new BadPupil());
    Console.WriteLine("Constructor 2 (three base pupils)");
    classRoom.Show();
    Console.Write("\"x\" to exit, another to continue: ");
    choice = Console.ReadLine();
} while (choice != "x");

