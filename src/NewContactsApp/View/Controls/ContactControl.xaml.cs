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
        private static readonly Regex PhoneNumberRegex = new Regex(@"^[0-9+\-()\s]*$", RegexOptions.Compiled);

        public ContactControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обрабатывает ввод символов в поле телефонного номера,разрешая только цифры, плюсы, скобки, дефисы и пробелы.
        /// </summary>
        private void PhoneNumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string newText = textBox.Text + e.Text;
            e.Handled = !(PhoneNumberRegex.IsMatch(e.Text) && newText.Length <= 100);
        }

        /// <summary>
        /// Обрабатывает вставку текста в поле телефонного номера, проверяя допустимость вставляемых данных
        /// </summary>
        private void PhoneNumberTextBox_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(DataFormats.Text))
            {
                string text = (string)e.DataObject.GetData(DataFormats.Text);
                TextBox textBox = (TextBox)sender;
                string newText = textBox.Text + text;

                if (!string.IsNullOrEmpty(text))
                { 
                    if (!(PhoneNumberRegex.IsMatch(text) && newText.Length <= 100))
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