using L07_24;

const int TRAINS_NUMBER = 8;

Train[] trains = new Train[TRAINS_NUMBER];

string destination;
int trainNumber;
DateTime departureTime;

for (int i = 0; i < TRAINS_NUMBER; i++)
{
    Console.WriteLine($"Train {i}");
    Console.Write("Destination: ");
    destination = Console.ReadLine();
    Console.Write("Train number: ");
    trainNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Departure time: ");
    departureTime = Convert.ToDateTime(Console.ReadLine());
    Console.WriteLine(new String('-', 20));
    int position;
    for (position = i; position > 0; position--)
    {
        if (trainNumber > trains[position-1].TrainNumber)
        {
            break;
        }
    }
    for (int k = i; k > position; k--)
    {
        trains[k] = trains[k - 1];
    }
    trains[position] = new Train(destination, trainNumber, departureTime);
}

while (true)
{
    Console.WriteLine(new String('+', 20));
    Console.Write("Train number to search: ");
    int toSearch = Convert.ToInt32(Console.ReadLine());
    int matches = 0;
    for (int i = 0; i < TRAINS_NUMBER; i++)
    {
        if (toSearch == trains[i].TrainNumber)
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
