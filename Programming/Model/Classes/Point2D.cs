namespace Programming
{
    public class Point2D
    {
        private double _x;
        private double _y;

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X
        {
            get { return _x; }
            private set
            {
                _x = value; 
            }
        }

        public double Y
        {
            get { return _y; }
            private set
            {
                _y = value;
            }
        }
    }
}
