using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace L06_21
{
    internal static class ArrayExtension
    {
        public static int[] Sort(this int[] array, SortDirection direction = SortDirection.Ascending)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (direction == SortDirection.Ascending ? array[i + 1] < array[i] : array[i + 1] > array[i])
                {
                    temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    if (i > 0)
                    {
                        i -= 2;
                    }
                }
            }
            return array;
        }
        public static int[] GetRandom(this int[] array, int minValue = 0, int maxValue = 9)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(minValue, maxValue);
            }
            return array;
        }
        public static void Show(this int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}
