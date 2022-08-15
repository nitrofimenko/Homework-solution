using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L03_10.Vehicle.DerivedVehicles;

namespace L03_10.Vehicle
{
    internal class VehicleFactory
    {
        public Vehicle CreateVehicle()
        {
            int choice = 0;
            do
            {
                Console.Write("Select vehile which you want to add: 1 - plane, 2 - car, 3 - ship : ");
            } while (!int.TryParse(Console.ReadLine(), out choice) || choice <= 0 || choice > 3);
            
            Console.Write("x coordinate = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y coordinate = ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Price = ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Speed = ");
            double speed = Convert.ToDouble(Console.ReadLine());
            Console.Write("Year of manufacturing: ");
            int yearOfManufacture = Convert.ToInt32(Console.ReadLine());
            int numberOfPassengers = 0;

            switch (choice)
            {
                case 1:
                    Console.Write("Altitude = ");
                    double altitude = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Number of passengers = ");
                    numberOfPassengers = Convert.ToInt32(Console.ReadLine());
                    return new Plane(x, y, price, speed, yearOfManufacture, altitude, numberOfPassengers);
                case 2:
                    return new Car(x, y, price, speed, yearOfManufacture);
                case 3:
                    Console.Write("Number of passengers = ");
                    numberOfPassengers = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Home port: ");
                    string homePort = Convert.ToString(Console.ReadLine());
                    return new Ship(x, y, price, speed, yearOfManufacture, numberOfPassengers, homePort);
                default:
                    return new Vehicle();
            }
        }
    }
}
