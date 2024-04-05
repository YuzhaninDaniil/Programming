namespace Programming
{
    public class Song
    {
        private int _duration;

        // Автосвойства
        public string Title { get; set; }
        public string Artist { get; set; }

        // Конструктор с параметрами
        public Song(string title, string artist, int duration)
        {
            this.Title = title;
            this.Artist = artist;
            this.Duration = duration;
        }
        // Конструктор без параметров
        public Song()
        {
        }

        public int Duration
        {
            get { return _duration; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("продолжительность должна быть больше 0");
                }
                _duration = value;
            }
        }
    }
}
