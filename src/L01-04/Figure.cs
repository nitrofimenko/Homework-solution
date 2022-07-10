using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01_04
{
    internal class Figure
    {
        Point[] points = new Point[5];
        int length;
        double perimeter = 0;
        public Figure(Point A, Point B, Point C)
        {
            points[0] = A;
            points[1] = B;
            points[2] = C;
            length = 3;
        }
        public Figure(Point A, Point B, Point C, Point D)
        {
            points[0] = A;
            points[1] = B;
            points[2] = C;
            points[3] = D;
            length = 4;
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            points[0] = A;
            points[1] = B;
            points[2] = C;
            points[3] = D;
            points[4] = E;
            length = 5;
        }
        double LengthSide(Point A, Point B)
        {
            return Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
        }
        void PerimeterCalculator()
        {
            perimeter = LengthSide(points[0], points[length - 1]);
            for (int i = 0; i < length - 1; i++)
            {
                perimeter += LengthSide(points[i], points[i + 1]);
            }
        }
        public void ShowNameAndPerimeter()
        {
            string name="";
            for (int i = 0; i < length; i++)
            {
                name += points[i].Name;
            }
            PerimeterCalculator();
            Console.WriteLine($"Perimeter of {name} polygon is {perimeter:N2}");
        }
    }
}
