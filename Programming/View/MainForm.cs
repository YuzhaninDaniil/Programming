namespace Programming
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }
        #region EnumsPage
        /// <summary>
        /// ����� ������������� ����� �������� ���������� ����� ������� + SeasonsComboBox �������� � enum
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            EnumsListBox.SelectedIndex = 0;

            SeasonsComboBox.DataSource = Enum.GetValues(typeof(Season));
            SeasonsComboBox.SelectedIndex = 0;
        }


        /// <summary>
        /// ���������� ��������� Enum/null �� EnumsListBox
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// ����� ��������� �������� �� SeasonsComboBox � �������� �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoButton_Click(object sender, EventArgs e)
        {
            Season currentSeason = (Season)SeasonsComboBox.SelectedItem;
            switch (currentSeason)
            {
                case Season.Winter:
                    MessageBox.Show("����! �������!");
                    break;
                case Season.Spring:
                    MessageBox.Show("������ �����");
                    break;
                case Season.Summer:
                    MessageBox.Show("���! ������!");
                    break;
                case Season.Autumn:
                    MessageBox.Show("������ �����");
                    break;
            }
        }

        /// <summary>
        /// ����� �������� ���������� �������� ������ � ��� ������������ Weekday, ����� ��������� � parsedWeekday
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeekdayParsingButton_Click(object sender, EventArgs e)
        {
            string weekday = WeekdayTextBox.Text;
            object parsedWeekday;
            bool isWeek = Enum.TryParse(typeof(Weekday), weekday, out parsedWeekday);

            if (isWeek && int.Parse(weekday) <= 6)
            {
                ParsedWeekdayLabel.Text = $"��� ���� ������ ({parsedWeekday} = {(int)parsedWeekday})";
            }
            else
            {
                ParsedWeekdayLabel.Text = "��� ������ ��� ������";
            }

        }

        /// <summary>
        /// ����� ���������� ��� ������ �������� EnumsListBox � �������� ValuesListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Type selectedEnum = GetSelectedEnum();
            if (selectedEnum == null)
            {
                ValuesListBox.Items.Add("�������� �� �������");
                return;
            }

            ValuesListBox.DataSource = Enum.GetValues(selectedEnum);
            ValuesListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// ����� ���������� int �������� ������� ������������ �� ValuesListBox � ��������� IntValue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedValue = ValuesListBox.SelectedItem.ToString();
            Type selectedEnum = GetSelectedEnum();

            // ���� �������� � ���� int, ����� �� ������������ ������� � �����
            IntValue.Text = $"{(int)Enum.Parse(selectedEnum, SelectedValue)}";
        }
        #endregion

        private void ClassesPage_Click(object sender, EventArgs e)
        {

        }
    }
}