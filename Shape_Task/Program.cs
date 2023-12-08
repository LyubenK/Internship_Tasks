using Task_1;

Triangle triangle = new Triangle(8, 4, 3, 5);
Console.WriteLine(triangle.CalculateArea());
Console.WriteLine(triangle.CalculatePerimeter());

Rectangle rectangle = new Rectangle(3, 5);
Console.WriteLine(rectangle.CalculateArea());
Console.WriteLine(rectangle.CalculatePerimeter());

Circle circle = new Circle(5);
Console.WriteLine(circle.CalculateArea());
Console.WriteLine(circle.CalculatePerimeter());

Console.ReadLine();