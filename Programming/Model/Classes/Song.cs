namespace Programming
{
    /// <summary>
    /// Хранит информацию о песне.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Хранит данные о длительности.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Возвращает и задает название песни.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает и задает имя артиста.
        /// </summary>
        public string Artist { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="title">Название песни, должно быть строкой.</param>
        /// <param name="artist">Имя артиста, должно быть строкой.</param>
        /// <param name="duration">Длительность песни, должно быть целочисленным значением.</param>
        public Song(string title, string artist, int duration)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Song"/>.
        /// </summary>
        public Song()
        {

        }

        /// <summary>
        /// Возвращает и задает длительность песни.
        /// Задает через проверку при помощи класса <see cref="Validator"/>. Длительность должна быть положительным числом.
        /// </summary>
        public int Duration
        {
            get { return _duration; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Duration));
                _duration = value;
            }
        }
    }
}
