using System.Globalization;
using L05_15;

const int N = 20;
Dimension dimension = new Dimension(N);

NumberFormatInfo nfi = new CultureInfo("").NumberFormat;
nfi.NumberGroupSeparator = "'";
Console.WriteLine($"Maximum array element = {dimension.Max.ToString("N0", nfi)}");
Console.WriteLine($"Minimum array element = {dimension.Min.ToString("N0", nfi)}");
Console.WriteLine($"Total sum of array elements = {dimension.Sum.ToString("N0", nfi)}");
Console.WriteLine("All odd elements in array:");
int[] dimensionOddElements = dimension.OddElements;
for (int i = 0; i < dimensionOddElements.Length; i++)
{
    Console.WriteLine(dimensionOddElements[i].ToString("N0", nfi));
}