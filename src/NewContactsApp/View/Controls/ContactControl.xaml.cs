using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace View.Controls
{
    /// <summary>
    /// Логика взаимодействия для ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        public ContactControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик события <see cref="TextBox.PreviewTextInput"/> для текстового поля PhoneNumber.
        /// Запрещает ввод любых недопустимых символов и ограничивает длину в 100 символов.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект <see cref="TextCompositionEventArgs"/>, содержащий данные о событии.</param>
        private void PhoneNumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            string newText = (sender as TextBox).Text + e.Text;
            Regex regex = new Regex("[^0-9+\\-\\(\\)\\s]+");
            e.Handled = regex.IsMatch(e.Text) || newText.Length > 100;
        }

        /// <summary>
        /// Обработчик события <see cref="DataObject.Pasting"/> для текстового поля PhoneNumber.
        /// Предотвращает вставку недопустимых символов из буфера обмена и ограничивает длину в 100 символов.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Объект <see cref="DataObjectPastingEventArgs"/>, содержащий данные о событии.</param>
        private void PhoneNumberTextBox_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                string text = (string)e.DataObject.GetData(typeof(string));
                if (!string.IsNullOrEmpty(text))
                {
                    string newText = (sender as TextBox).Text + text;
                    Regex regex = new Regex("[^0-9+\\-\\(\\)\\s]+");
                    if (regex.IsMatch(text) || newText.Length > 100)
                    {
                        e.CancelCommand();
                    }
                }
            }
            else
            {
                e.CancelCommand();
            }
        }
    }
}
