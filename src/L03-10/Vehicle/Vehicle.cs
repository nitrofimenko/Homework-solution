using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_10.Vehicle
{
    internal class Vehicle
    {
        protected double x = 0;
        protected double y = 0;
        protected double price = 0;
        protected double speed = 0;
        protected double yearOfManufacture = 0;
        public Vehicle() { }
        protected Vehicle(double x, double y, double price, double speed, double yearOfManufacture)
        {
            this.x = x;
            this.y = y;
            this.price = price;
            this.speed = speed;
            this.yearOfManufacture = yearOfManufacture;
        }

        public virtual void Show()
        {
            Console.Write($"x = {x}, y = {y}, price = {price}, speed = {speed}, year of manufacture: {yearOfManufacture}");
        }
    }
}
