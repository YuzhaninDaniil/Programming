namespace Programming
{
    public class Rectangle
    {
        private double _height;
        private double _width;
        private int _id;
        private static int _allRectangleCount = 0;

        public Rectangle()
        {
            Id = _allRectangleCount++;
        }

        public Rectangle(double height, double width, string color, double centerX, double centerY)
        {
            Height = height;
            Width = width;
            Color = color;
            Center = new Point2D(centerX, centerY);
            //_allRectangleCount++;
            //Id = _allRectangleCount;

        }

        public Rectangle(double height, double width, double centerX, double centerY)
        {
            Height = height;
            Width = width;
            Center = new Point2D(centerX, centerY);
            //_allRectangleCount++;
            //Id = _allRectangleCount;

        }
        public string Color { get; set; }

        public Point2D Center { get;  set; }
        //public Point2D Center
        //{
        //    get { return _center; }
        //    set { _center = value; }
        //}

        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        public static int AllRectanglesCount
        {
            get { return _allRectangleCount; }
            private set { _allRectangleCount = value; }
        }

        public double Height
        {
            get { return _height; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Height));
                _height = value;
            }
        }

        public double Width
        {
            get { return _width; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

    }
}
