using L08_28;

int[] post = (int[])Enum.GetValues(typeof(Post));

Random random = new Random();

string choice = "";
Console.WriteLine("0 for exit, any other - continue. ");
while (choice != "0")
{
    Post worker = (Post)post[random.Next(post.Length)];
    int hours = random.Next(post.Min(),post.Max());
    Console.Write($"{worker,-20}\t{hours,3} hrs (min - {(int)worker})\t{Accauntant.AskForBonus(worker, hours)}  ");
    choice = Console.ReadLine();
}