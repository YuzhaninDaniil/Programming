namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        private Address _address;

        /// <summary>
        /// 
        /// </summary>
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        public AddressControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        private void ShowAddressInfo()
        {
            AddressPostIndexTextBox.Text = _address.Index.ToString();
            AddressApartmentTextBox.Text = _address.Apartment.ToString();
            AddressBuildingTextBox.Text = _address.Building.ToString();
            AddressStreetTextBox.Text = _address.Street.ToString();
            AddressCountryTextBox.Text = _address.Country.ToString();
            AddressCityTextBox.Text = _address.City.ToString();
        }

        public bool TryWriteAddressData()
        {
            AddressPostIndexTextBox.BackColor = Color.White;
            AddressApartmentTextBox.BackColor = Color.White;
            AddressBuildingTextBox.BackColor = Color.White;
            AddressStreetTextBox.BackColor = Color.White;
            AddressCountryTextBox.BackColor = Color.White;
            AddressCityTextBox.BackColor = Color.White;

            bool IsDataCorrect = true;
            return IsDataCorrect;
        }
    }
}
