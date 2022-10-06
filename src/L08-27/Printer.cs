using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L08_27
{
    internal static class Printer
    {
        public static void Print(string stroka, int color)
        {
            ConsoleColor currentForegroundColor = Console.ForegroundColor;
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(stroka);
            Console.ForegroundColor = currentForegroundColor;
        }
    }
}
