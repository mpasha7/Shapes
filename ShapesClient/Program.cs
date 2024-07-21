using Shapes;

namespace ShapesClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>
            {
                new Circle(1),
                new Triangle(3, 4, 3),
                new Rectangle(3, 5)         // Пример класса, наследованного от библиотечного
            };

            foreach (IShape shape in shapes)
            {
                Console.WriteLine($"Периметр: {shape.GetPerimeter()}"); // Вычисление площади и периметра без знания типа фигуры 
                Console.WriteLine($"Площадь: {shape.GetArea()}");
                if (shape is Circle circle)
                {
                    Console.WriteLine($"Радиус: {circle.Radius}");
                    circle.SetRadius(2);
                    Console.WriteLine($"\nНовый радиус: {circle.Radius}");
                }
                else if (shape is Polygon polygon)
                {
                    Console.Write("Стороны:");
                    foreach (double side in polygon.Sides)
                    {
                        Console.Write($"  {side}");
                    }
                    if (shape is Triangle triangle)
                        Console.WriteLine($"\nЭто прямоугольный треугольник?: {triangle.IsRight()}");
                    else if (shape is Rectangle rectangle)
                        Console.WriteLine($"\nЭто квадрат?: {rectangle.IsSquare()}");

                    polygon.TrySetSide(0, 5);
                    Console.Write("\nНовые стороны:");
                    foreach (double side in polygon.Sides)
                    {
                        Console.Write($"  {side}");
                    }
                    if (shape is Triangle triang)
                        Console.WriteLine($"\nА теперь прямоугольный треугольник?: {triang.IsRight()}");
                    else if (shape is Rectangle rectangle)
                        Console.WriteLine($"\nА теперь квадрат?: {rectangle.IsSquare()}");
                }
                Console.WriteLine($"Новый периметр: {shape.GetPerimeter()}");
                Console.WriteLine($"Новая площадь: {shape.GetArea()}");
                Console.WriteLine(new string('-', 30));
            }

            Console.ReadKey();
        }
    }
}
