namespace View.Model
{
    /// <summary>
    /// Класс, хранящий контактные данные о человеке.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        private string _number;

        /// <summary>
        /// Почта контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона контакта.
        /// </summary>
        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }

        /// <summary>
        /// Возвращает и задает электронную почту контакта.
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Contact"/> с указанными именем, номером телефона и электронной почтой.
        /// </summary>
        /// <param name="name">Имя контакта.</param>
        /// <param name="number">Номер телефона контакта.</param>
        /// <param name="email">Электронная почта контакта.</param>
        public Contact(string name, string number, string email)
        {
            Name = name;
            Number = number;
            Email = email;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Contact"/> без параметров.
        /// </summary>
        public Contact()
        {
            Name = "Смирнов Юрий";
            Number = "+7-913-111-22-33";
            Email = "YuriSmirnov@mail.ru";
        }
    }
}
