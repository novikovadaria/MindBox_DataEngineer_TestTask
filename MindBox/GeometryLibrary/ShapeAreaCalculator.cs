using GeometryLibrary.Abstracts;

namespace GeometryLibrary
{
    /// <summary>
    /// Класс для вычисления площади фигуры без знания типа фигуры 
    /// </summary>
    public class ShapeAreaCalculator
    {
        public static double CalculateArea(Shape shape)
        {
            return shape.GetArea();
        }
    }
}
