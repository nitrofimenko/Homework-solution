using L03_10.Vehicle;
using L03_10.Vehicle.DerivedVehicles;

string ReturnVehicleClass(Vehicle someVehicle)
{
    if (someVehicle is Plane)
    {
        return "Plane";
    }
    else if (someVehicle is Car)
    {
        return "Car";
    }
    else if (someVehicle is Ship)
    {
        return "Ship";
    }
    else
    {
        return "Vehicle";
    }
}

VehicleFactory vehicleFactory = new VehicleFactory();
const int CAPACITY = 100;
Vehicle[] vehicles = new Vehicle[CAPACITY];
int vehiclesNumber = 0;
string choice;
do
{
    Console.Write($"{vehiclesNumber} vehicles present\n1 - add vehicle\n2 - show all vehicles\nx - exit\nYour choice: ");
    choice = Console.ReadLine();
    Console.WriteLine();
    switch (choice)
    {
        case "1":
            if (vehiclesNumber < CAPACITY)
            {
                vehicles[vehiclesNumber] = vehicleFactory.CreateVehicle();
                Console.WriteLine($"{ReturnVehicleClass(vehicles[vehiclesNumber])} succesfully added as Vehicle #{vehiclesNumber}");
                vehiclesNumber++;
            }
            else
            {
                Console.WriteLine("Unable to complie - maximum number of vehicles reached");
            }
            Console.Write("Enter to continue");
            Console.ReadKey();
            break;
        case "2":
            Console.WriteLine($"{vehiclesNumber} vehicles present");
            for (int i = 0; i < vehiclesNumber; i++)
            {
                Console.WriteLine($"Vehicle #{i}. Type: {ReturnVehicleClass(vehicles[i])}");
                vehicles[i].Show();
                Console.WriteLine();
            }
            Console.Write("Enter to continue");
            Console.ReadKey();
            break;
        default:
            break;
    }
    Console.Clear();
} while (choice != "x");