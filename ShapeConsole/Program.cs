using ShapeLibrary;

class Program
{
    static void Main(string[] args)
    {
        var square = new Square(5);
        var rectangle = new Rectangle(4, 6);
        var triangle = new Triangle(3, 4, 5, 6);

        Console.WriteLine($"Square Area: {square.CalculateArea()}, Perimeter: {square.CalculatePerimeter()}");
        Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}, Perimeter: {rectangle.CalculatePerimeter()}");
        Console.WriteLine($"Triangle Area: {triangle.CalculateArea()}, Perimeter: {triangle.CalculatePerimeter()}");
    }
}
