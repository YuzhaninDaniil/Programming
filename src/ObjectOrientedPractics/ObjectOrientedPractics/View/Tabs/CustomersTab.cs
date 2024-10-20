using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// True, если данные в полях корректны, иначе false
        /// </summary>
        bool _isValidData = true;

        /// <summary>
        /// Список, хранящий всех покупателей
        /// </summary>
        private List<Customer> _customers = new();

        /// <summary>
        /// Выбранный покупатель
        /// </summary>
        private Customer _currentCustomer;

        public CustomersTab()
        {
            InitializeComponent();
        }

        private void CustomersTab_Load(object sender, EventArgs e)
        {
            _customers.Add(CustomerFactory.GetNextCustomer());
            _customers.Add(CustomerFactory.GetNextCustomer());
            _customers.Add(CustomerFactory.GetNextCustomer());
            _customers.Add(CustomerFactory.GetNextCustomer());

            CustomersListBox.DataSource = _customers;
            CustomersListBox.SelectedIndex = 0;
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            Customer newCustomer = CustomerFactory.GetNextCustomer();
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
            if (!_isValidData)
            {
                CustomersListBox.SelectedItem = _currentCustomer;
                return;
            }

            _currentCustomer = CustomersListBox.SelectedItem as Customer;

            CustomerIDTextBox.Text = _currentCustomer.ID.ToString();
            CustomerAddressTextBox.Text = _currentCustomer.Address;
            CustomerFullNameTextBox.Text = _currentCustomer.FullName;

            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;
        }

        private void CustomersListBox_Click(object sender, EventArgs e)
        {
            _isValidData = true;

            CustomerAddressTextBox.BackColor = Color.White;
            CustomerFullNameTextBox.BackColor = Color.White;

            try
            {
                string newAddress = CustomerAddressTextBox.Text;
                _currentCustomer.Address = newAddress;
            }
            catch (Exception ex)
            {
                _isValidData = false;
                CustomerAddressTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                string newFullName = CustomerFullNameTextBox.Text;
                _currentCustomer.FullName = newFullName;

            }
            catch (Exception ex)
            {
                _isValidData = false;
                CustomerFullNameTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
