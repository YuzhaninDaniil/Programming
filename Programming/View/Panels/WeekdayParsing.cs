namespace Programming.View.Panels
{
    public partial class WeekdayParsing : UserControl
    {
        public WeekdayParsing()
        {
            InitializeComponent();
        }

        private void WeekdayGroupBox_SizeChanged(object sender, EventArgs e)
        {
            //WeekdayTextBox.Width = this.Width - 87;
            //WeekdayParsingButton.Left = this.Width - 78;
        }

        private void WeekdayParsingButton_Click(object sender, EventArgs e)
        {
            string weekday = WeekdayTextBox.Text;
            object parsedWeekday;

            bool isWeek = Enum.TryParse(typeof(Weekday), weekday, true, out parsedWeekday);

            if (weekday.Equals("monday", StringComparison.OrdinalIgnoreCase) ||
                weekday.Equals("tuesday", StringComparison.OrdinalIgnoreCase) ||
                weekday.Equals("wednesday", StringComparison.OrdinalIgnoreCase) ||
                weekday.Equals("thursday", StringComparison.OrdinalIgnoreCase) ||
                weekday.Equals("friday", StringComparison.OrdinalIgnoreCase) ||
                weekday.Equals("saturday", StringComparison.OrdinalIgnoreCase) ||
                weekday.Equals("sunday", StringComparison.OrdinalIgnoreCase))
            {
                weekday = char.ToUpper(weekday[0]) + weekday.Substring(1).ToLower();
                ParsedWeekdayLabel.Text = $"Это день недели {weekday} = {(int)parsedWeekday}";
            }
            else if (isWeek && int.Parse(weekday) <= 7 && int.Parse(weekday) != 0)
            {
                ParsedWeekdayLabel.Text = $"Это день недели ({parsedWeekday} = {(int)parsedWeekday})";
            }
            else
            {
                ParsedWeekdayLabel.Text = "Нет такого дня недели";
            }
        }
    }
}
