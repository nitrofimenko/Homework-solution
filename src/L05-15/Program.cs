using System.Globalization;
using L05_15;

const int N = 20;
int[] array = Dim.Init(N);

NumberFormatInfo nfi = new CultureInfo("").NumberFormat;
nfi.NumberGroupSeparator = "'";
Console.WriteLine($"Maximum array element = {Dim.GetMax(array).ToString("N0", nfi)}");
Console.WriteLine($"Minimum array element = {Dim.GetMin(array).ToString("N0", nfi)}");
Console.WriteLine($"Total sum of array elements = {Dim.GetSum(array).ToString("N0", nfi)}");
Console.WriteLine("All odd elements in array:");
int[] dimensionOddElements = Dim.GetOddElements(array);
for (int i = 0; i < dimensionOddElements.Length; i++)
{
    Console.WriteLine(dimensionOddElements[i].ToString("N0", nfi));
}