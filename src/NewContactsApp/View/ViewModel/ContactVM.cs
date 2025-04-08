using System.ComponentModel;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для представления контакта в UI. Служит оберткой для объекта Contact.
    /// </summary>
    public class ContactVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="contact">Объект <see cref="Contact"/>, который нужно обернуть.</param>
        public ContactVM(Contact contact)
        {
            Contact = contact;
        }

        /// <summary>
        /// Получает объект <see cref="Contact"/>, который представляет контактные данные.
        /// </summary>
        public Contact Contact { get; private set; }

        /// <summary>
        /// Получает или задаёт имя контакта.
        /// </summary>
        public string Name
        {
            get
            {
                return Contact.Name;
            }
            set
            {
                Contact.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// Получает или задаёт номер телефона контакта.
        /// </summary>
        public string Number
        {
            get
            {
                return Contact.Number;
            }
            set
            {
                Contact.Number = value;
                OnPropertyChanged(nameof(Number));
            }
        }

        /// <summary>
        /// Получает или задаёт адрес электронной почты контакта.
        /// </summary>
        public string Email
        {
            get
            {
                return Contact.Email;
            }
            set
            {
                Contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        /// <summary>
        /// Возникает при изменении значения свойства.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Вызывает событие <see cref="PropertyChanged"/>
        /// для уведомления об изменении свойства.
        /// </summary>
        /// <param name="propertyName">Имя изменённого свойства.</param>
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}