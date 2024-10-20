namespace Programming
{
    /// <summary>
    /// Хранит данные о прямоугольнике.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Хранит данные о длине прямоугольника.
        /// </summary>
        private double _height;

        /// <summary>
        /// Хранит данные о ширине прямоугольника.
        /// </summary>
        /// 
        private double _width;

        /// <summary>
        /// Хранит данные о id прямоугольника.
        /// </summary>
        private int _id;

        /// <summary>
        /// Хранит числовое значение при вызове конструктора для id.
        /// </summary>
        private static int _allRectangleCount = 0;

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        public Rectangle()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="height">Высота прямоугольника. Должна быть числом.</param>
        /// <param name="width">Ширина прямоугольника. Должна быть числом.</param>
        /// <param name="color">Цвет прямоугольника, должен быть строкой.</param>
        /// <param name="centerX">Х-координата центра прямоугольника. Должна быть числом.</param>
        /// <param name="centerY">У-координата центра прямоугольника. Должна быть числом.</param>
        /// Также при вызове конструктора увеличивается на 1 id прямоугольника.
        public Rectangle(double height, double width, string color, double centerX, double centerY)
        {
            Height = height;
            Width = width;
            Color = color;
            Center = new Point2D(centerX, centerY);
            Id = _allRectangleCount++;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="height">Высота прямоугольника. Должна быть числом.</param>
        /// <param name="width">Ширина прямоугольника. Должна быть числом.</param>
        /// <param name="centerX">Х-координата центра прямоугольника. Должна быть числом.</param>
        /// <param name="centerY">У-координата центра прямоугольника. Должна быть числом.</param>
        public Rectangle(double height, double width, double centerX, double centerY)
        {
            Height = height;
            Width = width;
            Center = new Point2D(centerX, centerY);
            Id = _allRectangleCount++;
        }

        /// <summary>
        /// Возвращает и устанавливает цвет прямоугольника
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возвращает центральную точку прямоугольника при помощи класса <see cref="Point2D"/>.
        /// </summary>
        public Point2D Center { get;  set; }

        /// <summary>
        /// Возвращает id прямоугольника.
        /// </summary>
        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        /// <summary>
        /// Возвращает номер прямоугольника.
        /// </summary>
        public static int AllRectanglesCount
        {
            get { return _allRectangleCount; }
            private set { _allRectangleCount = value; }
        }

        /// <summary>
        ///  Возвращает и задает высоту прямоугольника.
        ///  Задает через проверку при помощи класса <see cref="Validator"/>. Значение должно быть положительным числом.
        /// </summary>
        public double Height
        {
            get { return _height; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Height));
                _height = value;
            }
        }

        /// <summary>
        /// Возвращает и задает ширину прямоугольника.
        /// Задает через проверку при помощи класса <see cref="Validator"/>. Значение должно быть положительным числом.
        /// </summary>
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
