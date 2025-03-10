using System.ComponentModel;
using View.Model.Services;
using View.Model;
using System.Windows.Input;

namespace View.ViewModel
{
    /// <summary>
    /// Класс типа ViewModel для управления контактами.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Событие, возникающее при изменении значения свойства.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Сериализатор контактных данных.
        /// </summary>
        private readonly ContactSerializer _contactSerializer;

        /// <summary>
        /// Контактные данные.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Получает или задает имя контакта.
        /// </summary>
        public string Name
        {
            get
            {
                return _contact.Name;
            }
            set
            {
                if (_contact.Name != value)
                {
                    _contact.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        /// <summary>
        /// Получает или задает номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _contact.Number;
            }
            set
            {
                if (_contact.Number != value)
                {
                    _contact.Number = value;
                    OnPropertyChanged(nameof(PhoneNumber));
                }
            }
        }

        /// <summary>
        /// Получает или задает электронную почту контакта.
        /// </summary>
        public string Email
        {
            get
            {
                return _contact.Email;
            }
            set
            {
                if (_contact.Email != value)
                {
                    _contact.Email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        /// <summary>
        /// Команда для сохранения контакта.
        /// </summary>
        public ICommand SaveCommand { get; }

        /// <summary>
        /// Команда для загрузки контакта.
        /// </summary>
        public ICommand LoadCommand { get; }

        /// <summary>
        /// Обновляет данные контакта.
        /// </summary>
        /// <param name="contact">Контакт, данные которого необходимо обновить.</param>
        private void UpdateContact(Contact contact)
        {
            Name = contact.Name;
            PhoneNumber = contact.Number;
            Email = contact.Email;
        }

        /// <summary>
        /// Вызывает событие <see cref="PropertyChanged"/> для указанного свойства.
        /// </summary>
        /// <param name="propertyName">Имя свойства, которое изменилось. Если не указано, используется имя вызывающего метода.</param>
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Создает новый экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            _contact = new Contact();
            _contactSerializer = new ContactSerializer();

            SaveCommand = new SaveCommand(_contact, _contactSerializer);
            LoadCommand = new LoadCommand(_contactSerializer, UpdateContact);
        }
    }
}
