using ShapeLibrary;
namespace ShapeTests
{
[TestClass]
public class SquareTests
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

            
            object value = Assert.AreEqual(20, result);
    }

   
}

    internal class TestMethodAttribute : Attribute
    {
    }

    internal class TestClassAttribute : Attribute
    {
    }
}