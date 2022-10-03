using L07_24;

const int TRAINS_NUMBER = 8;

Train[] trains = new Train[TRAINS_NUMBER];

Train InputTrain(int number)
{
    string destination;
    string trainNumber;
    DateTime departureTime;

    Console.WriteLine($"Train #{number}");
    Console.Write("Destination: ");
    destination = Console.ReadLine();
    Console.Write("Train number: ");
    trainNumber = Console.ReadLine();
    Console.Write("Departure time: ");
    departureTime = Convert.ToDateTime(Console.ReadLine());

    return new Train(destination, trainNumber, departureTime);
}

void AddTrain(Train train, Train[] trains, int number)
{
    int position;
    for (position = number; position > 0; position--)
    {
        if (string.Compare(train.TrainNumber, trains[position - 1].TrainNumber) > 0)
        {
            break;
        }
    }

    for (int j = number; j > position; j--)
    {
        trains[j] = trains[j - 1];
    }
    trains[number] = train;
}

void SearchAndShowTrain()
{
    Console.Write("Search train number: ");
    string answer = Console.ReadLine();
    int matches = 0;
    for (int i = 0; i < TRAINS_NUMBER; i++)
    {
        if (string.Compare(trains[i].TrainNumber, answer) == 0)
        {
            trains[i].Show();
            matches++;
        }
    }
    if (matches == 0)
    {
        Console.WriteLine("No matches");
    }
}

for (int i = 0; i < TRAINS_NUMBER; i++)
{
    AddTrain(InputTrain(i), trains, i);
}
while (true)
{
    SearchAndShowTrain();
}