using Newtonsoft.Json;
using System.IO;

namespace View.Model.Services
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
        /// Сохраняет объект <see cref="Contact"/> в файл в формате JSON.
        /// </summary>
        /// <param name="contact">Объект <see cref="Contact"/>, который сохраняется в файл.</param>
        public void SaveContact(Contact contact)
        {
            string json = JsonConvert.SerializeObject(contact);
            File.WriteAllText(FilePath, json);
        }

        /// <summary>
        /// Загружает объект <see cref="Contact"/> из файла.
        /// </summary>
        /// <returns>Объект <see cref="Contact"/> из файла.</returns>
        public Contact LoadContact()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    string json = File.ReadAllText(FilePath);
                    return JsonConvert.DeserializeObject<Contact>(json);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка при загрузке файла {ex.Message}");
            }
            return new Contact();
        }

        /// <summary>
        /// Создает новый экземпляр класса <see cref="ContactSerializer"/>.
        /// Устанавливает путь к файлу.
        /// </summary>
        public ContactSerializer()
        {
            if (!Directory.Exists(Path.GetDirectoryName(FilePath)))
                Directory.CreateDirectory(Path.GetDirectoryName(FilePath));
        }
    }
}
