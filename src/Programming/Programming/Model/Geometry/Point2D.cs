namespace Programming
{
    /// <summary>
    /// Хранит данные об точке в двумерном пространстве.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Хранит х-координату точки.
        /// </summary>
        private double _x;

        /// <summary>
        /// Хранит у-координату точки.
        /// </summary>
        private double _y;

        /// <summary>
        /// Создает экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">х-координата точки, должна быть double.</param>
        /// <param name="y">y-координата точки, должна быть double.</param>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Возвращает х-координату точки.
        /// </summary>
        public double X
        {
            get { return _x; }
            private set
            {
                _x = value; 
            }
        }

        /// <summary>
        /// Возвращает y-координату точки.
        /// </summary>
        public double Y
        {
            get { return _y; }
            private set
            {
                _y = value;
            }
        }

        /// <summary>
        /// Перегруженный оператор сложения для точек.
        /// </summary>
        /// <param name="point1">Первая точка.</param>
        /// <param name="point2">Вторая точка.</param>
        /// <returns></returns>
        public static Point2D operator +(Point2D point1, Point2D point2)
        {
            return new Point2D(point1.X + point2.X, point1.Y + point2.Y);
        }
    }
}
