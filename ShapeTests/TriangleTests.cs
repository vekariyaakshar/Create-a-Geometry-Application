using ShapeLibrary;

using ShapeTests;

namespace ShapeTests
{
    
}
public class TriangleTests
{
    [TestMethod]
    public void TestArea()
    {
       
        var square = new Square(5);

       
        var result = square.CalculateArea();

        
        object value = Assert.(25, result);
    }

    [TestMethod]
    public void TestPerimeter()
    {
     
        var square = new Square(5);

        
        var result = square.CalculatePerimeter();

     
        object value = Assert.(20, result);
    }

   
}