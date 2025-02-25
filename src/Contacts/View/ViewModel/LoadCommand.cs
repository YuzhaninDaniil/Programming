using System.Windows.Input;
using View.Model.Servicies;
using View.Model;
using System.Windows;

namespace View.ViewModel
{
    /// <summary>
    /// Класс, отвечающий за загрузку контактных данных.
    /// </summary>
    public class LoadCommand : ICommand
    {
        /// <summary>
        /// Событие, которое возникает при изменении возможности выполнения команды.
        /// </summary>
        public event EventHandler? CanExecuteChanged;

        /// <summary>
        /// Сериализатор контактных данных.
        /// </summary>
        private ContactSerializer _contactSerializer;

        /// <summary>
        /// Делегат.
        /// </summary>
        private Action<Contact> _updateContact;

        /// <summary>
        /// Возвращает, может ли команда выполняться.
        /// </summary>
        /// <param name="parameter">Входные параметры.</param>
        /// <returns>Всегда возвращает true.</returns>
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        /// <summary>
        /// Выполняет загрузку данных контакта из файла.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        public void Execute(object? parameter)
        {
            Contact loadedContact = _contactSerializer.LoadContact();
            if (loadedContact != null)
            {
                _updateContact(loadedContact);
            }
            else
            {
                MessageBox.Show("Не удалось загрузить данные.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Создает новый экземпляр класса <see cref="LoadCommand"/>.
        /// </summary>
        /// <param name="contactSerializer">Сериализатор контактов.</param>
        /// <param name="updateContact">Метод для обновления данных контакта.</param>
        public LoadCommand(ContactSerializer contactSerializer, Action<Contact> updateContact)
        {
            _contactSerializer = contactSerializer;
            _updateContact = updateContact;
        }
    }
}
