using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01_03.Book.Parts
{
    internal class Author
    {
        public string author;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(author);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
