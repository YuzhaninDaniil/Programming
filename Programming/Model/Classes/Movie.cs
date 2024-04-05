namespace Programming
{
    public class Movie
    {
        private int _durationInMinutes;
        private int _releaseYear;
        private double _rating;
        private string _title;
        private string _genre;

        public Movie()
        {
        }

        public Movie(string title, int durationInMinutes, int releaseYear, string genre, double rating)
        {
            Title = title;
            DurationInMinutes = durationInMinutes;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }

        public int DurationInMinutes
        {
            get { return _durationInMinutes; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Продолжительность фильма не может быть отрицательной.");
                }
                _durationInMinutes = value;
            }
        }

        public int ReleaseYear
        {
            get { return _releaseYear; }
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Год выпуска фильма должен быть в диапазоне от 1900 до текущего года.");
                }
                _releaseYear = value;
            }
        }

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

        public double Rating
        {
            get { return _rating; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Рейтинг фильма должен быть в диапазоне от 0 до 10.");
                }
                _rating = value;
            }
        }
    }
}
