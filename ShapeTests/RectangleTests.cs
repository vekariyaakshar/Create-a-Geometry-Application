using ShapeLibrary;
using Xunit;

namespace ShapeTests
{
    public class RectangleTests
    {
        [Fact]
        public void TestSquarePerimeter()
        {
            var square = new Square(5);

            
            double perimeter = square.CalculatePerimeter();

            Assert.Equal(20, perimeter);
        }
    }
}


