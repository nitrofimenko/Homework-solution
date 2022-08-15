using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_08
{
    internal class ProductFactory
    {
        public Product CreateProduct()
        {
            Console.WriteLine("Input new product.");
            Console.Write("Name: ");
            string productName = Console.ReadLine();

            Console.Write("Price: ");
            double productPrice = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);

            Console.Write("Provider: ");
            string productProvider = Console.ReadLine();

            Product newProduct = new Product(productName, productPrice, productProvider);

            return newProduct;
        }
    }
}
