using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_16
{
    internal class MyMatrix
    {
        private int[,] myMatrix;
        public MyMatrix(int rows, int columns, bool random = false, int minValue = 0, int maxValue = Int32.MaxValue)
        {
            if (rows < 0)
            {
                rows = 0;
            }
            if (columns < 0)
            {
                columns = 0;
            }
            myMatrix = new int[rows, columns];
            if (random)
            {
                FillRandomMatrix(minValue, maxValue);
            }
            else
            {
                FillDefaultMatrix();
            }
        }
        private void FillRandomMatrix(int minValue, int maxValue)
        {
            Random rnd = new Random();
            for (int i = 0; i < myMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < myMatrix.GetLength(1); j++)
                {
                    myMatrix[i, j] = rnd.Next(minValue, maxValue);
                }
            }
        }
        private void FillDefaultMatrix()
        {
            for (int i = 0; i < myMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < myMatrix.GetLength(1); j++)
                {
                    myMatrix[i, j] = i * 10 + j;
                }
            }
        }
        public int GetRowsNumber() => myMatrix.GetLength(0);
        public int GetColumnsNumber() => myMatrix.GetLength(1);
        public void AddRows(int startRow, int rowsNumber = 1, bool random = false, int minValue = 0, int maxValue = Int32.MaxValue)
        {
            if (startRow > myMatrix.GetLength(0) || rowsNumber <= 0)
            {
                return;
            }
            if (startRow < 0)
            {
                startRow = 0;
            }
            int[,] temp = new int[myMatrix.GetLength(0) + rowsNumber, myMatrix.GetLength(1)];
            for (int i = 0; i < myMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < myMatrix.GetLength(1); j++)
                {
                    if (i < startRow)
                    {
                        temp[i, j] = myMatrix[i, j];
                    }
                    else
                    {
                        temp[i + rowsNumber, j] = myMatrix[i, j];
                    }
                }
            }
            if (random)
            {
                Random rnd = new Random();
                for (int i = startRow; i < startRow + rowsNumber; i++)
                {
                    for (int j = 0; j < myMatrix.GetLength(1); j++)
                    {
                        temp[i, j] = rnd.Next(minValue, maxValue);
                    }
                }
            }
            myMatrix = temp;
        }
        public void AddColumns(int startColumn, int columnsNumber = 1, bool random = false, int minValue = 0, int maxValue = Int32.MaxValue)
        {
            if (startColumn > myMatrix.GetLength(1) || columnsNumber <= 0)
            {
                return;
            }
            if (startColumn < 0)
            {
                startColumn = 0;
            }
            int[,] temp = new int[myMatrix.GetLength(0), myMatrix.GetLength(1) + columnsNumber];
            for (int i = 0; i < myMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < myMatrix.GetLength(1); j++)
                {
                    if (j < startColumn)
                    {
                        temp[i, j] = myMatrix[i, j];
                    }
                    else
                    {
                        temp[i, j + columnsNumber] = myMatrix[i, j];
                    }
                }
            }
            if (random)
            {
                Random rnd = new Random();
                for (int i = 0; i < myMatrix.GetLength(0); i++)
                {
                    for (int j = startColumn; j < startColumn + columnsNumber; j++)
                    {
                        temp[i, j] = rnd.Next(minValue, maxValue);
                    }
                }
            }
            myMatrix = temp;
        }
        public void DelRows(int startRow, int rowsNumber = 1)
        {
            if (startRow > myMatrix.GetLength(0) - 1 || rowsNumber <= 0)
            {
                return;
            }
            if (startRow < 0)
            {
                rowsNumber = rowsNumber + startRow;
                startRow = 0;
            }
            if (startRow + rowsNumber > myMatrix.GetLength(0))
            {
                rowsNumber = myMatrix.GetLength(0) - startRow;
            }
            int[,] temp = new int[myMatrix.GetLength(0) - rowsNumber, myMatrix.GetLength(1)];
            for (int i = 0; i < temp.GetLength(0); i++)
            {
                for (int j = 0; j < temp.GetLength(1); j++)
                {
                    if (i < startRow)
                    {
                        temp[i, j] = myMatrix[i, j];
                    }
                    else
                    {
                        temp[i, j] = myMatrix[i + rowsNumber, j];
                    }
                }
            }
            myMatrix = temp;
        }
        public void DelColumns(int startColumn, int columnsNumber)
        {
            if (startColumn > myMatrix.GetLength(1) - 1 || columnsNumber <= 0)
            {
                return;
            }
            if (startColumn < 0)
            {
                columnsNumber = columnsNumber + startColumn;
                startColumn = 0;
            }
            if (startColumn + columnsNumber > myMatrix.GetLength(1))
            {
                columnsNumber = myMatrix.GetLength(1) - startColumn;
            }
            int[,] temp = new int[myMatrix.GetLength(0), myMatrix.GetLength(1) - columnsNumber];
            for (int i = 0; i < temp.GetLength(0); i++)
            {
                for (int j = 0; j < temp.GetLength(1); j++)
                {
                    if (j < startColumn)
                    {
                        temp[i, j] = myMatrix[i, j];
                    }
                    else
                    {
                        temp[i, j] = myMatrix[i, j + columnsNumber];
                    }
                }
            }
            myMatrix = temp;
        }
        public void ResizeMatrix(int newRowsNumber, int newColumnsNumber, int startRow = 0, int startColumn = 0, bool boundsControl = false)
        {
            if (boundsControl)
            {
                if (newRowsNumber < 0 || newColumnsNumber < 0 ||
                    startRow < 0 || startRow >= myMatrix.GetLength(0) ||
                    startColumn < 0 || startColumn >= myMatrix.GetLength(1))
                {
                    Console.WriteLine("ResizeMatrix: Bounds control failed");
                    return;
                }
            }
            if (newRowsNumber < 0)
            {
                newRowsNumber = 0;
            }
            if (newColumnsNumber < 0)
            {
                newColumnsNumber = 0;
            }
            int[,] temp = new int[newRowsNumber, newColumnsNumber];

            int rowsLimit = startRow + temp.GetLength(0);
            if (rowsLimit > myMatrix.GetLength(0))
            {
                rowsLimit = myMatrix.GetLength(0);
            }
            int columnsLimit = startColumn + temp.GetLength(1);
            if (columnsLimit > myMatrix.GetLength(1))
            {
                columnsLimit = myMatrix.GetLength(1);
            }

            int tempStartRow = -startRow;
            int tempStartColumn = -startColumn;

            if (startRow < 0)
            {
                startRow = 0;
            }
            if (startColumn < 0)
            {
                startColumn = 0;
            }
            for (int i = startRow; i < rowsLimit; i++)
            {
                for (int j = startColumn; j < columnsLimit; j++)
                {
                    temp[tempStartRow + i, tempStartColumn + j] = myMatrix[i, j];
                }
            }
            myMatrix = temp;
        }
        public void ShowPart(int startRow, int startColumn, int endRow, int endColumn)
        {
            if (startRow < 0 || startRow >= myMatrix.GetLength(0) || startColumn < 0 || endColumn >= myMatrix.GetLength(1))
            {
                Console.WriteLine("ShowPart: Bounds control failed");
                return;
            }
            for (int i = startRow; i < endRow + 1; i++)
            {
                for (int j = startColumn; j < endColumn + 1; j++)
                {
                    Console.Write($"{myMatrix[i, j],4}");
                }
                Console.WriteLine();
            }
        }
        public void ShowMatrix()
        {
            for (int i = 0; i < myMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < myMatrix.GetLength(1); j++)
                {
                    Console.Write($"{myMatrix[i, j],4}");
                }
                Console.WriteLine();
            }
        }
    }
}
