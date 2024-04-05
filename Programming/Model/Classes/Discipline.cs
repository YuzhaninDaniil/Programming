namespace Programming
{
    public class Discipline
    {
        private string _name;
        private int _numOfStudents;
        private int _curriculum;

        public Discipline(string name, int credits, int curriculum)
        {
            Name = name;
            NumOfStudents = credits;
            Сurriculum = curriculum;
        }

        public Discipline()
        {
        }

        private string Name { get; set; }

        public int NumOfStudents
        {
            get { return _numOfStudents; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Число студентов должно быть больше 0");
                }
                _numOfStudents = value;
            }
        }

        public int Сurriculum
        {
            get { return _curriculum; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Курс должен быть больше 0");
                }
                _curriculum = value;
            }
        }
    }
}
