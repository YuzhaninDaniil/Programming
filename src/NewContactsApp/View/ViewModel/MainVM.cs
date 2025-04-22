using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Основной класс ViewModel (MainVM) для управления контактами.
    /// Реализует интерфейс INotifyPropertyChanged для обновления данных в UI.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Коллекция контактов.
        /// </summary>
        private ObservableCollection<Contact> _contacts;

        /// <summary>
        /// Выбранный контакт из списка.
        /// </summary>
        private Contact _currentContact;

        /// <summary>
        /// Флаг, указывающий, редактируемо ли приложение.
        /// </summary>
        private bool _isEditMode = false;

        /// <summary>
        /// Флаг, указывающий, создан ли  новый контакт.
        /// </summary>
        private bool _isNewContact = false;

        /// <summary>
        /// Индекс выбранного контакта.
        /// </summary>
        private int _currentContactIndex;

        /// <summary>
        /// Экземпляр текущего контакта.
        /// </summary>
        public Contact CurrentContact
        {
            get { return _currentContact; }
            set
            {
                if (_currentContact != value)
                {
                    if (_currentContact != null && value != _currentContact)
                    {
                        IsEditMode = false;
                    }
                    _currentContact = value;
                    OnPropertyChanged(nameof(CurrentContact));
                }
            }
        }

        /// <summary>
        /// Получает или задаёт коллекцию Contact для отображения в списке контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts
        {
            get
            {
                return _contacts;
            }
            set
            {
                _contacts = value;
                OnPropertyChanged(nameof(Contacts));
            }
        }

        /// <summary>
        /// Определяет включен ли режим редактирования.
        /// </summary>
        public bool IsEditMode
        {
            get { return _isEditMode; }
            set
            {
                if (_isEditMode != value)
                {
                    _isEditMode = value;
                    OnPropertyChanged(nameof(IsEditMode));
                }
            }
        }

        /// <summary>
        /// Команда добавления контакта.
        /// </summary>
        public ICommand AddCommand { get; }

        /// <summary>
        /// Команда удаления контакта.
        /// </summary>
        public ICommand RemoveCommand { get; }

        /// <summary>
        /// Команда редактирования контакта.
        /// </summary>
        public ICommand EditCommand { get; }

        /// <summary>
        /// Команда применения изменений.
        /// </summary>
        public ICommand ApplyCommand { get; }

        /// <summary>
        /// Конструктор MainVM.
        /// Загружает контакты.
        /// </summary>
        public MainVM()
        {
            Contacts = ContactSerializer.LoadContacts();
            AddCommand = new RelayCommand(AddContact);
            EditCommand = new RelayCommand(EditContact, CanEditOrRemoveContact);
            RemoveCommand = new RelayCommand(RemoveContact, CanEditOrRemoveContact);
            ApplyCommand = new RelayCommand(ApplyContact, CanApplyContact);
        }

        /// <summary>
        /// Обработчик команды ApplyCommand. Применяет изменения к контакту и сохраняет их в файл.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        private void ApplyContact(object parameter)
        {
            if (_isNewContact)
            {
                Contacts.Add(CurrentContact);
            }
            else
            {
                Contacts[_currentContactIndex] = CurrentContact;
            }

            IsEditMode = false;
            _isNewContact = false;
            SaveContacts();
        }

        /// <summary>
        /// Определяет, может ли быть выполнена команда ApplyCommand.
        /// </summary>
        /// <param name="parameter">Параметр команды (не используется).</param>
        /// <returns><c>true</c>, если команда может быть выполнена, иначе <c>false</c>.</returns>
        private bool CanApplyContact(object parameter)
        {
            return CurrentContact != null && CurrentContact.HasErrorOrWarning;                  
        }

        /// <summary>
        /// Обработчик команды EditCommand. Переводит приложение в режим редактирования.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        public void EditContact(object parameter)
        {
            Contact clonedContact = new Contact()
            {
                Name = CurrentContact.Name,
                PhoneNumber = CurrentContact.PhoneNumber,
                Email = CurrentContact.Email
            };
            _currentContactIndex = Contacts.IndexOf(CurrentContact);
            CurrentContact = clonedContact;
            IsEditMode = true;
        }

        /// <summary>
        /// Определяет, может ли быть выполнена команда EditCommand или RemoveCommand.
        /// </summary>
        /// <param name="obj">Проверяемый объект.</param>
        /// <returns><c>true</c>, если команда может быть выполнена, иначе <c>false</c>.</returns>
        private bool CanEditOrRemoveContact(object obj)
        {
            if (obj is Contact contact)
            {
                return Contacts.Contains(contact);
            }
            return false;
        }

        /// <summary>
        /// Обработчик команды AddCommand. Создаёт новый контакт и добавляет его в коллекцию.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        private void AddContact(object parameter)
        {
            CurrentContact = null;
            Contact newContact = new Contact();
            CurrentContact = newContact;
            _isNewContact = true;
            IsEditMode = true;
        }

        /// <summary>
        /// Обработчик команды RemoveCommand. Удаляет выбранный контакт из коллекции.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        private void RemoveContact(object parameter)
        {
            if (CurrentContact != null)
            {
                int selectedIndex = Contacts.IndexOf(CurrentContact);
                Contacts.Remove(CurrentContact);

                if (Contacts.Count > 0)
                {
                    if (selectedIndex < Contacts.Count)
                    {
                        CurrentContact = Contacts[selectedIndex];
                    }
                    else
                    {
                        CurrentContact = Contacts[Contacts.Count - 1];
                    }
                }
                else
                {
                    CurrentContact = null;
                }

                SaveContacts();
            }
        }

        /// <summary>
        /// Сохраняет контакты в файл.
        /// </summary>
        private void SaveContacts()
        {
            ContactSerializer.SaveContacts(Contacts);
        }

        /// <summary>
        /// Возникает при изменении значения свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

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
