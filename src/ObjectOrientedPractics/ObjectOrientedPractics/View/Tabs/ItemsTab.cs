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
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// True, если данные в полях корректны, иначе false
        /// </summary>
        bool _isValidData = true;

        /// <summary>
        /// Список, хранящий всех покупателей
        /// </summary>
        private List<Item> _items = new();

        /// <summary>
        /// Выбранный покупатель
        /// </summary>
        private Item _currentItem;

        public ItemsTab()
        {
            InitializeComponent();
        }

        private void ItemsTab_Load(object sender, EventArgs e)
        {
            _items.Add(ItemFactory.Generate());
            _items.Add(ItemFactory.Generate());
            _items.Add(ItemFactory.Generate());

            ItemsListBox.DataSource = _items;
            ItemsListBox.SelectedIndex = 0;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Item newItem = ItemFactory.Generate();
            _items.Add(newItem);
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            _items.Remove(_currentItem);
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null) return;
            if (!_isValidData)
            {
                ItemsListBox.SelectedItem = _currentItem;
                return;
            }

            _currentItem = ItemsListBox.SelectedItem as Item;

            ItemIDTextBox.Text = _currentItem.ID.ToString();
            ItemCostTextBox.Text = _currentItem.Cost.ToString();
            ItemNameTextBox.Text = _currentItem.Name;
            ItemDescriptionTextBox.Text = _currentItem.Info;

            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;
        }

        private void ItemsListBox_Click(object sender, EventArgs e)
        {
            _isValidData = true;

            ItemCostTextBox.BackColor = Color.White;
            ItemNameTextBox.BackColor = Color.White;
            ItemDescriptionTextBox.BackColor = Color.White;

            try
            {
                double cost = double.Parse(ItemCostTextBox.Text);
                _currentItem.Cost = cost;
            }
            catch (Exception ex)
            {
                _isValidData = false;
                ItemCostTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                string name = ItemNameTextBox.Text;
                _currentItem.Name = name;
            }
            catch (Exception ex)
            {
                _isValidData = false;
                ItemNameTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string info = ItemDescriptionTextBox.Text;
                _currentItem.Info = info;
            }
            catch (Exception ex)
            {
                _isValidData = false;
                ItemDescriptionTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
