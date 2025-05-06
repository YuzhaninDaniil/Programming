using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Text.RegularExpressions;

namespace Model
{
    /// <summary>
    /// Представляет контакт с именем, номером телефона и электронной почтой.
    /// Реализует валидацию с помощью интерфейса <see cref="IDataErrorInfo"/>.
    /// </summary>
    public partial class Contact : ObservableObject, IDataErrorInfo
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        [ObservableProperty]
        private string _name;

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        [ObservableProperty]
        private string _phoneNumber;

        /// <summary>
        /// Электронная почта контакта.
        /// </summary>
        [ObservableProperty]
        private string _email;

        /// <summary>
        /// Возвращает значение, указывающее, содержит ли контакт ошибки валидации.
        /// </summary>
        public bool HasErrors =>
            !string.IsNullOrEmpty(this[nameof(Name)]) ||
            !string.IsNullOrEmpty(this[nameof(PhoneNumber)]) ||
            !string.IsNullOrEmpty(this[nameof(Email)]);

        /// <summary>
        /// Возвращает сообщение об ошибке для всего объекта.
        /// </summary>
        public string Error
        {
            get { return null; }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact() { }

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
    }
}
