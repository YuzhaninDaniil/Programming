namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// True, если данные валидны, иначе false.
        /// </summary>
        private bool _isDataValid = true;

        /// <summary>
        /// True, если лист пустой, иначе false.
        /// </summary>
        private bool _isDataClear = false;

        /// <summary>
        /// Хранит элементы типа <see cref="Item"/>.
        /// </summary>
        private List<Item> _items = new();

        /// <summary>
        /// Текущий элемент списка.
        /// </summary>
        private Item _currentItem;

        public ItemsTab()
        {
            InitializeComponent();
        }

        private void ItemsTab_Load(object sender, EventArgs e)
        {
            _items.Add(new Item());
            ItemsListBox.DataSource = _items;
            ItemsListBox.SelectedIndex = 0;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            _items.Add(item);
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;
            ItemsListBox.SelectedIndex = _items.Count - 1;

            CheckDataForClear();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            _items.Remove(_currentItem);
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;
            ItemsListBox.SelectedIndex = _items.Count - 1;

            CheckDataForClear();
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null) return;

            if (!_isDataValid)
            {
                ItemsListBox.SelectedItem = _currentItem;
                return;
            }

            _currentItem = ItemsListBox.SelectedItem as Item;
            ItemIdTextBox.Text = _currentItem.Id.ToString();
            ItemCostTextBox.Text = _currentItem.Cost.ToString();
            ItemNameTextBox.Text = _currentItem.Name;
            ItemInfoTextBox.Text = _currentItem.Info;

            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;
        }

        private void ItemCostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isDataClear) return;
            _isDataValid = true;
            ItemCostTextBox.BackColor = Color.White;

            if (string.IsNullOrEmpty(ItemCostTextBox.Text) || CheckNumberOnLetter(ItemCostTextBox.Text))
            {
                _isDataValid = false;
                ItemCostTextBox.BackColor = Color.LightPink;
                return;
            }
            try
            {
                double cost = double.Parse(ItemCostTextBox.Text);
                _currentItem.Cost = cost;
            }
            catch (Exception ex)
            {
                _isDataValid = false;
                ItemCostTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ItemNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isDataClear) return;
            _isDataValid = true;
            ItemNameTextBox.BackColor = Color.White;

            if (string.IsNullOrEmpty(ItemNameTextBox.Text) || CheckWordOnDigit(ItemNameTextBox.Text))
            {
                _isDataValid = false;
                ItemNameTextBox.BackColor = Color.LightPink;
                return;
            }
            try
            {
                _currentItem.Name = ItemNameTextBox.Text;
            }
            catch (Exception ex)
            {
                _isDataValid = false;
                ItemNameTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ItemInfoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isDataClear) return;
            _isDataValid = true;
            ItemInfoTextBox.BackColor = Color.White;

            if (string.IsNullOrEmpty(ItemInfoTextBox.Text))
            {
                _isDataValid = false;
                ItemInfoTextBox.BackColor = Color.LightPink;
                return;
            }
            try
            {
                _currentItem.Info = ItemInfoTextBox.Text;
            }
            catch (Exception ex)
            {
                _isDataValid = false;
                ItemInfoTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Проверяет TextBoxes на пустоту.
        /// </summary>
        public void CheckDataForClear()
        {
            _isDataClear = true;

            if (_items.Count <= 0)
            {
                ItemIdTextBox.Clear();
                ItemIdTextBox.Enabled = false;
                ItemCostTextBox.Clear();
                ItemCostTextBox.Enabled = false;
                ItemNameTextBox.Clear();
                ItemNameTextBox.Enabled = false;
                ItemInfoTextBox.Clear();
                ItemInfoTextBox.Enabled = false;


            }
            else
            {
                ItemIdTextBox.Enabled = true;
                ItemCostTextBox.Enabled = true;
                ItemNameTextBox.Enabled = true;
                ItemInfoTextBox.Enabled = true;

                _isDataClear = false;
            }
        }

        /// <summary>
        /// Првоеряет число на то, есть ли в нем буквы.
        /// </summary>
        /// <param name="text">Число.</param>
        /// <returns></returns>
        public bool CheckNumberOnLetter(string text)
        {
            bool hasLetter = false;

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    hasLetter = true;
                    break;
                }
            }
            return hasLetter;
        }

        /// <summary>
        /// Првоеряет слово на то, есть ли в нем цифры.
        /// </summary>
        /// <param name="text">Текст.</param>
        /// <returns></returns>
        public bool CheckWordOnDigit(string text)
        {
            bool hasDigit = false;

            foreach (char c in text)
            {
                if (!char.IsLetter(c))
                {
                    hasDigit = true;
                    break;
                }
            }
            return hasDigit;
        }
    }
}
