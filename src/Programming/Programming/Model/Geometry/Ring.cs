namespace Programming
{
    /// <summary>
    /// Хранит данные об окружности.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Внешний радиус.
        /// </summary>
        private double _externalRadius;

        /// <summary>
        /// Внутренний радиус.
        /// </summary>
        private double _internalRadius;

        /// <summary>
        /// Экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        private Point2D _center;

        /// <summary>
        /// Возвращает и задает минимальный радиус окружности.
        /// Задает через проверку при помощи класса <see cref="Validator"/>. Значение должно быть положительным и меньше внутреннего радиуса.
        /// </summary>
        public double RadiusMin
        {
            get { return _externalRadius; }
            set
            {
                Validator.AssertValueInRange(value, 0, _internalRadius, nameof(RadiusMin));
                _externalRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задает максимальный радиус окружности.
        /// Задает через проверку при помощи класса <see cref="Validator"/>. Значение должно быть меньше <see cref="int.MaxValue"/ и больше внешнего радиуса>.
        /// </summary>
        public double RadiusMax
        {
            get { return _internalRadius; }
            set
            {
                Validator.AssertValueInRange(value, _externalRadius, int.MaxValue, nameof(RadiusMax));
                _internalRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задает центр окружности с помощью класса <see cref="Point2D"/>.
        /// </summary>
        public Point2D Center
        {
            get { return _center; }
            set { _center = value; }
        }

        /// <summary>
        /// Возвращает площадь окружности как разницу площадей от внутреннего радиуса и внешнего.
        /// </summary>
        public double Area
        {
            get { return Square(_internalRadius) - Square(_externalRadius); }
        }

        /// <summary>
        /// Подсчитывает площадь окружности.
        /// </summary>
        /// <param name="rad">Радиус окружности.</param>
        /// <returns>Возвращает площадь окружности.</returns>
        private double Square(double rad)
        {
            return Math.PI * Math.Pow(rad, 2);
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="radiusMin">Минимальный радиус окружности.</param>
        /// <param name="radiusMax">Максимальный радиус окружности.</param>
        /// <param name="center">Центр окружности класса <see cref="Point2D"/></param>.
        public Ring(int radiusMin, int radiusMax, Point2D center)
        {
            RadiusMin = radiusMin;
            RadiusMax = radiusMax;
            Center = center;
        }
    }
}
