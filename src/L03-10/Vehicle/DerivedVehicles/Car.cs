using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_10.Vehicle.DerivedVehicles
{
    internal class Car : Vehicle
    {
        public Car(double x, double y, double price, double speed, int yearOfManufacture) : base(x, y, price, speed, yearOfManufacture)
        {

        }
    }
}
