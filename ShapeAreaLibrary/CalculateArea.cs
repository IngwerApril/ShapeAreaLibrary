namespace ShapeAreaLibrary
{
    // Интерфейс вычисленя площади фигуры, чтобы облегчить реализацию других фигур - просто унаследуй и реализуй метод
    public interface IShape
    {
        double CalculateArea(); // Метод вычисления площади фигуры, во время компиляции благодаря интерфейсу и этому методу не потребуется знать конкретный типп фигуры
    }
    public class Circle : IShape
    {
        public double Radius { get; set; }
        public Circle(double _radius)
        {
            Radius = _radius;
        }

        // Метод для вычисления площади круга
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    public class Triangle : IShape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public Triangle(double _sideA, double _sideB, double _sideC)
        {
            SideA = _sideA;
            SideB = _sideB;
            SideC = _sideC;
        }

        // Метод вычисления площади треугольника
        public double CalculateArea()
        {
            double p = (SideA + SideB + SideC) / 2.0; // Полупериметр
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC)); // Формула площади треугольника
        }

        // Метод проверки ан прямоугольность
        public bool IsRight()
        {
            double[] sides = { SideA, SideB, SideC };
            Array.Sort(sides);//Сортируем массив сторон, чтобы определить гипотенузу и катеты
            // Проверка на прямоугольность с погрешностью в одну тысячную
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 0.001;
        }
    }
}
