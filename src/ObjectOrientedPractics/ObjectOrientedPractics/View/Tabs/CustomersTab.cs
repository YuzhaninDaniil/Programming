namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// True, если данные в полях корректны, иначе false.
        /// </summary>
        bool _isDataValid = true;

        /// <summary>
        /// True, если список пуст, иначе false.
        /// </summary>
        private bool _isDataClear = false;

        /// <summary>
        /// Список, хранящий всех покупателей.
        /// </summary>
        private List<Customer> _customers = new();

        /// <summary>
        /// Выбранный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        public CustomersTab()
        {
            InitializeComponent();
        }

        private void CustomersTab_Load(object sender, EventArgs e)
        {
            _customers.Add(new Customer());
            CustomersListBox.DataSource = _customers;
            CustomersListBox.SelectedIndex = 0;
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            _customers.Add(customer);
            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;
            CustomersListBox.SelectedIndex = _customers.Count - 1;

            CheckDataForClear();
        }

        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            _customers.Remove(_currentCustomer);
            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;
            CustomersListBox.SelectedIndex = _customers.Count - 1;

            CheckDataForClear();
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
            CustomerIdTextBox.Text = _currentCustomer.Id.ToString();
            CustomerFullNameTextBox.Text = _currentCustomer.FullName.ToString();
            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;
        }

        private void CustomerFullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isDataClear) return;
            _isDataValid = true;
            CustomerFullNameTextBox.BackColor = Color.White;

            if (string.IsNullOrEmpty(CustomerFullNameTextBox.Text) || CheckWordOnDigit(CustomerFullNameTextBox.Text))
            {
                _isDataValid = false;
                CustomerFullNameTextBox.BackColor = Color.LightPink;
                return;
            }
            try
            {
                _currentCustomer.FullName = CustomerFullNameTextBox.Text;
            }
            catch (Exception ex)
            {
                _isDataValid = false;
                CustomerFullNameTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Проверяет на то, пустые ли TextBoxes.
        /// </summary>
        public void CheckDataForClear()
        {
            _isDataClear = true;

            if (_customers.Count <= 0)
            {
                CustomerIdTextBox.Clear();
                CustomerIdTextBox.Enabled = false;
                CustomerFullNameTextBox.Clear();
                CustomerFullNameTextBox.Enabled = false;
            }
            else
            {
                CustomerIdTextBox.Enabled = true;
                CustomerFullNameTextBox.Enabled = true;

                _isDataClear = false;
            }
        }

        /// <summary>
        /// Проверяет слово на то, есть ли в нем цифры.
        /// </summary>
        /// <param name="text">Строка.</param>
        /// <returns></returns>
        public bool CheckWordOnDigit(string text)
        {
            bool hasDigit = false;

            foreach (char c in text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    hasDigit = true;
                    break;
                }
            }
            return hasDigit;
        }
    }
}
