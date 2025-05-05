using GeometryLibrary.Abstracts;

namespace GeometryLibrary
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Метод для вычисления площади треугольника через формулу Герона 
        /// Площадь = √(p * (p - a) * (p - b) * (p - c)), где p = (a + b + c) / 2
        /// </summary>
        /// <returns>Площадь double</returns>
        public override double GetArea()
        {
            double semiPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }

        /// <summary>
        /// Метод для проверки, является ли треугольник прямоугольным
        /// Используем теорему Пифагора: c^2 = a^2 + b^2
        /// </summary>
        /// <returns>bool</returns>
        public bool IsRightAngled()
        {
            double[] sides = { SideA, SideB, SideC };
            Array.Sort(sides);
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-6;
        }
    }
}
