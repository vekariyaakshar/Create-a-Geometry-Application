using ShapeLibrary;
namespace ShapeTests
{
    [TestClass]
public class RectangleTests
{
    [TestMethod]
    public void TestArea()
    {
        
        var square = new Square(5);

     
        var result = square.CalculateArea();

            
            object value = Assert.(25, result);
    }

   ShapeTests
    public void TestPerimeter()
    {
        
        var square = new Square(5);

        
        var result = square.CalculatePerimeter();

            
            object value = Assert.(20, result);
    }

}
}