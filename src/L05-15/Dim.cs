using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_15
{
    internal static class Dim
    {
        public static int[] Init(int N)
        {
            N = N > 0 ? N : 0;
            int[] array = new int[N];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next();
            }
            return array;
        }
        public static int GetMax(int[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        public static int GetMin(int[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        public static long GetSum(int[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        public static int[] GetOddElements(int[] array)
        {
            int[] temp = new int[array.Length];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    temp[j++] = array[i];
                }
            }
            int[] oddElements = new int[j];
            Array.Copy(temp, oddElements, j);
            return oddElements;
        }
    }
}
