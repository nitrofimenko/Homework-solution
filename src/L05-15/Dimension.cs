using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_15
{
    internal class Dimension
    {
        private int[] dimension;
        private int oddNumber = 0;
        private int evenNumber = 0;
        public int Max { get; private set; }
        public int Min { get; private set; }
        public long Sum { get; private set; }
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
                    Sum = Sum - dimension[index] + value;

                    if (value > Max)
                    {
                        Max = value;
                    }
                    else if (value < Min)
                    {
                        Min = value;
                    }

                    if (dimension[index] % 2 == 0)
                    {
                        evenNumber--;
                    }
                    else
                    {
                        oddNumber--;
                    }

                    if (value % 2 == 0)
                    {
                        evenNumber++;
                    }
                    else
                    {
                        oddNumber++;
                    }

                    dimension[index] = value;
                }
            }
        }
        public int[] EvenElements
        {
            get
            {
                int[] evenElements = new int[evenNumber];
                int j = 0;
                for (int i = 0; i < dimension.Length; i++)
                {
                    if (dimension[i] % 2 == 0)
                    {
                        evenElements[j] = dimension[i];
                        j++;
                    }
                }
                return evenElements;
            }
        }
        public int[] OddElements
        {
            get
            {
                int[] oddElements = new int[oddNumber];
                int j = 0;
                for (int i = 0; i < dimension.Length; i++)
                {
                    if (dimension[i] % 2 != 0)
                    {
                        oddElements[j] = dimension[i];
                        j++;
                    }
                }
                return oddElements;
            }
        }
        public int[] EvenIndexes
        {
            get
            {
                int[] evenIndexes = new int[evenNumber];
                int j = 0;
                for (int i = 0; i < dimension.Length; i++)
                {
                    if (dimension[i] % 2 == 0)
                    {
                        evenIndexes[j] = i;
                        j++;
                    }
                }
                return evenIndexes;
            }
        }
        public int[] OddIndexes
        {
            get
            {
                int[] oddIndexes = new int[oddNumber];
                int j = 0;
                for (int i = 0; i < dimension.Length; i++)
                {
                    if (dimension[i] % 2 != 0)
                    {
                        oddIndexes[j] = i;
                        j++;
                    }
                }
                return oddIndexes;
            }
        }
        public Dimension(int N)
        {
            Sum = 0;
            if (N <= 0)
            {
                dimension = new int[0];
                Max = 0;
                Min = 0;
            }
            else
            {
                dimension = new int[N];
                Random rnd = new Random();
                for (int i = 0; i < dimension.Length; i++)
                {
                    dimension[i] = rnd.Next();
                    
                    Sum += dimension[i];
                    
                    if (i == 0)
                    {
                        Max = dimension[i];
                        Min = dimension[i];
                    }

                    if (dimension[i] > Max)
                    {
                        Max = dimension[i];
                    }
                    else if (dimension[i] < Min)
                    {
                        Min = dimension[i];
                    }

                    if (dimension[i] % 2 == 0)
                    {
                        evenNumber++;
                    }
                    else
                    {
                        oddNumber++;
                    }
                }
            }
        }
    }
}
