using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L08_27
{
    internal static class UserInterface
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
                Console.Write($"{consoleColor} (");
                Console.ForegroundColor = consoleColor;
                Console.Write($"example");
                Console.ForegroundColor = currentForegroundColor;
                Console.WriteLine(")");
            }

            while (true)
            {
                Console.Write("Color: ");
                string color = Console.ReadLine();
                if (Enum.IsDefined(typeof(ConsoleColor), color))
                {
                    return (int)Enum.Parse(typeof(ConsoleColor), color);
                }
                else
                {
                    Console.WriteLine("Wrong color.");
                }
            }
        }
    }
}
