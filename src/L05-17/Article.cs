using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_17
{
    internal class Article
    {
        private string productName;
        private string storeName;
        private decimal price;
        public Article(string productName, string storeName, decimal price)
        {
            this.productName = productName;
            this.storeName = storeName;
            this.price = price;
        }
        public void Show()
        {
            Console.WriteLine($"{productName}. Price in {storeName}: {price} UAH.");
        }
        public bool IsProductNameRight(string name)
        {
            return name.Length < 3 ? productName.ToLower() == name.ToLower() : productName.ToLower().Contains(name.ToLower());
        }
    }
}
