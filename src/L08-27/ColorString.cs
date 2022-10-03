using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L08_27
{
    internal static class ColorString
    {
        public static string GetString()
        {
            Console.Write("String: ");
            return Console.ReadLine();
        }
        public static int GetColor()
        {
            ConsoleColor currentForegroundColor = Console.ForegroundColor;
            foreach (ConsoleColor consoleColor in Enum.GetValues(typeof(ConsoleColor)))
            {
                Console.Write($"{(int)consoleColor} {consoleColor} (");
                Console.ForegroundColor = consoleColor;
                Console.Write($"example");
                Console.ForegroundColor = currentForegroundColor;
                Console.WriteLine(")");
            }
            int color = (int)Enum.GetValues(typeof(ConsoleColor)).Cast<ConsoleColor>().Min() - 1;
            while (color < (int)Enum.GetValues(typeof(ConsoleColor)).Cast<ConsoleColor>().Min() || color > (int)Enum.GetValues(typeof(ConsoleColor)).Cast<ConsoleColor>().Max())
            {
                Console.Write("Color number: ");
                color = Convert.ToInt32(Console.ReadLine());
            }
            return color;
        }
        public static void Print(string stroka, int color)
        {
            ConsoleColor currentForegroundColor = Console.ForegroundColor;
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(stroka);
            Console.ForegroundColor = currentForegroundColor;
        }
    }
}
