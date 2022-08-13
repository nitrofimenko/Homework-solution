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
        public virtual void Show()
        {
            Console.Write($"x = {x}, y = {y}, price = {price}, speed = {speed}, year of manufacture: {yearOfManufacture}");
        }
    }
}
