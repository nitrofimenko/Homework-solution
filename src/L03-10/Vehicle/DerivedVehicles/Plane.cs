using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_10.Vehicle.DerivedVehicles
{
    internal class Plane : Vehicle
    {
        private double altitude;
        private int numberOfPassengers;
        public Plane(double x, double y, double price, double speed, int yearOfManufacture, double altitude, int numberOfPassengers) : base(x, y, price, speed, yearOfManufacture)
        {
            this.altitude = altitude;
            this.numberOfPassengers = numberOfPassengers;
        }
        public override void Show()
        {
            base.Show();
            Console.Write($", altitude = {altitude}, number of passengers = {numberOfPassengers}");
        }
    }
}
