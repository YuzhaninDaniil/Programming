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
                Validator.AssertOnPositiveValue(value, nameof(NumOfStudents));
                _numOfStudents = value;
            }
        }

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
