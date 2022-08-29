using L05_17;

Store store = new Store();
string choice = "";
int index;
while (true)
{
    Console.WriteLine("Input index or name of article to information about. \"q\" to quit");
    choice = Console.ReadLine();
    if (choice.ToLower() == "q")
    {
        break;
    }
    if (int.TryParse(choice,out index))
    {
        store.ShowArticle(index);
    }
    else
    {
        store.ShowArticle(choice);
    }
    Console.WriteLine(new string('-', 60));
}