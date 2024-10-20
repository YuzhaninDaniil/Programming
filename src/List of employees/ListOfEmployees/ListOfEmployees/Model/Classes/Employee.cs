namespace ListOfEmployees
{
    /// <summary>
    /// Класс хранит информацию о работнике.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Перечисление, хранящее имя работника.
        /// </summary>
        private Names _name;
        /// <summary>
        /// Перечисление, хранящее фамилию работника.
        /// </summary>
        private Surnames _surname;
        /// <summary>
        /// Перечисление, хранящее отчество работника.
        /// </summary>
        private Patronymics _patronymic;
        /// <summary>
        /// Перечисление, хранящее должность работника.
        /// </summary>
        private Positions _position;
        /// <summary>
        /// Перечисление, хранящее дату назначения работника.
        /// </summary>
        private DateTime _employmentDate;
        /// <summary>
        /// Поле, хранящее зарплату работника.
        /// </summary>
        private double _salary;
        


        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="name">Имя работника</param>
        /// <param name="surname">Фамилия работника</param>
        /// <param name="patronymic">Отчество работника</param>
        /// <param name="position">Должность работника</param>
        /// <param name="employmentDate">Дата трудоустройства</param>
        /// <param name="salary">Зарплата работника</param>
        /// <exception cref="ArgumentException"></exception>
        public Employee(Names name, Surnames surname, Patronymics patronymic, Positions position, DateTime employmentDate, double salary)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Position = position;
            HireDate = employmentDate;
            Salary = salary;

            if (GetFullName().Length > 100)
            {
                throw new ArgumentException("Полное имя сотрудника не может превышать 100 символов.");
            }

        }

        /// <summary>
        /// Перегруженный оператор для создания одной строки.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
           return $"{Surname} {Name} {Patronymic}";
        }
        /// <summary>
        /// Возвращает строку с ФИО.
        /// </summary>
        /// <returns></returns>
        public string GetFullName()
        {
            return $"{_surname} {_name} {_patronymic}";
        }


        /// <summary>
        /// Хранит и возвращает имя работника.
        /// </summary>
        public Names Name
        {
            get { return _name; }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value.ToString(), nameof(Name));
                _name = value; 
            }
        }


        /// <summary>
        /// Хранит и возвращает фамилию работника.
        /// </summary>
        public Surnames Surname
        {
            get { return _surname; }
            set 
            {
                Validator.AssertStringContainsOnlyLetters(value.ToString(), nameof(Surname));
                _surname = value;
            }
        }

        /// <summary>
        /// Хранит и возвращает отчество работника.
        /// </summary>
        public Patronymics Patronymic
        {
            get { return _patronymic; }
            set 
            {
                Validator.AssertStringContainsOnlyLetters(value.ToString(), nameof(Patronymic));
                _patronymic = value; 
            }
        }

        /// <summary>
        /// Проверяет, не более ли 50 символов в строке.
        /// </summary>
        /// <param name="position">Объект типа перечисления.</param>
        /// <returns></returns>
        public bool IsPositionValid(Positions position)
        {
            return position.ToString().Length <= 50;
        }

        /// <summary>
        /// Устанавливает должность работника.
        /// </summary>
        public Positions Position
        {
            get { return _position; }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value.ToString(), nameof(Position));
                if (!IsPositionValid(value))
                {
                    throw new ArgumentException("Должность сотрудника не может превышать 50 символов.");
                }
                _position = value;
            }
        }

        /// <summary>
        /// Устанавливает дату назначения работника.
        /// </summary>
        public DateTime HireDate
        {
            get { return _employmentDate; }
            set
            {
                if (value > DateTime.Today)
                {
                    throw new ArgumentException("Employment date cannot be in the future.");
                }
                Validator.AssertDateTimeInRange(value, new DateTime(2000, 1, 1), DateTime.Today, nameof(HireDate));
                _employmentDate = value;
            }
        }
        

        /// <summary>
        /// Устанавливает зарплату работника.
        /// </summary>
        public double Salary
        {
            get { return _salary; }
            set
            {
                Validator.AssertValueInRange(value, 19242, 500000, nameof(Salary));
                _salary = value;
            }
        }
    }
}
