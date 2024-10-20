namespace Programming
{
    /// <summary>
    /// Хранит информацию о полете.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Хранит данные о времени полета в минутах.
        /// </summary>
        private int _flightTimeInMinutes;

        /// <summary>
        /// Возвращает и задает место отправления.
        /// </summary>
        public string DeparturePoint { get; set; }

        /// <summary>
        /// Возвращает и задает место прибытия.
        /// </summary>
        public string DestinationPoint { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Flight"/>.
        /// </summary>
        public Flight()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="departurePoint">Место отправления, должно быть строкой.</param>
        /// <param name="destinationPoint">Место прибытия, должно быть строкой.</param>
        /// <param name="flightTimeInMinutes">Время полета в минутах, должно быть целочисленным значением.</param>
        public Flight(string departurePoint, string destinationPoint, int flightTimeInMinutes)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            FlightTimeInMinutes = flightTimeInMinutes;
        }

        /// <summary>
        /// Возвращает и задает время полета в минутах.
        /// Задает через проверку при помощи класса <see cref="Validator"/>. Время должна быть положительным числом.
        /// </summary>
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
