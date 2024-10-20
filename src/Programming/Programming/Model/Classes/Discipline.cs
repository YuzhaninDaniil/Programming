namespace Programming
{
    /// <summary>
    /// Хранит данные о предмете.
    /// </summary>
    public class Discipline
    {
        /// <summary>
        /// Хранит данные об имени студента.
        /// </summary>
        private string _name;

        /// <summary>
        /// Хранит данные о количестве студентов.
        /// </summary>
        private int _numOfStudents;

        /// <summary>
        /// Хранит данные о длительность курса.
        /// </summary>
        private int _curriculum;

        /// <summary>
        /// Создает экземпляр класса <see cref="Discipline"/>.
        /// </summary>
        /// <param name="name">Имя студента, должно быть строкой.</param>
        /// <param name="credits">Количество студентов, должно быть целочисленным значением.</param>
        /// <param name="curriculum">Длительность курса, должно быть целочисленным значением.</param>
        public Discipline(string name, int credits, int curriculum)
        {
            Name = name;
            NumOfStudents = credits;
            Сurriculum = curriculum;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Discipline"/>.
        /// </summary>
        public Discipline()
        {

        }

        /// <summary>
        /// Возвращает и задает имя студента.
        /// </summary>
        private string Name { get; set; }

        /// <summary>
        /// Возвращает и задает количество студентов.
        /// Задает через проверку при помощи класса <see cref="Validator"/>. Количество студентов должно быть положительным числом.
        /// </summary>
        public int NumOfStudents
        {
            get { return _numOfStudents; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(NumOfStudents));
                _numOfStudents = value;
            }
        }

        /// <summary>
        /// Возвращает и задает длительность курса.
        /// Задает через проверку при помощи класса <see cref="Validator"/>. Длительность курса должна быть положительным числом.
        /// </summary>
        public int Сurriculum
        {
            get { return _curriculum; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Сurriculum));
                _curriculum = value;
            }
        }
    }
}
