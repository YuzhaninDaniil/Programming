using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using View.Model;
using View.Model.Servicies;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel для главного окна приложения.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Коллекция контактов.
        /// </summary>
        private ObservableCollection<ContactVM> _contacts;

        /// <summary>
        /// Выбранный контакт из списка.
        /// </summary>
        private ContactVM _selectedContact;

        /// <summary>
        /// Флаг, указывающий, редактируемо ли приложение.
        /// </summary>
        private bool _isEditing = false;

        /// <summary>
        /// Флаг, указывающий, создан ли  новый контакт.
        /// </summary>
        private bool _isNewContact = false;

        /// <summary>
        /// Индекс выбранного контакта.
        /// </summary>
        private int _selectedContactIndex;

        /// <summary>
        /// Объект для сериализации и десериализации контактов.
        /// </summary>
        private ContactSerializer _contactsSerializer = new ContactSerializer();

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="MainVM"/>. Отвечает за сереализацию и десереализацию, вызов команд.
        /// </summary>
        public MainVM()
        {
            List<Contact> loadedContacts = _contactsSerializer.LoadContacts();
            Contacts = new ObservableCollection<ContactVM>(loadedContacts.Select(c => new ContactVM(c)));

            AddCommand = new RelayCommand(AddContact);
            EditCommand = new RelayCommand(EditContact, CanModifyContact);
            RemoveCommand = new RelayCommand(RemoveContact, CanModifyContact);
            ApplyCommand = new RelayCommand(ApplyContact);
        }

        /// <summary>
        /// Получает или задаёт коллекцию ContactVM для отображения в списке контактов.
        /// </summary>
        public ObservableCollection<ContactVM> Contacts
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
        /// Получает или задаёт выбранный контакт из списка.
        /// </summary>
        public ContactVM SelectedContact
        {
            get
            {
                return _selectedContact;
            }
            set
            {
                if (_selectedContact != value)
                {
                    if (SelectedContact is not null && SelectedContact != value)
                    {
                        IsEditing = false;
                    }

                    _selectedContact = value;
                    OnPropertyChanged(nameof(SelectedContact));
                }
            }
        }

        /// <summary>
        /// Получает или задаёт значение, указывающее, находится ли приложение в режиме редактирования.
        /// </summary>
        public bool IsEditing
        {
            get
            {
                return _isEditing;
            }
            set
            {
                _isEditing = value;
                OnPropertyChanged(nameof(IsEditing));
                OnPropertyChanged(nameof(IsReadOnly));
                //OnPropertyChanged(nameof(ApplyButtonVisibility));
            }
        }

        /// <summary>
        /// Получает значение, указывающее, находится ли приложение в режиме только для чтения.
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                return !IsEditing;
            }
        }

        

        /// <summary>
        /// Получает команду для добавления нового контакта.
        /// </summary>
        public ICommand AddCommand { get; }

        /// <summary>
        /// Получает команду для редактирования существующего контакта.
        /// </summary>
        public ICommand EditCommand { get; }

        /// <summary>
        /// Получает команду для удаления контакта.
        /// </summary>
        public ICommand RemoveCommand { get; }

        /// <summary>
        /// Получает команду для применения изменений к контакту.
        /// </summary>
        public ICommand ApplyCommand { get; }

        /// <summary>
        /// Обработчик команды AddCommand. Создаёт новый контакт и добавляет его в коллекцию.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        private void AddContact(object parameter)
        {
            SelectedContact = null;
            Contact newContact = new Contact();
            ContactVM newContactVM = new ContactVM(newContact);
            SelectedContact = newContactVM;
            _isNewContact = true;
            IsEditing = true;
        }

        /// <summary>
        /// Обработчик команды EditCommand. Переводит приложение в режим редактирования.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        public void EditContact(object parameter)
        {
            ContactVM clonedContact = new ContactVM(new Contact())
            {
                Name = SelectedContact.Name,
                Number = SelectedContact.Number,
                Email = SelectedContact.Email
            };
            _selectedContactIndex = Contacts.IndexOf(SelectedContact);
            SelectedContact = clonedContact;
            IsEditing = true;
        }

        /// <summary>
        /// Определяет, может ли быть выполнена команда EditCommand или RemoveCommand.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        /// <returns>true, если команда может быть выполнена, иначе false.</returns>
        private bool CanModifyContact(object parameter)
        {
            return SelectedContact != null;
        }

        /// <summary>
        /// Обработчик команды RemoveCommand. Удаляет выбранный контакт из коллекции.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        private void RemoveContact(object parameter)
        {
            if (SelectedContact != null)
            {
                int selectedIndex = Contacts.IndexOf(SelectedContact);
                Contacts.Remove(SelectedContact);

                if (Contacts.Count > 0)
                {
                    if (selectedIndex < Contacts.Count)
                    {
                        SelectedContact = Contacts[selectedIndex];
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

                _contactsSerializer.SaveContacts(new ObservableCollection<Contact>(Contacts.Select(x => x.Contact)));
            }
        }

        /// <summary>
        /// Обработчик команды ApplyCommand. Применяет изменения к контакту и сохраняет их в файл.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        private void ApplyContact(object parameter)
        {
            if (_isNewContact)
            {
                Contacts.Add(SelectedContact);
            }
            else
            {
                Contacts[_selectedContactIndex] = SelectedContact;
            }

            IsEditing = false;
            _isNewContact = false;
            _contactsSerializer.SaveContacts(new ObservableCollection<Contact>(Contacts.Select(x => x.Contact)));
        }

        /// <summary>
        /// Возникает при изменении значения свойства.
        /// </summary>
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