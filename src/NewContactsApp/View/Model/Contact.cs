using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace View.Model
{
    /// <summary>
    /// Класс, представляющий контактную информацию.
    /// Реализует интерфейс INotifyPropertyChanged для уведомления об изменении свойств и IDataErrorInfo для уведомлениях об ошибках.
    /// </summary>
    public class Contact : INotifyPropertyChanged, IDataErrorInfo
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Номер телефона.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Электронная почта.
        /// </summary>
        private string _email;

        [StringLength(100)]
        /// <summary>
        /// Получает или задает имя контакта.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
      
        [RegularExpression(@"^\+[0-9]\s?\(?\d{3}\)?\s?\d{3}[-\s]?\d{2}[-\s]?\d{2}$")]
        [StringLength(100)]
        /// <summary>
        /// Получает или задает номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$")]
        [StringLength(100)]
        /// <summary>
        /// Получает или задает почту контакта.
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        /// <summary>
        /// Конструктор класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="email">Почта.</param>
        /// <param name="phoneNumber">Номер телефона.</param>
        public Contact(string name = "", string email = "", string phoneNumber = "")
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Возвращает сообщение об ошибке для всего объекта.
        /// </summary>
        public string Error
        {
            get { return null; }
        }

        /// <summary>
        /// Возвращает наличие ошибки или предупреждения.
        /// </summary>
        public bool HasErrorOrWarning
        {
            get
            {
                return string.IsNullOrEmpty(this[nameof(this.Name)]) &&
                   string.IsNullOrEmpty(this[nameof(this.PhoneNumber)]) &&
                   string.IsNullOrEmpty(this[nameof(this.Email)]);
            }
        }

        /// <summary>
        /// Возвращает сообщение об ошибке для указанного свойства, вызывая соответствующий метод проверки.
        /// </summary>
        /// <param name="propertyName">Имя свойства, для которого нужно получить сообщение об ошибке.</param>
        /// <returns>Сообщение об ошибке, если свойство недействительно, иначе <c>null</c>.</returns>
        public string this[string propertyName]
        {
            get
            {
                switch (propertyName)
                {
                    case nameof(Name):
                        return ValidateName();
                    case nameof(PhoneNumber):
                        return ValidatePhoneNumber();
                    case nameof(Email):
                        return ValidateEmail();
                    default:
                        return null;
                }
            }
        }

        /// <summary>
        /// Проверяет корректность значения свойства Name.
        /// </summary>
        /// <returns>Сообщение об ошибке, если значение недействительно, иначе <c>null</c>.</returns>
        private string ValidateName()
        {
            if (string.IsNullOrEmpty(Name))
                return "Имя не должно быть пустым.";
            if (Name.Length > 100)
                return "Имя должно быть не длиннее 100 символов.";
            return null;
        }

        /// <summary>
        /// Проверяет корректность значения свойства PhoneNumber.
        /// </summary>
        /// <returns>Сообщение об ошибке, если значение недействительно, иначе <c>null</c>.</returns>
        private string ValidatePhoneNumber()
        {
            if (string.IsNullOrEmpty(PhoneNumber))
                return "Номер телефона не должен быть пустым.";
            if (PhoneNumber.Length > 100)
                return "Номер телефона должен быть не длиннее 100 символов.";
            if (!System.Text.RegularExpressions.Regex.IsMatch(PhoneNumber, @"^\+[0-9]\s?\(?\d{3}\)?\s?\d{3}[-\s]?\d{2}[-\s]?\d{2}$"))
                return "Номер телефона может содержать только цифры или символы +-().";
            return null;
        }

        /// <summary>
        /// Проверяет корректность значения свойства Email.
        /// </summary>
        /// <returns>Сообщение об ошибке, если значение недействительно, иначе <c>null</c>.</returns>
        private string ValidateEmail()
        {
            if (string.IsNullOrEmpty(Email))
                return "Адрес почты не должен быть пустым.";
            if (Email.Length > 100)
                return "Адрес почты должен быть не длиннее 100 символов..";
            if (!System.Text.RegularExpressions.Regex.IsMatch(Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return "Неправильный формат адреса почты.";
            return null;
        }

        ///<inheritdoc/>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Вызывает событие <see cref="PropertyChanged"/> для уведомления об изменении свойства.
        /// </summary>
        /// <param name="propertyName">Имя изменённого свойства.</param>
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
