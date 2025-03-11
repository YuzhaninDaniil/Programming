namespace View.Model
{
    /// <summary>
    /// Класс, хранящий контактные данные о человеке.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает номер телефона контакта.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Возвращает и задает электронную почту контакта.
        /// </summary>
        public string Email { get; set; }

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
            Name = "Surname Name";
            Number = "+X-XXX-XXX-XX-XX";
            Email = "qwerty@mail.ru";
        }
    }
}
