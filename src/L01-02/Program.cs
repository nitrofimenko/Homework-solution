using L01_02;

Console.Write("Input size of rectangle side 1: ");
double rectangleSide1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input size of rectangle side 2: ");
double rectangleSide2 = Convert.ToDouble(Console.ReadLine());
Rectangle userRectangle = new Rectangle(rectangleSide1,rectangleSide2);
Console.WriteLine($"Rectangle perimeter is {userRectangle.Perimeter}.");
Console.WriteLine($"Rectangle area is {userRectangle.Area}.");