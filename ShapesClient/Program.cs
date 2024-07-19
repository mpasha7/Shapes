using Shapes;

namespace ShapesClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>
            {
                new Circle(3),
                new Triangle(5, 4, 5),
                new Rectangle(3, 5)         // Пример класса, наследованного от библиотечного
            };

            foreach (IShape shape in shapes)
            {
                Console.WriteLine($"Периметр: {shape.GetPerimeter()}"); // Вычисление площади и периметра без знания типа фигуры 
                Console.WriteLine($"Площадь: {shape.GetArea()}");
                if (shape is Circle circle)
                {
                    Console.WriteLine($"Радиус: {circle.Radius}");
                    circle.SetRadius(5);
                    Console.WriteLine($"Новый радиус: {circle.Radius}");
                }
                if (shape is Triangle triangle)
                {
                    Console.Write("Стороны:");
                    foreach (double side in triangle.Sides)
                    {
                        Console.Write($"  {side}");
                    }
                    Console.WriteLine($"\nЯвляется прямоугольным треугольником?: {triangle.IsRight()}");

                    triangle.TrySetSide(0, 3);
                    Console.Write("Новые стороны:");
                    foreach (double side in triangle.Sides)
                    {
                        Console.Write($"  {side}");
                    }
                    Console.WriteLine($"\nЯвляется прямоугольным треугольником?: {triangle.IsRight()}");
                }
                if (shape is Rectangle rectangle)
                {
                    Console.Write("Стороны:");
                    foreach (double side in rectangle.Sides)
                    {
                        Console.Write($"  {side}");
                    }
                    Console.WriteLine($"\nЯвляется квадратом?: {rectangle.IsSquare()}");

                    rectangle.TrySetSide(0, 5);
                    Console.Write("Новые стороны:");
                    foreach (double side in rectangle.Sides)
                    {
                        Console.Write($"  {side}");
                    }
                    Console.WriteLine($"\nЯвляется квадратом?: {rectangle.IsSquare()}");
                }

                Console.WriteLine($"Новый периметр: {shape.GetPerimeter()}");
                Console.WriteLine($"Новая площадь: {shape.GetArea()}");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
