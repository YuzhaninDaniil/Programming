using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace Model.Services
{
    /// <summary>
    /// Класс, отвечающий за сериализацию и десериализацию объектов типа <see cref="Contact"/>.
    /// </summary>
    public static class ContactSerializer
    {
        /// <summary>
        /// Хранит и возвращает путь к файлу, в котором хранятся данные контакта.
        /// </summary>
        public static string FilePath { get; set; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Contacts", "contacts.json");

        /// <summary>
        /// Метод для создания папки, если она не существует.
        /// </summary>
        public static void EnsureDirectoryExists()
        {
            var directory = Path.GetDirectoryName(FilePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

        /// <summary>
        /// Сохраняет коллекцию контактов.
        /// </summary>
        /// <param name="contacts">Коллекция контактов для сохранения.</param>
        public static void SaveContacts(ObservableCollection<Contact> contacts)
        {
            string json = JsonConvert.SerializeObject(contacts);
            File.WriteAllText(FilePath, json);
        }

        /// <summary>
        /// Загружает контакты из файла.
        /// </summary>
        /// <returns>Список контактов.</returns>
        public static ObservableCollection<Contact> LoadContacts()
        {
            try
            {
                if (!File.Exists(FilePath))
                {
                    return new ObservableCollection<Contact>();
                }

                string json = File.ReadAllText(FilePath);
                var contacts = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(json);
                return contacts ?? new ObservableCollection<Contact>();
            }
            catch
            {
                return new ObservableCollection<Contact>();
            }
        }
    }
}


