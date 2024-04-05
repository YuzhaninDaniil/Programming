namespace Programming
{
    public class Flight
    {
        private int _flightTimeInMinutes;

        // Автосвойства
        public string DeparturePoint { get; set; }
        public string DestinationPoint { get; set; }

        // Конструктор без параметров
        public Flight()
        {
        }
        // Конструктор с параметрами
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
                if (value < 0)
                {
                    throw new ArgumentException("Время полета не может быть отрицательным.");
                }
                _flightTimeInMinutes = value;
            }
        }
    }
}
