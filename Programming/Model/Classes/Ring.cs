namespace Programming
{
    public class Ring
    {
        private double _externalRadius;
        private double _internalRadius;

        public Ring(double externalRadius, double internalRadius, double centerX, double centerY)
        {
            ExternalRadius = externalRadius;
            InternalRadius = internalRadius;
            Center = new Point2D(centerX, centerY);
        }

        public Ring()
        {

        }

        public Point2D Center { get; private set; }

        private double GetRingArea()
        {
            return Math.PI * ExternalRadius * ExternalRadius - Math.PI * InternalRadius * InternalRadius;
        }

        public double Area
        {
            get { return GetRingArea(); }
        }

        public double ExternalRadius
        {
            get { return _externalRadius; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(ExternalRadius));

                if (value < InternalRadius)
                {
                    throw new ArgumentException($"Поле {ExternalRadius} должно быть больше {InternalRadius}"); 
                }
                _externalRadius = value;
            }
        }

        public double InternalRadius
        {
            get { return _internalRadius; }
            set
            {
                Validator.AssertOnPositiveValue(_internalRadius, nameof(InternalRadius));

                if (value > ExternalRadius)
                {
                    throw new ArgumentException($"Поле {InternalRadius} должно быть меньше {ExternalRadius}");
                }
                _internalRadius = value;
            }
        }
    }
}
