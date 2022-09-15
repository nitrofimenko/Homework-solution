using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L06_22
{
    internal static class Calculator
    {
        public static int Add(int a, int b) => a + b;
        public static double Add(double a, double b) => a + b;
        public static string Add(string a, string b) => a + b;
        public static int Subtract(int a, int b) => a - b;
        public static double Subtract(double a, double b) => a - b;
        public static int Multiply(int a, int b) => a * b;
        public static double Multiply(double a, double b) => a * b;
        public static int Divide(int a, int b) => a / b;
        public static double Divide(double a, double b) => a / b;
    }
}
