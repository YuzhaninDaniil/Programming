namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl

    {
        private Address _address = new();

        public Address Address
        {
            get
            {
                TryWriteAdressData();
                return _address;
            }
            set
            {
                _address = value;
                ShowAddressInfo();
            }
        }
        public AddressControl()
        {
            InitializeComponent();
        }
        private void ShowAddressInfo()
        {
            PostIndexTextBox.Text = _address.Index.ToString();
            ApartmentTextBox.Text = _address.Apartment.ToString();
            BuildingTextBox.Text = _address.Building.ToString();
            StreetTextBox.Text = _address.Street.ToString();
            CountryTextBox.Text = _address.Country.ToString();
            CityTextBox.Text = _address.City.ToString();
        }

        public bool TryWriteAdressData()
        {
            PostIndexTextBox.BackColor = Color.White;
            ApartmentTextBox.BackColor = Color.White;
            BuildingTextBox.BackColor = Color.White;
            StreetTextBox.BackColor = Color.White;
            CountryTextBox.BackColor = Color.White;
            CityTextBox.BackColor = Color.White;

            bool IsDataCorrect = true;

            try
            {
                int newPostIndex = int.Parse(PostIndexTextBox.Text);
                _address.Index = newPostIndex;
            }
            catch
            {
                IsDataCorrect = false;
                PostIndexTextBox.BackColor = Color.LightPink;
            }

            try
            {
                _address.Apartment = ApartmentTextBox.Text;
            }
            catch
            {
                IsDataCorrect = false;
                ApartmentTextBox.BackColor = Color.LightPink;
            }

            try
            {
                _address.Building = BuildingTextBox.Text;
            }
            catch
            {
                IsDataCorrect = false;
                BuildingTextBox.BackColor = Color.LightPink;
            }

            try
            {
                _address.Street = StreetTextBox.Text;
            }
            catch
            {
                IsDataCorrect = false;
                StreetTextBox.BackColor = Color.LightPink;
            }

            try
            {
                _address.Country = CountryTextBox.Text;
            }
            catch
            {
                IsDataCorrect = false;
                CountryTextBox.BackColor = Color.LightPink;
            }

            try
            {
                _address.City = CityTextBox.Text;
            }
            catch
            {
                IsDataCorrect = false;
                CityTextBox.BackColor = Color.LightPink;
            }

            return IsDataCorrect;
        }
    }
}
