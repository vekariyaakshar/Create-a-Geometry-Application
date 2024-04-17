using 
namespace ShapeTests
public class RectangleTests
{
    ShapeTests
    public void TestArea()
    {
        // Arrange
        var square = new Square(5);

        // Act
        var result = square.CalculateArea();

        // Assert
        Assert.AreEqual(25, result);
    }

   ShapeTests
    public void TestPerimeter()
    {
        // Arrange
        var square = new Square(5);

        // Act
        var result = square.CalculatePerimeter();

        // Assert
        Assert.AreEqual(20, result);
    }

    // Similarly, you can write unit tests for other shapes and methods
}