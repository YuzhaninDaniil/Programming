namespace Programming.View.Panels
{
    public partial class SeasonsHandler : UserControl
    {
        public SeasonsHandler()
        {
            InitializeComponent();
        }

        private void SeasonsHandler_Load(object sender, EventArgs e)
        {
            SeasonsComboBox.DataSource = Enum.GetValues(typeof(Season));
            SeasonsComboBox.SelectedIndex = 0;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            Season currentSeason = (Season)SeasonsComboBox.SelectedItem;
            switch (currentSeason)
            {
                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    SeasonHandleGroupBox.BackColor = AppColors.White;
                    break;
                case Season.Spring:
                    MessageBox.Show("Сейчас весна");
                    SeasonHandleGroupBox.BackColor = AppColors.Green;
                    break;
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Autumn:
                    MessageBox.Show("Сейчас осень");
                    break;
            }
        }
    }
}
