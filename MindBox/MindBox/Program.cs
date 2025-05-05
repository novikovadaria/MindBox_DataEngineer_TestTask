using GeometryLibrary;
using GeometryLibrary.Shapes;

var circle = new Circle(10);
var area = ShapeAreaCalculator.CalculateArea(circle);

Console.WriteLine($"Area of the circle with radius {circle.Radius} is: {area}");


var triangle = new Triangle(6, 8, 10);
var triangleArea = ShapeAreaCalculator.CalculateArea(triangle);

Console.WriteLine($"Area of the triangle with sides {triangle.SideA}, {triangle.SideB}, {triangle.SideC} is: {triangleArea}");
