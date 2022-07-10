using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01_04
{
    internal class Point
    {
        int x, y;
        string name;
        public int X { get; }
        public int Y { get; }
        public string Name { get; }
        public Point(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }
    }
}
