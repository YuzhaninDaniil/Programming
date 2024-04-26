namespace Programming
{
    public class Ring
    {
        private double _externalRadius;
        private double _internalRadius;
        private Point2D _center;

        public double RadiusMin
        {
            get { return _externalRadius; }
            set
            {
                Validator.AssertValueInRange(value, 0, _internalRadius, nameof(RadiusMin));
                _externalRadius = value;
            }
        }
        public double RadiusMax
        {
            get { return _internalRadius; }
            set
            {
                Validator.AssertValueInRange(value, _externalRadius, int.MaxValue, nameof(RadiusMax));
                _internalRadius = value;
            }
        }
        public Point2D Center
        {
            get { return _center; }
            set { _center = value; }
        }
        public double Area
        {
            get { return Square(_internalRadius) - Square(_externalRadius); }
        }

        private double Square(double rad)
        {
            return Math.PI * Math.Pow(rad, 2);
        }

        public Ring(int radiusMin, int radiusMax, Point2D center)
        {
            RadiusMin = radiusMin;
            RadiusMax = radiusMax;
            Center = center;
        }
    }
}
