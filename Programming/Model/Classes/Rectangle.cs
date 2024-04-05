namespace Programming
{
    public class Rectangle
    {
        private double _length;
        private double _width;

        // Автосвойство
        public string Color { get; set; }

        // Конструктор без аргументов
        public Rectangle()
        {

        }
        // Конструктор с параметрами
        public Rectangle(double length, double width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }
        public double Length
        {
            get { return _length; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Длина прямоугольника не может быть отрицательной.");
                }
                _length = value;
            }
        }
        public double Width
        {
            get { return _width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ширина прямоугольника не может быть отрицательной.");
                }
                _width = value;
            }
        }

    }
}
