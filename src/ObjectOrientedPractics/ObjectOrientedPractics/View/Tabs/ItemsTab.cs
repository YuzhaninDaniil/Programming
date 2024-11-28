using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Событие для изменения информации о товарах.
        /// </summary>
        public event EventHandler ItemsChanged;

        /// <summary>
        /// Хранит данные о корректности данных.
        /// </summary>
        private bool _isDataValid = true;

        /// <summary>
        /// Содержит информацию, изменилось ли имя товара.
        /// </summary>
        private bool _isItemNameChanged = false;

        /// <summary>
        /// Список, хранящий все товары и информацию о них.
        /// </summary>
        private List<Item> _items = new();

        /// <summary>
        /// Хранит список отображаемых отфильтрованных товаров.
        /// </summary>
        private List<Item> _displayedItems;

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
            _displayedItems = DataTools.Filter(_items, item => item.Name.Contains(SearchTextBox.Text));
            SortComboBox.DataSource = Enum.GetValues(typeof(SortOption));
            ItemCategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            SortComboBox.SelectedIndex = 0;
            ItemsListBox.DataSource = _displayedItems;
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
            _displayedItems = DataTools.Filter(_items, item => item.Name.Contains(SearchTextBox.Text));
            FilterItems();

            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Удаляет из списка экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            _items.Remove(_currentItem);
            _displayedItems = DataTools.Filter(_items, item => item.Name.Contains(SearchTextBox.Text));

            UpdateListBoxData();

            ItemsChanged?.Invoke(this, EventArgs.Empty);
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

            if (_isItemNameChanged)
            {
                FilterItems();
                _isItemNameChanged = false;
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

                ItemsChanged?.Invoke(this, EventArgs.Empty);
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
                if (ItemNameTextBox.Text != _currentItem.Name)
                {
                    _isItemNameChanged = true;
                }
                _currentItem.Name = ItemNameTextBox.Text;

                ItemsChanged?.Invoke(this, EventArgs.Empty);
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

                ItemsChanged?.Invoke(this, EventArgs.Empty);
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
            if (_currentItem == null) { return; }
            _currentItem.Category = (Category)ItemCategoryComboBox.SelectedItem;

            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Отвечает за сортировку списка товаров.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterItems();
        }

        /// <summary>
        /// Меняет порядок товаров в ListBox при вводе нового значения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            _displayedItems = DataTools.Filter(_items, item => item.Name.Contains(SearchTextBox.Text));
            UpdateListBoxData();
        }

        /// <summary>
        /// Загружает в список отображаемых товаров новый список, а также применяет к нему сортировку.
        /// </summary>
        void FilterItems()
        {
            if (_items == null) return;

            _displayedItems = DataTools.Filter(_items, item => item.Name.Contains(SearchTextBox.Text));

            switch ((SortOption)SortComboBox.SelectedItem)
            {
                case SortOption.Name: 
                    _displayedItems = DataTools.Sort(_displayedItems, DataTools.CompareByName);
                    break;

                case SortOption.CostAscending: 
                    _displayedItems = DataTools.Sort(_displayedItems, DataTools.CompareByCostAscending);
                    break;

                case SortOption.CostDescending: 
                    _displayedItems = DataTools.Sort(_displayedItems, DataTools.CompareByCostDescending);
                    break;
            }

            UpdateListBoxData();
        }

        /// <summary>
        /// Отображает изменения в Листбоксе.
        /// </summary>
        void UpdateListBoxData()
        {
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _displayedItems;
        }

    }
}
