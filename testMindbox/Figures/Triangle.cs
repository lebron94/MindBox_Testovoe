namespace testMindbox.Figures
{
    public class Triangle : IFigure
    {
        /// <summary>
        /// Стороны треугольника
        /// </summary>
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        /// <summary>
        /// Поле, обозночающее правильный
        /// треугольник или нет
        /// </summary>
        public bool IsTriangleRight { get; }
        /// <summary>
        /// Тексты исключения
        /// </summary>
        public const string lengthArgumentException = "Length could not be less or equals 0";
        public const string existingTriangleExeption = "Triangle does not exist";
        /// <summary>
        /// Конструктор для треугольника
        /// </summary>
        /// <param name="sideA">сторона A</param>
        /// <param name="sideB">сторона B</param>
        /// <param name="sideC">сторона C</param>
        /// <exception cref="ArgumentException">Исключения</exception>
        public Triangle(double sideA, double sideB, double sideC) 
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException(lengthArgumentException);
            }
            else if (sideA + sideB <= sideC || sideB + sideC <= sideA || sideA + sideC <= sideB)
            {
                throw new ArgumentException(existingTriangleExeption);
            }

            else
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;
            }
        }     
        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public double getArea()
        {
            double p = (SideA + SideB + SideC)/2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
        /// <summary>
        /// Вычисление правильности треугольника
        /// </summary>
        /// <returns>Правильный или не правильный</returns>
        public bool isTriangleRight()
        {
            double[] sides = new[] { SideA, SideB, SideC };
            int max = Array.IndexOf(sides, sides.Max());
            double sumOfCats = 0;
            for (int i = 0; i < sides.Length; i++)
            {
                if (i != max)
                {
                    sumOfCats += Math.Pow(sides[i], 2);
                }
            }

            if (Math.Pow(sides[max], 2) == sumOfCats)
                return true;
            else
                return false;
        }

    }
}
