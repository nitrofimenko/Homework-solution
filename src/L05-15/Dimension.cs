using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_15
{
    internal class Dimension
    {
        private int[] dimension;
        public int Length
        {
            get
            {
                return dimension.Length;
            }
        }
        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < dimension.Length)
                {
                    return dimension[index];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if (index >= 0 && index < dimension.Length)
                {
                    dimension[index] = value;
                }
            }
        }
        public Dimension(int N)
        {
            if (N < 0)
            {
                N = 0;
            }
            dimension = new int[N];
            Random rnd = new Random();
            for (int i = 0; i < dimension.Length; i++)
            {
                dimension[i] = rnd.Next();
            }
        }
        public int GetMaximum()
        {
            if (dimension.Length == 0)
            {
                return 0;
            }
            int max = dimension[0];
            for (int i = 1; i < dimension.Length; i++)
            {
                if (dimension[i] > max)
                {
                    max = dimension[i];
                }
            }
            return max;
        }
        public int GetMinimum()
        {
            if (dimension.Length == 0)
            {
                return 0;
            }
            int min = dimension[0];
            for (int i = 1; i < dimension.Length; i++)
            {
                if (dimension[i] < min)
                {
                    min = dimension[i];
                }
            }
            return min;
        }
        public long GetSum()
        {
            if (dimension.Length == 0)
            {
                return 0;
            }
            long sum = 0;
            for (int i = 0; i < dimension.Length; i++)
            {
                sum += dimension[i];
            }
            return sum;
        }
    }
}
