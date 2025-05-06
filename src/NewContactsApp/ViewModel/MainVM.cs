using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Model.Services;
using Model;
using System.ComponentModel;

namespace ViewModel
{
    /// <summary>
    /// ViewModel для главного окна приложения.
    /// </summary>
    public partial class MainVM : ObservableObject
    {
        /// <summary>
        /// Коллекция контактов.
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<Contact> _contacts;

        /// <summary>
        /// Выбранный контакт из списка.
        /// </summary>
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(EditContactCommand))]
        [NotifyCanExecuteChangedFor(nameof(RemoveContactCommand))]
        [NotifyCanExecuteChangedFor(nameof(ApplyContactCommand))]
        private Contact _selectedContact;

        /// <summary>
        /// Флаг, указывающий, находится ли приложение в режиме редактирования.
        /// </summary>
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(EditContactCommand))]
        [NotifyCanExecuteChangedFor(nameof(RemoveContactCommand))]
        [NotifyCanExecuteChangedFor(nameof(ApplyContactCommand))]
        [NotifyPropertyChangedFor(nameof(IsReadOnly))]
        private bool _isEditMode = false;

        /// <summary>
        /// Флаг, указывающий, был ли создан новый контакт.
        /// </summary>
        private bool _isNewContact = false;

        /// <summary>
        /// Индекс выбранного контакта.
        /// </summary>
        private int _selectedIndex;

        /// <summary>
        /// Получает значение, указывающее, находится ли приложение в режиме только для чтения.
        /// </summary>
        public bool IsReadOnly => !IsEditMode;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="MainVM"/>.
        /// Загружает контакты из файла и инициализирует команды.
        /// </summary>
        public MainVM()
        {
            Contacts = new ObservableCollection<Contact>(ContactSerializer.LoadContacts());
        }

        /// <summary>
        /// Обработчик команды AddCommand.
        /// Создаёт новый контакт и подготавливает ViewModel к редактированию.
        /// </summary>
        /// <param name="parameter">Параметр команды (не используется).</param>
        [RelayCommand]
        private void AddContact(object parameter)
        {
            SelectedContact = null;
            var newContact = new Contact();
            SelectedContact = newContact;
            _isNewContact = true;
            IsEditMode = true;
            SelectedContact.PropertyChanged += SelectedContactChanged;
        }

        /// <summary>
        /// Обработчик команды EditCommand.
        /// Переводит приложение в режим редактирования выбранного контакта.
        /// </summary>
        /// <param name="parameter">Параметр команды (не используется).</param>
        [RelayCommand(CanExecute = nameof(CanEditOrRemoveContact))]
        public void EditContact(object parameter)
        {
            if (IsEditMode)
            {
                IsEditMode = false;
                return;
            }

            var clonedContact = new Contact()
            {
                Email = SelectedContact.Email,
                PhoneNumber = SelectedContact.PhoneNumber,
                Name = SelectedContact.Name
            };
            _selectedIndex = Contacts.IndexOf(SelectedContact);
            var newIndex = _selectedIndex;
            SelectedContact = clonedContact;
            SelectedContact.PropertyChanged += SelectedContactChanged;
            IsEditMode = true;
            _selectedIndex = newIndex;
        }

        /// <summary>
        /// Обработчик события изменения свойств выбранного контакта.
        /// Вызывает обновление доступности команд.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Содержит данные об изменении свойства.</param>
        private void SelectedContactChanged(object? sender, PropertyChangedEventArgs e)
        {
            ApplyContactCommand.NotifyCanExecuteChanged();
        }

        /// <summary>
        /// Обработчик команды RemoveCommand.
        /// Удаляет выбранный контакт из коллекции.
        /// </summary>
        /// <param name="parameter">Параметр команды (не используется).</param>
        [RelayCommand(CanExecute = nameof(CanEditOrRemoveContact))]
        private void RemoveContact(object parameter)
        {
            if (SelectedContact != null)
            {
                _selectedIndex = Contacts.IndexOf(SelectedContact);
                Contacts.Remove(SelectedContact);

                if (Contacts.Count > 0)
                {
                    if (_selectedIndex < Contacts.Count)
                    {
                        if (_selectedIndex > -1)
                        {
                            SelectedContact = Contacts[_selectedIndex];
                        }
                    }
                    else
                    {
                        SelectedContact = Contacts[Contacts.Count - 1];
                    }
                }
                else
                {
                    SelectedContact = null;
                }

                IsEditMode = false;
                SaveContacts();
            }
        }

        /// <summary>
        /// Обработчик команды ApplyCommand.
        /// Применяет изменения к контакту и сохраняет их в файл.
        /// </summary>
        /// <param name="parameter">Параметр команды (не используется).</param>
        [RelayCommand(CanExecute = nameof(CanApplyContact))]
        private void ApplyContact(object parameter)
        {
            SelectedContact.PropertyChanged -= SelectedContactChanged;
            if (_isNewContact)
            {
                Contacts.Add(SelectedContact);
            }
            else
            {
                Contacts[_selectedIndex] = SelectedContact;
                _selectedIndex = -1;
            }

            IsEditMode = false;
            _isNewContact = false;
            SaveContacts();
        }

        /// <summary>
        /// Определяет, может ли быть выполнена команда EditCommand или RemoveCommand.
        /// </summary>
        /// <param name="parameter">Параметр команды (не используется).</param>
        /// <returns><c>true</c>, если команда может быть выполнена, иначе <c>false</c>.</returns>
        private bool CanEditOrRemoveContact(object parameter)
        {
            return SelectedContact != null && !IsEditMode;
        }

        /// <summary>
        /// Определяет, может ли быть выполнена команда ApplyCommand.
        /// </summary>
        /// <param name="parameter">Параметр команды (не используется).</param>
        /// <returns><c>true</c>, если команда может быть выполнена, иначе <c>false</c>.</returns>
        private bool CanApplyContact(object parameter)
        {
            return SelectedContact != null && IsEditMode && !SelectedContact.HasErrors;
        }

        /// <summary>
        /// Сохраняет коллекцию контактов в файл.
        /// </summary>
        private void SaveContacts()
        {
            ContactSerializer.SaveContacts(Contacts);
        }

        /// <summary>
        /// Обрабатывает изменение выбранного контакта перед его сменой.
        /// </summary>
        /// <param name="previousValue">Предыдущее значение выбранного контакта.</param>
        /// <param name="newValue">Новое значение выбранного контакта.</param>
        partial void OnSelectedContactChanging(Contact previousValue, Contact newValue)
        {
            if (previousValue != null)
            {
                previousValue.PropertyChanged -= SelectedContactChanged;
            }

            IsEditMode = false;
        }

        /// <summary>
        /// Обрабатывает изменение выбранного контакта после его смены.
        /// Уведомляет о возможности выполнения команд.
        /// </summary>
        /// <param name="value">Новое значение выбранного контакта.</param>
        partial void OnSelectedContactChanged(Contact value)
        {
            EditContactCommand.NotifyCanExecuteChanged();
            RemoveContactCommand.NotifyCanExecuteChanged();
            ApplyContactCommand.NotifyCanExecuteChanged();
        }
    }
}
