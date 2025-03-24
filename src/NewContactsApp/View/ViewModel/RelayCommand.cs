using System;
using System.Windows.Input;

namespace View.ViewModel
{
    /// <summary>
    /// Реализация команды с делегированием действия.
    /// </summary>
    public class RelayCommand : ICommand
    {
        #region Поля

        private readonly Action<object> _execute;
        private readonly Predicate<object> _canExecute;

        #endregion

        #region Конструкторы

        /// <summary>
        /// Инициализирует новый экземпляр команды с делегированием действий.
        /// </summary>
        /// <param name="execute">Действие, которое выполняет команда.</param>
        /// <param name="canExecute">Предикат, определяющий, можно ли выполнить команду.</param>
        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        #endregion

        #region Методы

        /// <summary>
        /// Событие, которое вызывается при изменении состояния команды.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value; 
        }

        /// <summary>
        /// Определяет, может ли команда быть выполнена в текущий момент.
        /// </summary>
        /// <param name="parameter">Параметр, передаваемый в команду.</param>
        /// <returns>Возвращает true, если команда может быть выполнена, иначе false.</returns>
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        /// <summary>
        /// Выполняет команду.
        /// </summary>
        /// <param name="parameter">Параметр, передаваемый в команду.</param>
        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        #endregion
    }
}
