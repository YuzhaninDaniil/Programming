namespace Programming
{
    /// <summary>
    /// Хранит данные о контактах человека.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Хранит набор букв латинского алфавита.
        /// </summary>
        private const string _symbols = "abcdefghijklmnopqrstuvwxyz ";

        /// <summary>
        /// Хранит email человека.
        /// </summary>
        private string _email;

        /// <summary>
        /// Хранит имя человека.
        /// </summary>
        private string _name;

        /// <summary>
        /// Хранит фамилию человека.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя человека, должно содержать только строку.</param>
        /// <param name="phoneNumber">Номер телефона человека, должен содержать строку.</param>
        /// <param name="email">Email человек, должен содержать строку.</param>
        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {

        }

        /// <summary>
        /// Проверяет строку на наличие символов латинского алфавита. В случае другого символа выбрасывает исключение.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="propertyName"></param>
        /// <exception cref="ArgumentException"></exception>
        private void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            value = value.ToLower();
            foreach (char c in value)
            {
                if (!_symbols.Contains(c))
                {
                    throw new ArgumentException($"Поле {propertyName} должно содержать толко латиницу");
                }
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона человека.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Возвращает и задает имя человека.
        /// Задает через проверку при помощи  <see cref="AssertStringContainsOnlyLetters"/>. Имя должно содержать символы латиницы.
        /// </summary>
        public string Name
        {
            get { return _name; }

            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Name));
                _name = value;
            }

        }

        /// <summary>
        /// Возвращает и задает фамилию человека.
        /// Задает через проверку при помощи  <see cref="AssertStringContainsOnlyLetters"/>. Фамилия должна содержать символы латиницы.
        /// </summary>
        public string Surname
        {
            get { return _surname; }
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Surname));
                _surname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает email человека. Если в строке нет символа "@", выбрасывает исключение.
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                if (!value.Contains("@"))
                {
                    throw new ArgumentException("Неправильный формат email");
                }
                _email = value;
            }
        }
    }
}
