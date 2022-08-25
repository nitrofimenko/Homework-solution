using System.Globalization;

const int N = 20;
int[] array = new int[N];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next();
}

int max = array[0];
int min = array[0];
long sum = array[0];
for (int i = 1; i < array.Length; i++)
{
    sum += array[i];
    if (array[i] > max)
    {
        max = array[i];
    }
    else if (array[i] < min)
    {
        min = array[i];
    }
}

NumberFormatInfo nfi = new CultureInfo("").NumberFormat;
nfi.NumberGroupSeparator = " ";
Console.WriteLine($"Maximum array element = {max.ToString("N0", nfi)}");
Console.WriteLine($"Minimum array element = {min.ToString("N0", nfi)}");
Console.WriteLine($"Total sum of array elements = {sum.ToString("N0", nfi)}");
Console.WriteLine($"All odd elements in array:");
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 != 0)
    {
        Console.WriteLine($"array[{i}] = {array[i].ToString("N0", nfi)}");
    }
}
