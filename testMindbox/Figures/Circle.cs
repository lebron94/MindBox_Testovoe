namespace testMindbox.Figures
{
    public class Circle : IFigure
    {
        /// <summary>
        /// Поле Радиус
        /// </summary>
        public double Radius { get; }
        /// <summary>
        /// Строкова перемнная для исключений
        /// </summary>
        public const string lengthArgumentException = "Length could not be less or equals 0";
        /// <summary>
        /// Конструктор для круга, который обрабатывает исключения и 
        /// сохраняет значение радиуса
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// <exception cref="ArgumentException">Исключение длины радиуса</exception>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException(lengthArgumentException);
            }
            else
            {
                Radius = radius;
            }
        }
        /// <summary>
        /// Реализация интерфейса
        /// </summary>
        /// <returns>Площадь круга</returns>
        public double getArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
