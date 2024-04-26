using System.Drawing;

namespace Programming
{
    public class CollisionManager
    {
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
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            // Расчет расстояния между центрами прямоугольников по осям X и Y
            Point2D distance = new Point2D(
                Math.Abs(rectangle2.Center.X - rectangle1.Center.X),
                Math.Abs(rectangle2.Center.Y - rectangle1.Center.Y));

            // Расчет половины ширины и высоты каждого прямоугольника
            Point2D rect1HalfSize = new Point2D(rectangle1.Width / 2, rectangle1.Height / 2);
            Point2D rect2HalfSize = new Point2D(rectangle2.Width / 2, rectangle2.Height / 2);

            // Расчет суммарных половин размеров прямоугольников
            Point2D minDistance = rect1HalfSize + rect2HalfSize;

            // Проверка условия столкновения
            return distance.X < minDistance.X && distance.Y < minDistance.Y;
        }
    }
}
