namespace GeometryLibrary.Abstracts
{
    //Легкость расширения: Если потребуется добавить новую фигуру (например, прямоугольник),
    //достаточно создать новый класс, реализующий Shape, и добавить вычисление площади.

    /// <summary>
    /// Абстрактный класс для фигур
    /// </summary>
    public abstract class Shape
    {
        public abstract double GetArea();
    }
}
