namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EnumsListBox.SelectedIndex = 0;

            SeasonsComboBox.DataSource = Enum.GetValues(typeof(Season));
            SeasonsComboBox.SelectedIndex = 0;
        }
        private Type GetSelectedEnum()
        {
            string CurrentEnumName = EnumsListBox.SelectedItem.ToString();

            switch (CurrentEnumName)
            {
                case "Color":
                    return typeof(Color);
                case "Weekday":
                    return typeof(Weekday);
                case "EducationForm":
                    return typeof(EducationForm);
                case "Genre":
                    return typeof(Genre);
                case "Manufacture":
                    return typeof(Manufactures);
                case "Season":
                    return typeof(Season);
            }
            return null;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            Season currentSeason = (Season)SeasonsComboBox.SelectedItem;
            switch (currentSeason)
            {
                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Spring:
                    MessageBox.Show("Сейчас весна");
                    break;
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Autumn:
                    MessageBox.Show("Сейчас осень");
                    break;
            }
        }

        private void WeekdayParsingButton_Click(object sender, EventArgs e)
        {
            string weekday = WeekdayTextBox.Text;
            object? parsedWeekday;
            bool isWeek = Enum.TryParse(typeof(Weekday), weekday, true, out parsedWeekday);

            if (isWeek)
            {
                ParsedWeekdayLabel.Text = $"Это день недели ({parsedWeekday} = {(int)parsedWeekday})";
            }
            else
            {
                ParsedWeekdayLabel.Text = "Нет такого дня недели";
            }
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Type selectedEnum = GetSelectedEnum();
            if (selectedEnum == null)
            {
                ValuesListBox.Items.Add("Элементы не найдены");
                return;
            }

            ValuesListBox.DataSource = Enum.GetValues(selectedEnum);
            ValuesListBox.SelectedIndex = 0;
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedValue = ValuesListBox.SelectedItem.ToString();
            Type selectedEnum = GetSelectedEnum();

            IntValue.Text = $"{(int)Enum.Parse(selectedEnum, SelectedValue)}";
        }
    }
}