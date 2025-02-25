using System.Windows.Input;
using View.Model.Servicies;
using View.Model;
using System.Windows;

namespace View.ViewModel
{
    /// <summary>
    /// Класс, отвечающий за сохранение контактных данных.
    /// </summary>
    public class SaveCommand : ICommand
    {
        /// <summary>
        /// Событие, возникающее при изменении возможности выполнения команды.
        /// </summary>
        public event EventHandler? CanExecuteChanged;

        /// <summary>
        /// Сериализатор контактных данных.
        /// </summary>
        private ContactSerializer _contactSerializer;

        /// <summary>
        /// Контактные данные.
        /// </summary>
        private Contact _contact;

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
        /// Выполняет сохранение контакта.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        public void Execute(object? parameter)
        {
            _contactSerializer.SaveContact(_contact);
        }

        /// <summary>
        /// Создает новый экземпляр класса <see cref="SaveCommand"/>.
        /// </summary>
        /// <param name="contact">Контакт, который необходимо сохранить.</param>
        /// <param name="contactSerializer">Сериализатор контактов.</param>
        public SaveCommand(Contact contact, ContactSerializer contactSerializer)
        {
            _contact = contact;
            _contactSerializer = contactSerializer;
        }
    }
}
