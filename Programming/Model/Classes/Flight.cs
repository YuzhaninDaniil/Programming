namespace Programming
{
    public class Flight
    {
        private int _flightTimeInMinutes;

        public string DeparturePoint { get; set; }
        public string DestinationPoint { get; set; }

        public Flight()
        {

        }

        public Flight(string departurePoint, string destinationPoint, int flightTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            FlightTimeInMinutes = flightTimeInMinutes;
        }

        public int FlightTimeInMinutes
        {
            get { return _flightTimeInMinutes; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(FlightTimeInMinutes));
                _flightTimeInMinutes = value;
            }
        }
    }
}
