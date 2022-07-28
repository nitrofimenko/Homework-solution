using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_08
{
    internal class Product
    {
        public string Name { get; }
        public double Price { get; }
        public string Provider { get; }
        public Product(string name, double price, string provider)
        {
            Name = name;
            Price = price;
            Provider = provider;
        }
    }
}
