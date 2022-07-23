using L01_04;

Console.Write("Input size of rectangle side 1: ");
double rectangleSide1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input size of rectangle side 2: ");
double rectangleSide2 = Convert.ToDouble(Console.ReadLine());
Rectangle userRectangle = new Rectangle(rectangleSide1, rectangleSide2);
Console.WriteLine($"Rectangle perimeter is {userRectangle.Perimeter}.");
Console.WriteLine($"Rectangle area is {userRectangle.Area}.\n");

Random random = new Random();
const int MAX = 100;
const int MIN = -MAX;

Point newPoint(int x, int y, string name)
{
    Console.WriteLine($"Point {name,-4}{x,4}, {y,4}");
    return new Point(x, y, name);
}

Point pointA = newPoint(random.Next(MIN,MAX), random.Next(MIN, MAX),"A");
Point pointB = newPoint(random.Next(MIN,MAX), random.Next(MIN, MAX),"B");
Point pointC = newPoint(random.Next(MIN,MAX), random.Next(MIN, MAX),"C");
Point pointD = newPoint(random.Next(MIN,MAX), random.Next(MIN, MAX),"D");
Point pointE = newPoint(random.Next(MIN,MAX), random.Next(MIN, MAX),"E");

Figure figABC = new Figure(pointA, pointB, pointC);
Figure figABCD = new Figure(pointA, pointB, pointC, pointD);
Figure figABCDE = new Figure(pointA, pointB, pointC, pointD, pointE);

figABC.ShowNameAndPerimeter();
figABCD.ShowNameAndPerimeter();
figABCDE.ShowNameAndPerimeter();