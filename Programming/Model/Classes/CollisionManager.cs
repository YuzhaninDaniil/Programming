namespace Programming
{
    public class CollisionManager
    {
        public bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double dx = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            double dy = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
            bool isXCollision = dx < Math.Abs(rectangle1.Width + rectangle2.Width)/2;
            bool isYCollision = dy < Math.Abs(rectangle1.Height + rectangle2.Height)/2;

            if (isXCollision && isYCollision)
            {
                return true;
            }
            return false;
        }

        public bool IsCollision(Ring ring1, Ring ring2)
        {
            double dx = Math.Abs(ring1.Center.X - ring2.Center.X);
            double dy = Math.Abs(ring1.Center.Y - ring2.Center.Y);
            double c = Math.Sqrt(dx * dx + dy * dy);

            if (c < ring1.ExternalRadius + ring2.ExternalRadius)
            {
                return true;
            }
            return false;
        }
    }
}
