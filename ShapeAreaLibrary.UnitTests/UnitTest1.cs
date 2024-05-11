using ShapeAreaLibrary; // библиотека с фигурами

[TestFixture] // Атрибут, показывабщий, что это класс с тестами
public class UnitTests
{
    //Тест вычисления площади круга
    [Test]
    public void CircleArea()
    {
        var circle = new Circle(5); // Создание круга с радиусом 5
        Assert.AreEqual(Math.PI * 25, circle.CalculateArea()); // Проверка правильности вычисленной площади, ответ - число Пи на квадрат радиусов
    }

    // Тест вычисления площади треугольника
    [Test]
    public void TriangleArea()
    {
        var triangle = new Triangle(3, 4, 5); // Создание треугольника со сторонами 3, 4, 5
        Assert.AreEqual(6, triangle.CalculateArea()); // Проверка правильности вычисленной площади - корректный ответ: 6
    }

    // Тест проверки треугольника на прямоугольность
    [Test]
    public void TriangleRight()
    {
        var triangle = new Triangle(3, 4, 5); // Создание прямоугольного треугольника со сторонами 3, 4, 5
        Assert.IsTrue(triangle.IsRight()); // Проверка, что треугольник прямоугольный
    }
}
