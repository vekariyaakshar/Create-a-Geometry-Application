public class Triangle : IShape
{
    public double Base { get; }
    public double Height { get; }
    public double Side1 { get; }
    public double Side2 { get; }

    public Triangle(double @base, double height, double side1, double side2)
    {
        Base = @base;
        Height = height;
        Side1 = side1;
        Side2 = side2;
    }

    public double CalculateArea()
    {
        return 0.5 * Base * Height;
    }

    public double CalculatePerimeter()
    {
        return Base + Side1 + Side2;
    }
}
