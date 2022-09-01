using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_17
{
    internal class Article
    {
        private string articleName;
        private string storeName;
        private decimal price;
        public Article(string articleName, string storeName, decimal price)
        {
            this.articleName = articleName;
            this.storeName = storeName;
            this.price = price;
        }
        public void Show()
        {
            Console.WriteLine($"{articleName}. Price in {storeName}: {price} UAH.");
        }
        public bool IsArticleNameRight(string name, int symbolsNumberToMatchFull = 3)
        {
            return name.Length < symbolsNumberToMatchFull ? articleName.ToLower() == name.ToLower() : articleName.ToLower().Contains(name.ToLower());
        }
    }
}
