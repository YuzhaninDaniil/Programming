namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Хранит данные о корректности данных.
        /// </summary>
        private bool _isAddressDataValid = true;

        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private Address _address = new();

        /// <summary>
        /// Возвращает и задает адрес объекта. В gettere возвращает <see cref="CheckIfAddressDataValid"/>. Через setter задает Textboxes.
        /// </summary>
        public Address Address
        {
            get
            {
                CheckIfAddressDataValid();
                return _address;
            }
            set
            {
                _address = value;
                ShowAddressInfo();
            }
        }

        /// <summary>
        /// Инициализирует компоненты класса.
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Вносит данные в <see cref="AddressPostIndexTextBox"/> данные.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddressPostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            AddressPostIndexTextBox.BackColor = Color.White;
            _isAddressDataValid = true;

            if (!ValueValidator.CheckStringOnNullOrEmpty(AddressPostIndexTextBox.Text))
            {
                _isAddressDataValid = false;
                AddressPostIndexTextBox.BackColor = Color.LightPink;
                return;
            }
            try
            {
                _address.Index = int.Parse(AddressPostIndexTextBox.Text);
            }
            catch (Exception ex)
            {
                _isAddressDataValid = false;
                AddressPostIndexTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CheckIfAddressDataValid();
        }

        /// <summary>
        /// Вносит данные в <see cref="AddressCountryTextBox"/> данные.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddressCountryTextBox_TextChanged(object sender, EventArgs e)
        {
            AddressCountryTextBox.BackColor = Color.White;
            _isAddressDataValid = true;

            if (!ValueValidator.CheckStringOnNullOrEmpty(AddressCountryTextBox.Text))
            {
                _isAddressDataValid = false;
                AddressCountryTextBox.BackColor = Color.LightPink;
                return;
            }
            try
            {
                _address.Country = AddressCountryTextBox.Text;
            }
            catch (Exception ex)
            {
                _isAddressDataValid = false;
                AddressCountryTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CheckIfAddressDataValid();
        }

        /// <summary>
        /// Вносит данные в <see cref="AddressCityTextBox"/> данные.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddressCityTextBox_TextChanged(object sender, EventArgs e)
        {
            AddressCityTextBox.BackColor = Color.White;
            _isAddressDataValid = true;

            if (!ValueValidator.CheckStringOnNullOrEmpty(AddressCityTextBox.Text))
            {
                _isAddressDataValid = false;
                AddressCityTextBox.BackColor = Color.LightPink;
                return;
            }
            try
            {
                _address.City = AddressCityTextBox.Text;
            }
            catch (Exception ex)
            {
                _isAddressDataValid = false;
                AddressCityTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CheckIfAddressDataValid();
        }

        /// <summary>
        /// Вносит данные в <see cref="AddressStreetTextBox"/> данные.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddressStreetTextBox_TextChanged(object sender, EventArgs e)
        {
            AddressStreetTextBox.BackColor = Color.White;
            _isAddressDataValid = true;

            if (!ValueValidator.CheckStringOnNullOrEmpty(AddressStreetTextBox.Text))
            {
                _isAddressDataValid = false;
                AddressStreetTextBox.BackColor = Color.LightPink;
                return;
            }
            try
            {
                _address.Street = AddressStreetTextBox.Text;
            }
            catch (Exception ex)
            {
                _isAddressDataValid = false;
                AddressStreetTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CheckIfAddressDataValid();
        }

        /// <summary>
        /// Вносит данные в <see cref="AddressBuildingTextBox"/> данные.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddressBuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            AddressBuildingTextBox.BackColor = Color.White;
            _isAddressDataValid = true;

            if (!ValueValidator.CheckStringOnNullOrEmpty(AddressBuildingTextBox.Text))
            {
                _isAddressDataValid = false;
                AddressBuildingTextBox.BackColor = Color.LightPink;
                return;
            }
            try
            {
                _address.Building = AddressBuildingTextBox.Text;
            }
            catch (Exception ex)
            {
                _isAddressDataValid = false;
                AddressBuildingTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CheckIfAddressDataValid();
        }

        /// <summary>
        /// Вносит данные в <see cref="AddressApartmentTextBox"/> данные.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddressApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            AddressApartmentTextBox.BackColor = Color.White;
            _isAddressDataValid = true;

            if (!ValueValidator.CheckStringOnNullOrEmpty(AddressApartmentTextBox.Text))
            {
                _isAddressDataValid = false;
                AddressApartmentTextBox.BackColor = Color.LightPink;
                return;
            }
            try
            {
                _address.Apartment = AddressApartmentTextBox.Text;
            }
            catch (Exception ex)
            {
                _isAddressDataValid = false;
                AddressApartmentTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CheckIfAddressDataValid();
        }

        /// <summary>
        /// Возвращает истинность валидности данных.
        /// </summary>
        /// <returns>True если данные корректны, иначе false.</returns>
        public bool CheckIfAddressDataValid()
        {
            return _isAddressDataValid;
        }

        /// <summary>
        /// Записывает в Textboxes данные из полей адреса.
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
    }
}
