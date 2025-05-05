using GeometryLibrary;
using GeometryLibrary.Shapes;

namespace GeometryLibraryTest
{
    public class ShapeTests
    {
        [Fact]
        public void TestCircleArea()
        {
            // Создаем круг с радиусом 5
            var circle = new Circle(5);
            var area = circle.GetArea();

            Assert.Equal(Math.PI * 25, area, 6);
        }

        [Fact]
        public void TestTriangleArea()
        {
            // Создаем треугольник с длинами сторон 3, 4, 5
            var triangle = new Triangle(3, 4, 5);
            var area = triangle.GetArea();

            Assert.Equal(6, area, 6);
        }

        [Fact]
        public void TestRightAngledTriangle()
        {
            var triangle = new Triangle(3, 4, 5);

            // Проверяем, что треугольник прямоугольный
            Assert.True(triangle.IsRightAngled());
        }

        [Fact]
        public void TestNonRightAngledTriangle()
        {
            var triangle = new Triangle(3, 5, 7);

            // Проверяем, что треугольник не является прямоугольным
            Assert.False(triangle.IsRightAngled());
        }

        [Fact]
        public void TestShapeAreaCalculator()
        {
            var circle = new Circle(10);
            var area = ShapeAreaCalculator.CalculateArea(circle);

            Assert.Equal(Math.PI * 100, area, 6); 

            var triangle = new Triangle(6, 8, 10);
            var triangleArea = ShapeAreaCalculator.CalculateArea(triangle);

            Assert.Equal(24, triangleArea, 6);
        }
    }
}