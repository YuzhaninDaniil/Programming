namespace Programming
{
    /// <summary>
    /// Хранит данные о времени.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Хранит данные о часах.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Хранит данные о минутах.
        /// </summary>
        private int _minutes;

        /// <summary>
        /// Хранит данные о секундах
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Создает экземпляр класса <see cref="Time"/>.
        /// </summary>
        public Time()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Time"/>.
        /// </summary>
        /// <param name="hours">Время в часах.</param>
        /// <param name="minutes">Время в минутах.</param>
        /// <param name="seconds">Время в секундах.</param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        /// <summary>
        /// Возвращает и задает время в часах.
        /// Задает через проверку при помощи класса <see cref="Validator"/>. Значение должно быть в диапазоне от 0 до 23.
        /// </summary>
        public int Hours
        {
            get { return _hours; }
            set
            {
                Validator.AssertValueInRange(value, 0, 23, nameof(Hours));
                _hours = value;
            }
        }

        /// <summary>
        /// Возвращает и задает время в минутах.
        /// Задает через проверку при помощи класса <see cref="Validator"/>. Значение должно быть в диапазоне от 0 до 60.
        /// </summary>
        public int Minutes
        {
            get { return _minutes; }
            set
            {
                Validator.AssertValueInRange(value, 0, 60, nameof(Minutes));
                _minutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задает время в секундах.
        /// Задает через проверку при помощи класса <see cref="Validator"/>. Значение должно быть в диапазоне от 0 до 60.
        /// </summary>
        public int Seconds
        {
            get { return _seconds; }
            set
            {
                Validator.AssertValueInRange(value, 0, 60, nameof(Seconds));
                _seconds = value;
            }
        }
    }
}
