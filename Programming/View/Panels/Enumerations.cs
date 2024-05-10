namespace Programming.View.Panels
{
    public partial class Enumerations : UserControl
    {
        public Enumerations()
        {
            InitializeComponent();
        }

        private void Enumerations_Load(object sender, EventArgs e)
        {
            EnumsListBox.SelectedIndex = 0;
        }

        
        private Type GetSelectedEnum()
        {
            string CurrentEnumName = EnumsListBox.SelectedItem.ToString();

            switch (CurrentEnumName)
            {
                case "ColorEnum":
                    return typeof(ColorEnum);
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
