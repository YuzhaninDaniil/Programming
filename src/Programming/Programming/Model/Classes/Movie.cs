namespace Programming
{
    /// <summary>
    /// Хранит информацию о фильме.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Хранит данные о длительности фильма в минутах.
        /// </summary>
        private int _durationInMinutes;

        /// <summary>
        /// Хранит данные о годе выпуска фильма.
        /// </summary>
        private int _releaseYear;

        /// <summary>
        /// Хранит данные об оценке фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Хранит данные о названии фильма.
        /// </summary>
        private string _title;

        /// <summary>
        /// Хранит данные о жанре фильма.
        /// </summary>
        private string _genre;

        /// <summary>
        /// Создает экземпляр класса <see cref="Movie"/>.
        /// </summary>
        public Movie()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="title">Название фильма, должно быть строкой.</param>
        /// <param name="durationInMinutes">Длительность фильма в минутах, должно быть целочисленным значением.</param>
        /// <param name="releaseYear">Год выпуска, должен быть целочисленным значением.</param>
        /// <param name="genre">Жанр фильма, должен быть строкой.</param>
        /// <param name="rating">Оценка фильма, должна быть числом.</param>
        public Movie(string title, int durationInMinutes, int releaseYear, string genre, double rating)
        {
            Title = title;
            DurationInMinutes = durationInMinutes;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }

        /// <summary>
        /// Возвращает и задает длительность фильма в минутах.
        /// Задает через проверку при помощи класса <see cref="Validator"/>. Длительность должна быть положительным числом.
        /// </summary>
        public int DurationInMinutes
        {
            get { return _durationInMinutes; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(DurationInMinutes));
                _durationInMinutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задает год выпуска фильма.
        /// Задает через проверку при помощи класса <see cref="Validator"/>. Год выпуска должен быть между 1900 и текущим.
        /// </summary>
        public int ReleaseYear
        {
            get { return _releaseYear; }
            set
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(ReleaseYear));
                _releaseYear = value;
            }
        }

        /// <summary>
        /// Возвращает и задает название фильма.
        /// Задает через проверку при помощи <see cref="string.IsNullOrEmpty(string?)"/>. То есть строка не должна быть пустой.
        /// </summary>
        public string Title
        {
            get { return _title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Название не должно быть пустым");
                }
                _title = value;
            }
        }

        /// <summary>
        /// Возвращает и задает жанр фильма.
        /// Задает через проверку при помощи <see cref="string.IsNullOrEmpty(string?)"/>. То есть строка не должна быть пустой.
        /// </summary>
        public string Genre
        {
            get { return _genre; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Жанр не может быть пустым");
                }
                _genre = value;
            }

        }

        /// <summary>
        /// Возвращает и задает оценку фильма.
        /// Задает через проверку при помощи класса <see cref="Validator"/>. Оценка должна быть между 0 и 10.
        /// </summary>
        public double Rating
        {
            get { return _rating; }
            set
            {
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
            }
        }
    }
}
