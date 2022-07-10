using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01_03.Book.Parts
{
    internal class Title
    {
        public string title;
        public void Show()
        {
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine(title);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
