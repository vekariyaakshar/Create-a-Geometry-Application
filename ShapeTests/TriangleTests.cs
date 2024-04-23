using ShapeLibrary;
using Xunit;

namespace ShapeTests
{
    public class TriangleTests
    {
        [Fact]
        public void TestTrianglePerimeter()
        {
            // Arrange
            var triangle = new Triangle(
                side1Length: 3, side2Length: 4, side3Length: 5);

            // Act
            double perimeter = triangle.CalculatePerimeter();

            // Assert
            Assert.Equal(12, perimeter);
        }
    }
}
