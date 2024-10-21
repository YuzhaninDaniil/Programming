namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// True, если данные в полях корректны, иначе false
        /// </summary>
        bool _isDataValid = true;

        /// <summary>
        /// Список, хранящий всех покупателей
        /// </summary>
        private List<Customer> _customers = new();

        /// <summary>
        /// Выбранный покупатель
        /// </summary>
        private Customer _currentCustomer;

        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Customers не должно быть null");
                }
                _customers = value;
            }
        }

        public CustomersTab()
        {
            InitializeComponent();
        }

        private void CustomersTab_Load(object sender, EventArgs e)
        {
            _customers.Add(CustomerFactory.Generate());

            CustomersListBox.DataSource = _customers;
            CustomersListBox.SelectedIndex = 0;
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            Customer newCustomer = CustomerFactory.Generate();
            _customers.Add(newCustomer);
            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;
        }

        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            _customers.Remove(_currentCustomer);
            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;
        }

        

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem == null) return;
            if (!_isDataValid)
            {
                CustomersListBox.SelectedItem = _currentCustomer;
                return;
            }

            _currentCustomer = CustomersListBox.SelectedItem as Customer;

            CustomerIDTextBox.Text = _currentCustomer.Id.ToString();
            CustomerAddressControl.Address = _currentCustomer.Address;
            CustomerFullNameTextBox.Text = _currentCustomer.FullName;

            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;
        }

        private void CustomersListBox_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem == null) { return; }

            _isDataValid = true;

            CustomerFullNameTextBox.BackColor = Color.White;

            if (CustomerAddressControl.TryWriteAdressData())
            {
                _currentCustomer.Address = CustomerAddressControl.Address;
            }
            else
            {
                _isDataValid = false;
            }


            try
            {
                string newFullName = CustomerFullNameTextBox.Text;
                _currentCustomer.FullName = newFullName;
            }
            catch (Exception)
            {
                _isDataValid = false;
                CustomerFullNameTextBox.BackColor = Color.LightPink;
            }
        }
    }
}
