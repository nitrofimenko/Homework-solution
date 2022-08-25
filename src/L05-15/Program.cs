using System.Globalization;
using L05_15;

const int N = 20;
Dimension dimension = new Dimension(N);

NumberFormatInfo nfi = new CultureInfo("").NumberFormat;
nfi.NumberGroupSeparator = " ";
Console.WriteLine($"Maximum array element = {dimension.GetMaximum().ToString("N0", nfi)}");
Console.WriteLine($"Minimum array element = {dimension.GetMinimum().ToString("N0", nfi)}");
Console.WriteLine($"Total sum of array elements = {dimension.GetSum().ToString("N0", nfi)}");
Console.WriteLine($"All odd elements in array:");
for (int i = 0; i < dimension.Length; i++)
{
    if (dimension[i] % 2 != 0)
    {
        Console.WriteLine($"array[{i}] = {dimension[i].ToString("N0", nfi)}");
    }
}