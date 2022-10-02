using L07_24;

const int TRAINS_NUMBER = 8;

TrainsList trainsList = new TrainsList(TRAINS_NUMBER, true);

while (true)
{
    Console.WriteLine(new String('+', 20));
    Console.Write("Train number to search: ");
    int trainNumber = Convert.ToInt32(Console.ReadLine());

    trainsList.SearchAndShow(trainNumber);
}
