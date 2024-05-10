namespace Programming
{
    /// <summary>
    /// Проверяет пересечение 2 объектов.
    /// </summary>
    public class CollisionManager
    {
        /// <summary>
        /// Проверяет наличие столкновения между 2 окружностями.
        /// </summary>
        /// <param name="ring1">Первая окружность.</param>
        /// <param name="ring2">Вторая окружность.</param>
        /// <returns>Возвращает true, если столкновение есть, иначе false.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double dx = Math.Abs(ring1.Center.X - ring2.Center.X);
            double dy = Math.Abs(ring1.Center.Y - ring2.Center.Y);

            double c = Math.Sqrt(dx * dx + dy * dy);

            if ((ring1.RadiusMax + ring2.RadiusMax) <= c) return false;
            return
                !(ring1.RadiusMax + c < ring2.RadiusMin ||
                ring2.RadiusMax + c < ring1.RadiusMin);
        }
        /// <summary>
        /// Проверяет наличие столкновения между 2 прямоугольниками.
        /// </summary>
        /// <param name="rectangle1">Первый прямоугольник.</param>
        /// <param name="rectangle2">Второй прямоугольник.</param>
        /// <returns>Возвращает true, если столкновение есть, иначе false.</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            Point2D distance = new Point2D(
                Math.Abs(rectangle2.Center.X - rectangle1.Center.X),
                Math.Abs(rectangle2.Center.Y - rectangle1.Center.Y));

            Point2D rect1HalfSize = new Point2D(rectangle1.Width / 2, rectangle1.Height / 2);
            Point2D rect2HalfSize = new Point2D(rectangle2.Width / 2, rectangle2.Height / 2);

            Point2D minDistance = rect1HalfSize + rect2HalfSize;
            return distance.X < minDistance.X && distance.Y < minDistance.Y;
        }
    }
}
