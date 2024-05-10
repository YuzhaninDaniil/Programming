namespace Programming
{
    /// <summary>
    /// Генерирует случайный прямоугольник.
    /// </summary>
    public class RectangleFactory
    {
        /// <summary>
        /// Создает случайных размеров прямоугольник при помощи класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="height">Высота прямоугольника.</param>
        /// <param name="width">Ширина прямоугольника.</param>
        /// <returns>Возвращает прямоугольник случайных размеров.</returns>
        public static Rectangle Randomize(int height, int width)
        {
            Rectangle myRectangle = new Rectangle();
            Random random = new Random();

            height = random.Next(30, 90);
            width = random.Next(25, 110);
            double CenterX = random.Next(40, 400);
            double CenterY = random.Next(70, 320);
            myRectangle = new Rectangle(height, width, CenterX, CenterY);

            return myRectangle;
        }
    }
}
