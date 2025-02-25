using System.IO;
using System.Windows;
using Newtonsoft.Json;

namespace View.Model.Servicies
{
    /// <summary>
    /// Класс, отвечающий за сериализацию и десериализацию объектов типа <see cref="Contact"/>.
    /// </summary>
    public class ContactSerializer
    {
        /// <summary>
        /// Хранит и возвращает путь к файлу, в котором хранятся данные контакта.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Сохраняет объект <see cref="Contact"/> в файл в формате JSON.
        /// </summary>
        /// <param name="contact">Объект <see cref="Contact"/>, который сохраняется в файл.</param>
        public void SaveContact(Contact contact)
        {
            try
            {
                string json = JsonConvert.SerializeObject(contact, Formatting.Indented);

                File.WriteAllText(Path, json);

                MessageBox.Show("Контакт сохранен!", "Сохранение", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Загружает объект <see cref="Contact"/> из файла.
        /// </summary>
        /// <returns>Объект <see cref="Contact"/> из файла.</returns>
        public Contact LoadContact()
        {
            try
            {
                if (!File.Exists(Path))
                {
                    return null;
                }

                string json = File.ReadAllText(Path);

                Contact contact = JsonConvert.DeserializeObject<Contact>(json);

                MessageBox.Show("Контакт загружен!", "Загрузка", MessageBoxButton.OK, MessageBoxImage.Information);
                return contact;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return null;
            }
        }

        /// <summary>
        /// Создает новый экземпляр класса <see cref="ContactSerializer"/>.
        /// Устанавливает путь к файлу.
        /// </summary>
        public ContactSerializer()
        {
            Path = System.IO.Path.Combine
                (
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "Contacts",
                "contacts.json"
                );

            Directory.CreateDirectory(System.IO.Path.GetDirectoryName(Path));
        }
    }
}
