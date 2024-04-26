using System.Drawing;

namespace Programming
{
    public class RectangleFactory
    {
        public static Rectangle Randomize(int height, int width)
        {
            Rectangle myRectangle = new Rectangle();
            Random random = new Random();

            height = random.Next(60, 300);
            width = random.Next(60, 300);
            double CenterX = random.Next(50, width);
            double CenterY = random.Next(50, height);
            myRectangle = new Rectangle(height, width, CenterX, CenterY);

            return myRectangle;
        }
    }
}
