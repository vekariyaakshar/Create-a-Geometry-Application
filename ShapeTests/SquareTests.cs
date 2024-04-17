using ShapeLibrary;
namespace ShapeTests
{
[TestClass]
public class SquareTests
{
    [TestMethod]
    public void TestArea()
    {
        // Arrange
        var square = new Square(5);

        // Act
        var result = square.CalculateArea();

            // Assert
            object value = Assert.(25, result);
    }

    [TestMethod]
    public void TestPerimeter()
    {
        // Arrange
        var square = new Square(5);

        // Act
        var result = square.CalculatePerimeter();

            // Assert
            object value = Assert.AreEqual(20, result);
    }

    // Similarly, you can write unit tests for other shapes and methods
}

    internal class TestMethodAttribute : Attribute
    {
    }

    internal class TestClassAttribute : Attribute
    {
    }
}