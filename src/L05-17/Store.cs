using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_17
{
    internal class Store
    {
        private Article[] articles;
        public Store()
        {
            articles = new Article[23];
            articles[0] = new Article("Pizza Meet", "Velyka kyshenya", 99);
            articles[1] = new Article("Pizza New York", "Velyka kyshenya", 99);
            articles[2] = new Article("Pizza Vegetable", "Velyka kyshenya", 79);
            articles[3] = new Article("Pizza Neapolitano", "Velyka kyshenya", 95);
            articles[4] = new Article("Pizza El Diablo", "Velyka kyshenya", 105);
            articles[5] = new Article("Pizza Hawaii", "Velyka kyshenya", 89);
            articles[6] = new Article("Pizza Parma", "Velyka kyshenya", 95);
            articles[7] = new Article("Pizza Peperoni", "Velyka kyshenya", 95);
            articles[8] = new Article("Pizza 4 cheese", "Velyka kyshenya", 115);
            articles[9] = new Article("Pizza Margherita", "Velyka kyshenya", 79);
            articles[10] = new Article("Pizza Seafood", "Velyka kyshenya", 119);
            articles[11] = new Article("Pizza Carbonara", "Velyka kyshenya", 95);
            articles[12] = new Article("Pizza Caesar", "Velyka kyshenya", 99);
            articles[13] = new Article("Pizza Calzone", "Velyka kyshenya", 58);
            articles[14] = new Article("Pizza Peperoni", "Fora", 80);
            articles[15] = new Article("Pizza Hawaii", "Fora", 86);
            articles[16] = new Article("Pizza Francesca", "Fora", 86);
            articles[17] = new Article("Pizza Carbonara", "Fora", 90);
            articles[18] = new Article("Pizza Americana", "Fora", 86);
            articles[19] = new Article("Pizza BBQ", "Fora", 90);
            articles[20] = new Article("Pizza 4 cheese", "Fora", 110);
            articles[21] = new Article("Pizza Caesar", "Fora", 90);
            articles[22] = new Article("Pizza Margherita", "Fora", 75);
        }
        public void ShowArticle(int index)
        {
            if (index > 0 && index < articles.Length)
            {
                Console.Write($"Article #{index}: ");
                articles[index].Show();
            }
            else
            {
                Console.WriteLine($"Invalid index. Valid index is from 0 to {articles.Length - 1}");
            }
        }
        public void ShowArticle(string articleName)
        {
            bool founded = false;
            for (int i = 0; i < articles.Length; i++)
            {
                if (Lib.QueryIsRight(articleName, articles[i].ArticleName))
                {
                    articles[i].Show();
                    founded = true;
                }
            }
            if (!founded)
            {
                Console.WriteLine($"No {articleName} article in this store. Try \"Pizza <Name>\"");
            }
        }
    }
}
