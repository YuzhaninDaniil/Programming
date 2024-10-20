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
        /// список для хранения всех товаров
        /// </summary>
        private List<Item> _items = new();

        /// <summary>
        /// текущий выбранный товар
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// true если данные введены корректно, иначе - false 
        /// </summary>
        bool _isDataCorrect = true;

        public ItemsTab()
        {
            InitializeComponent();
        }

        private void ItemsTab_Load(object sender, EventArgs e)
        {
            _items.Add(new Item("Banana", "Вкусный", 1000));
            _items.Add(new Item("Jeans", "Джинсы обычные", 5000));
            _items.Add(new Item("Juice", "Сок персиковый", 300));

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
            if (!_isDataCorrect)
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
            _isDataCorrect = true;

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
                ItemCostTextBox.BackColor = Color.LightPink;
                _isDataCorrect = false;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                string name = ItemNameTextBox.Text;
                _currentItem.Name = name;
            }
            catch (Exception ex)
            {
                ItemNameTextBox.BackColor = Color.LightPink;
                _isDataCorrect = false;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                string info = ItemDescriptionTextBox.Text;
                _currentItem.Info = info;
            }
            catch (Exception ex)
            {
                ItemDescriptionTextBox.BackColor = Color.LightPink;
                _isDataCorrect = false;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
