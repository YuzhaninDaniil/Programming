using System.ComponentModel;
using System.Runtime.CompilerServices;
using View.Model;
using View.Model.Servicies;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Windows;

namespace View.ViewModel
{
    /// <summary>
    /// Основная ViewModel для управления контактами, включая добавление, редактирование, удаление 
    /// и сохранение данных контактов.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        #region События

        /// <summary>
        /// Событие, которое вызывается при изменении значения свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Поля

        private readonly ContactSerializer _contactSerializer;
        private ObservableCollection<Contact> _contacts;
        private Contact _selectedContact;
        private Contact _clonedContact;
        private Visibility _applyButtonVisibility = Visibility.Collapsed;

        private bool _isContactReadOnly = true;
        private bool _isDataChanged;
        private bool _isAddingNewContact;
        private bool _isEditingContact;

        private int _indexBeforeEditing;

        #endregion

        #region Свойства

        /// <summary>
        /// Коллекция контактов, которые управляются в приложении.
        /// </summary>
        public ObservableCollection<Contact> Contacts
        {
            get => _contacts;
            set
            {
                _contacts = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Проверяет, выбран ли контакт.
        /// </summary>
        public bool IsContactSelected => SelectedContact != null;

        /// <summary>
        /// Выбранный контакт.
        /// </summary>
        public Contact SelectedContact
        {
            get => _selectedContact;
            set
            {
                if (_selectedContact != value)
                {
                    if (_isAddingNewContact && _selectedContact != null && !Contacts.Contains(_selectedContact))
                    {
                        _selectedContact = null;
                        _isAddingNewContact = false;
                    }

                    _selectedContact = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(IsContactSelected));
                    OnPropertyChanged(nameof(ApplyButtonVisibility));

                    if (_selectedContact != null)
                    {
                        IsContactReadOnly = true;
                    }
                }
            }
        }

        /// <summary>
        /// Видимость кнопки "Применить", которая зависит от того, были ли изменения в данных.
        /// </summary>
        public Visibility ApplyButtonVisibility
        {
            get { return _applyButtonVisibility; }
            set
            {
                if (_applyButtonVisibility != value)
                {
                    _applyButtonVisibility = value;
                    OnPropertyChanged(nameof(ApplyButtonVisibility));
                }
            }
        }

        /// <summary>
        /// Флаг, показывающий, был ли активирован или нет режим создания нового пользовтеля
        /// </summary>
        public bool IsAddingNewContact
        {
            get => _isAddingNewContact;
            set
            {
                if (_isAddingNewContact != value)
                {
                    _isAddingNewContact = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Флаг, показывающий, были ли изменения в данных, которые требуют сохранения.
        /// </summary>
        public bool IsDataChanged
        {
            get => _isDataChanged;
            set
            {
                if (_isDataChanged != value)
                {
                    _isDataChanged = value;
                    OnPropertyChanged(nameof(IsDataChanged));
                    ApplyButtonVisibility = _isDataChanged ? Visibility.Visible : Visibility.Collapsed;
                }
            }
        }

        /// <summary>
        /// Устанавливает режим "только для чтения" для редактирования контакта.
        /// </summary>
        public bool IsContactReadOnly
        {
            get => _isContactReadOnly;
            set
            {
                if (_isContactReadOnly != value)
                {
                    _isContactReadOnly = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Команда для добавления нового контакта.
        /// </summary>
        public ICommand AddCommand { get; }

        /// <summary>
        /// Команда для редактирования выбранного контакта.
        /// </summary>
        public ICommand EditCommand { get; }

        /// <summary>
        /// Команда для удаления выбранного контакта.
        /// </summary>
        public ICommand RemoveCommand { get; }

        /// <summary>
        /// Команда для применения изменений контакта.
        /// </summary>
        public ICommand ApplyCommand { get; }

        #endregion

        #region Методы

        /// <summary>
        /// Вызывает событие <see cref="PropertyChanged"/> для указанного свойства.
        /// </summary>
        /// <param name="propertyName">Имя свойства, которое изменилось.</param>
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Обновляет контакт, устанавливая флаг изменений данных и разрешая редактирование.
        /// </summary>
        private void UpdateContact(Contact contact)
        {
            IsDataChanged = true;
            IsContactReadOnly = false;
        }

        /// <summary>
        /// Добавляет новый контакт в коллекцию.
        /// </summary>
        private void AddContact(object parameter)
        {
            IsContactReadOnly = false;
            IsAddingNewContact = true;
            var newContact = new Contact();
            SelectedContact = newContact;
            UpdateContact(newContact);
        }

        /// <summary>
        /// Разрешает редактирование выбранного контакта.
        /// </summary>
        private void EditContact(object parameter)
        {
            if (SelectedContact != null)
            {
                IsContactReadOnly = false;
                _isEditingContact = true;
                _indexBeforeEditing = Contacts.IndexOf(SelectedContact);

                _clonedContact = new Contact
                {
                    Name = SelectedContact.Name,
                    Number = SelectedContact.Number,
                    Email = SelectedContact.Email
                };

                SelectedContact = _clonedContact;

                UpdateContact(_clonedContact);
            }
        }

        /// <summary>
        /// Удаляет выбранный контакт из коллекции.
        /// </summary>
        private void RemoveContact(object parameter)
        {
            if (SelectedContact != null)
            {
                int selectedIndex = Contacts.IndexOf(SelectedContact);
                Contacts.Remove(SelectedContact);
                _contactSerializer.SaveContacts(Contacts);

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
            }
        }

        /// <summary>
        /// Применяет изменения и сохраняет обновленные контакты.
        /// </summary>
        private void ApplyChanges(object parameter)
        {
            if (SelectedContact != null)
            {
                if (_isAddingNewContact)
                {
                    Contacts.Add(SelectedContact);
                    IsAddingNewContact = false;
                }
                    
                if (_isEditingContact)
                {
                    Contacts[_indexBeforeEditing] = SelectedContact;

                    _isEditingContact = false;
                }

                _contactSerializer.SaveContacts(Contacts);
                IsDataChanged = false;
                IsContactReadOnly = true;
            }
        }

        /// <summary>
        /// Снимает выделение с контакта.
        /// </summary>
        public void DeselectContact()
        {
            SelectedContact = null;
        }

        /// <summary>
        /// Проверяет, можно ли редактировать или удалить контакт.
        /// </summary>
        private bool CanEditOrRemoveContact(object parameter)
        {
            return SelectedContact != null && Contacts.Count > 0;
        }

        #endregion

        #region Конструкторы

        /// <summary>
        /// Инициализирует ViewModel и загружает контакты с помощью сериализатора.
        /// </summary>
        public MainVM()
        {
            _contactSerializer = new ContactSerializer();
            Contacts = new ObservableCollection<Contact>(_contactSerializer.LoadContacts());

            AddCommand = new RelayCommand(AddContact);
            EditCommand = new RelayCommand(EditContact, CanEditOrRemoveContact);
            RemoveCommand = new RelayCommand(RemoveContact, CanEditOrRemoveContact);
            ApplyCommand = new RelayCommand(ApplyChanges);
        }

        #endregion
    }
}
