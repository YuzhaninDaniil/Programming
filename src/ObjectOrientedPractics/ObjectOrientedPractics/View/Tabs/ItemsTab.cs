using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Хранит данные о корректности данных.
        /// </summary>
        private bool _isDataValid = true;

        /// <summary>
        /// Список, хранящий все товары и информацию о них.
        /// </summary>
        private List<Item> _items = new();

        private List<Item> _filteredItems;

        private bool isNameChanged = false;

        /// <summary>
        /// Текущий выбранный товар.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Возвращает и задает список класса <see cref="Item"/>.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"{nameof(Items)} не должно быть null.");
                }
                _items = value;
            }
        }

        /// <summary>
        /// Инициализирует компоненты класса.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// При запуске приложения загружает в ListBox <see cref="ItemsListBox"/> список типа <see cref="Item"/>.
        /// А также загружает Combobox типа <see cref="Category"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemsTab_Load(object sender, EventArgs e)
        {
            _filteredItems = DataTools.Filter(_items, item => item.Name.Contains(SearchTextBox.Text));

            ItemCategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            SortComboBox.SelectedIndex = 0;
            ItemsListBox.DataSource = _filteredItems;
        }

        /// <summary>
        /// Добавляет в список экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            _items.Add(item);
            _filteredItems = DataTools.Filter(_items, item => item.Name.Contains(SearchTextBox.Text));
            FilterItems();
        }

        /// <summary>
        /// Удаляет из списка экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            _items.Remove(_currentItem);
            _filteredItems = DataTools.Filter(_items, item => item.Name.Contains(SearchTextBox.Text));

            UpdateListBoxData();
        }

        /// <summary>
        /// Меняет отображение списка при добавлении/удалении элемента. Также загружает в Textboxes данные из полей текущего элемента списка.
        /// Если данные некорректны, невозможно покинуть текущий элемент списка, пока данные не станут корректными.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null) return;

            if (!_isDataValid)
            {
                ItemsListBox.SelectedItem = _currentItem;
                return;
            }

            if (isNameChanged)
            {
                FilterItems();
                isNameChanged = false;
            }

            _currentItem = ItemsListBox.SelectedItem as Item;

            ItemIdTextBox.Text = _currentItem.Id.ToString();
            ItemCostTextBox.Text = _currentItem.Cost.ToString();
            ItemNameTextBox.Text = _currentItem.Name;
            ItemInfoTextBox.Text = _currentItem.Info;
            ItemCategoryComboBox.SelectedItem = _currentItem.Category;

            
        }

        /// <summary>
        /// Меняет состояние свойства Cost через валидацию вводимых данных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemCostTextBox_TextChanged(object sender, EventArgs e)
        {
            _isDataValid = true;
            ItemCostTextBox.BackColor = Color.White;

            if (!ValueValidator.CheckStringOnNullOrEmpty(ItemCostTextBox.Text))
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

        /// <summary>
        /// Меняет состояние свойства Name через валидацию вводимых данных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _isDataValid = true;
            ItemNameTextBox.BackColor = Color.White;

            if (!ValueValidator.CheckStringOnNullOrEmpty(ItemNameTextBox.Text))
            {
                _isDataValid = false;
                ItemNameTextBox.BackColor = Color.LightPink;
                return;
            }
            try
            {
                //_currentItem.Name = ItemNameTextBox.Text;
                string name = ItemNameTextBox.Text;
                if (name != _currentItem.Name)
                {
                    isNameChanged = true;
                }
                _currentItem.Name = name;
            }
            catch (Exception ex)
            {
                _isDataValid = false;
                ItemNameTextBox.BackColor = Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Меняет состояние свойства Info через валидацию вводимых данных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemInfoTextBox_TextChanged(object sender, EventArgs e)
        {
            _isDataValid = true;
            ItemInfoTextBox.BackColor = Color.White;

            if (!ValueValidator.CheckStringOnNullOrEmpty(ItemInfoTextBox.Text))
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
        /// Меняет состояние свойства Category через валидацию вводимых данных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentItem is null) { return; }
            _currentItem.Category = (Category)ItemCategoryComboBox.SelectedItem;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterItems();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            _filteredItems = DataTools.Filter(_items, item => item.Name.Contains(SearchTextBox.Text));
            UpdateListBoxData();
        }

        void FilterItems()
        {
            if (_items == null) return;

            string searchText = SearchTextBox.Text;
            string selectedOrder = SortComboBox.SelectedItem.ToString();

            _filteredItems = DataTools.Filter(_items, item =>
                 item.Name.Contains(searchText)
                 );
            switch (selectedOrder)
            {
                case "Name":
                    _filteredItems = DataTools.Sort(_filteredItems, DataTools.CompareByName);

                    break;
                case "Cost (Ascending)":

                    _filteredItems = DataTools.Sort(_filteredItems, DataTools.CompareByCostAscending);

                    break;
                case "Cost (Descending)":

                    _filteredItems = DataTools.Sort(_filteredItems, DataTools.CompareByCostDescending);

                    break;
            }

            UpdateListBoxData();
        }

        void UpdateListBoxData()
        {
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _filteredItems;
        }

    }
}
