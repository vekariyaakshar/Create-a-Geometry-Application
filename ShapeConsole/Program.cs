using ShapeLibrary;
using Microsoft.Extensions.Configuration;
using Microsoft.FeatureManagement;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
class Program
{
    static async Task Main(string[] args)
    {
        
        var featureManagement = new Dictionary<string, string>
        {
            { "FeatureManagement:Square", "true" },
            { "FeatureManagement:Rectangle", "false" },
            { "FeatureManagement:Triangle", "true" }
        };


        IConfigurationRoot configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(featureManagement)
            .Build();

        var services = new ServiceCollection();
        services.AddFeatureManagement(configuration);
        var serviceProvider = services.BuildServiceProvider();

        var featureManager = serviceProvider.GetRequiredService<IFeatureManager>();
        if (await featureManager.IsEnabledAsync("Square"))
        {
            Console.WriteLine("Enter the side length of the square:");
            if (double.TryParse(Console.ReadLine(), out double squareSide))
            {
                var square = new Square(squareSide);
                Console.WriteLine($"Square Area: {square.CalculateArea()}, Perimeter: {square.CalculatePerimeter()}");
            }
            else
            {
                Console.WriteLine("Invalid input for square side length.");
            }
        }

        if (await featureManager.IsEnabledAsync("Rectangle"))
        {
            Console.WriteLine("Enter the length of the rectangle:");
            if (double.TryParse(Console.ReadLine(), out double rectangleLength))
            {
                Console.WriteLine("Enter the width of the rectangle:");
                if (double.TryParse(Console.ReadLine(), out double rectangleWidth))
                {
                    var rectangle = new Rectangle(rectangleLength, rectangleWidth);
                    Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}, Perimeter: {rectangle.CalculatePerimeter()}");
                }
                else
                {
                    Console.WriteLine("Invalid input for rectangle width.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for rectangle length.");
            }
        }

        if (await featureManager.IsEnabledAsync("Triangle"))
        {
            Console.WriteLine("Enter the base length of the triangle:");
            if (double.TryParse(Console.ReadLine(), out double triangleBase))
            {
                Console.WriteLine("Enter the height of the triangle:");
                if (double.TryParse(Console.ReadLine(), out double triangleHeight))
                {
                    Console.WriteLine("Enter the length of side 1 of the triangle:");
                    if (double.TryParse(Console.ReadLine(), out double triangleSide1))
                    {
                        Console.WriteLine("Enter the length of side 2 of the triangle:");
                        if (double.TryParse(Console.ReadLine(), out double triangleSide2))
                        {
                            var triangle = new Triangle(triangleBase, triangleHeight, triangleSide1, triangleSide2);
                            Console.WriteLine($"Triangle Area: {triangle.CalculateArea()}, Perimeter: {triangle.CalculatePerimeter()}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for triangle side 2.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for triangle side 1.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for triangle height.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for triangle base length.");
            }
        }
    }
}

