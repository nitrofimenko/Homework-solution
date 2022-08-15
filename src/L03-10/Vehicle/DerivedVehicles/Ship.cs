using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_10.Vehicle.DerivedVehicles
{
    internal class Ship : Vehicle
    {
        private int numberOfPassengers;
        private string homePort;
        public Ship(double x, double y, double price, double speed, int yearOfManufacture, int numberOfPassengers, string homePort) : base(x, y, price, speed, yearOfManufacture)
        {
            this.numberOfPassengers = numberOfPassengers;
            this.homePort = homePort;
        }
        public override void Show()
        {
            base.Show();
            Console.Write($", number of passengers = {numberOfPassengers}, home port: {homePort}");
        }
    }
}
