using L09_29;
using System.Runtime.ExceptionServices;

Random rnd = new Random();

const int MIN_INT = 10;
const int MAX_INT = 99;

const double MIN_DOUBLE = MIN_INT;
const double MAX_DOUBLE = MAX_INT;

int intA = rnd.Next(MIN_INT, MAX_INT);
int intB = rnd.Next(MIN_INT, MAX_INT);

double doubleA = rnd.NextDouble() * (MAX_DOUBLE - MIN_DOUBLE) + MIN_DOUBLE;
double doubleB = rnd.NextDouble() * (MAX_DOUBLE - MIN_DOUBLE) + MIN_DOUBLE;

string strA = "testA";
string strB = "testB";

Console.WriteLine("Add.");
Console.WriteLine($"Int.\ta = {intA}, b = {intB}. a + b = {Calculator.Add(intA, intB)}.");
Console.WriteLine($"Double.\ta = {doubleA}, b = {doubleB}. a + b = {Calculator.Add(doubleA, doubleB)}.");
Console.WriteLine($"String.\ta = {strA}, b = {strB}. a + b = {Calculator.Add(strA, strB)}.");

Console.WriteLine("\nSubtract.");
Console.WriteLine($"Int.\ta = {intA}, b = {intB}. a - b = {Calculator.Subtract(intA, intB)}.");
Console.WriteLine($"Double.\ta = {doubleA}, b = {doubleB}. a - b = {Calculator.Subtract(doubleA, doubleB)}.");

Console.WriteLine("\nMultiply.");
Console.WriteLine($"Int.\ta = {intA}, b = {intB}. a * b = {Calculator.Multiply(intA, intB)}.");
Console.WriteLine($"Double.\ta = {doubleA}, b = {doubleB}. a * b = {Calculator.Multiply(doubleA, doubleB)}.");

Console.WriteLine("\nDivide.");
Console.WriteLine($"Int.\ta = {intA}, b = {intB}. a / b = {Calculator.Divide(intA, intB)}.");
Console.WriteLine($"Double.\ta = {doubleA}, b = {doubleB}. a / b = {Calculator.Divide(doubleA, doubleB)}.");

ArithmeticMean arithmeticMean = new ArithmeticMean(delegate (int first, int second, int third) { return (double)(first + second + third) / 3; });

int first = rnd.Next(1, 10);
int second = rnd.Next(1, 10);
int third = rnd.Next(1, 10);

Console.WriteLine("\nArithmetic mean.");
Console.WriteLine($"first = {first}, second = {second}, third = {third}. Arithmetic mean = {arithmeticMean.Invoke(first, second, third)}");
