using GeometryLibrary.Abstracts;

namespace GeometryLibrary.Shapes
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Метод для вычисления площади круга
        /// Площадь = π * r^2
        /// </summary>
        /// <returns>Площадь double</returns>
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
