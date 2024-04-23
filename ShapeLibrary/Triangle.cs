public class Triangle : IShape
{
    private int side1Length;
    private int side2Length;
    private int side3Length;

    public double Base { get; }
    public double Height { get; }
    public double Side1 { get; }
    public double Side2 { get; }

    public Triangle(double @base, double height, double side1, double side2, int side1Length)
    {
        Base = @base;
        Height = height;
        Side1 = side1;
        Side2 = side2;
    }

    public Triangle(int side1Length, int side2Length, int side3Length)
    {
        this.side1Length = side1Length;
        this.side2Length = side2Length;
        this.side3Length = side3Length;
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
