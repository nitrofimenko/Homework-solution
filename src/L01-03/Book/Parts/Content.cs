using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01_03.Book.Parts
{
    internal class Content
    {
        public string content;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
