using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_23
{
    struct Notebook
    {
        private string model;
        private string manufacturer;
        private double price;
        public Notebook(string model,string manufacturer,double price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }
        public void Show()
        {
            Console.WriteLine($"Model: {model}\nManufacturer: {manufacturer}\nPrice: {price:n2}");
        }
    }
}
