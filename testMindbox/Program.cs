using testMindbox.Figures;

namespace testMindbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose figure");
                Console.WriteLine("type 1 for circle");
                Console.WriteLine("type 2 triangle");
                var type = Console.ReadLine();
                Console.WriteLine("Input data:");
                var input = Console.ReadLine();
                try
                {
                    switch (int.Parse(type))
                    {
                        case (int)FigureTypes.Circle: 
                            Circle circle = new Circle(double.Parse(input));
                            Console.WriteLine("Area of circle is {0}", circle.getArea());
                            break;
                        case (int)FigureTypes.Triangle:
                            var sides = input.Split(' ');
                            Triangle triangle = new Triangle(
                                double.Parse(sides[0]),
                                double.Parse(sides[1]),
                                double.Parse(sides[2]));
                            Console.WriteLine("Area of triangle is {0}", triangle.getArea());
                            Console.WriteLine("Is triangle right?: {0}", triangle.isTriangleRight());
                            break;
                         default: Console.WriteLine("Unknown shape");
                            break;
                    }
                    Console.WriteLine("----------------------");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("----------------------");
                }
            }

        }
    }
}