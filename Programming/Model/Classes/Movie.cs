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
                Validator.AssertOnPositiveValue(value, nameof(DurationInMinutes));
                _durationInMinutes = value;
            }
        }

        public int ReleaseYear
        {
            get { return _releaseYear; }
            set
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(ReleaseYear));
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
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
            }
        }
    }
}
