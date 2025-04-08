using System.IO;
using Newtonsoft.Json;

namespace View.Model.Servicies
{
    /// <summary>
    /// Класс, отвечающий за сериализацию и десериализацию объектов типа <see cref="Contact"/>.
    /// </summary
    public class ContactSerializer
    {
        /// <summary>
        /// Хранит и возвращает путь к файлу, в котором хранятся данные контакта.
        /// </summary>
        public string FilePath { get; set; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Contacts", "contacts.json");

        /// <summary>
        /// Создает новый экземпляр класса <see cref="ContactSerializer"/>.
        /// Устанавливает путь к файлу.
        /// </summary>
        public ContactSerializer()
        {
            if (!Directory.Exists(Path.GetDirectoryName(FilePath)))
                Directory.CreateDirectory(Path.GetDirectoryName(FilePath));
        }

        /// <summary>
        /// Сохраняет контакты в файл в формате JSON.
        /// </summary>
        /// <param name="contacts">Список контактов для сохранения.</param>
        public void SaveContacts(IEnumerable<Contact> contacts)
        {
            string json = JsonConvert.SerializeObject(contacts, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }

        /// <summary>
        /// Загружает контакты из файла.
        /// </summary>
        /// <returns>Список контактов.</returns>
        public List<Contact> LoadContacts()
        {
            try
            {
                if (!File.Exists(FilePath))
                {
                    return new List<Contact>();
                }

                string json = File.ReadAllText(FilePath);
                List<Contact> contacts = JsonConvert.DeserializeObject<List<Contact>>(json);
                return contacts;
            }
            catch (Exception ex)
            {
                return new List<Contact>();
            }
        }
    }
}
