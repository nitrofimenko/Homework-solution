using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_14.Document.Parts
{
    internal class Body:Part
    {
        private string content;
        public override string Content
        {
            protected get
            {
                if (content != null)
                    return content;
                else
                    return "Тело документа отсутствует.";
            }
            set => content = value;
        }
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
