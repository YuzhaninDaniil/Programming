using ObjectOrientedPractics.Model.Enums;

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
        /// А также загруждает Combobox типа <see cref="Category"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemsTab_Load(object sender, EventArgs e)
        {
            ItemsListBox.DataSource = _items;
            ItemCategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
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
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;
            ItemsListBox.SelectedIndex = _items.Count - 1;

            ValueValidator.CheckDataForClear(_items, SelectedItemPanel);
        }

        /// <summary>
        /// Удаляет из списка экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            _items.Remove(_currentItem);
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;
            ItemsListBox.SelectedIndex = _items.Count - 1;

            ValueValidator.CheckDataForClear(_items, SelectedItemPanel);
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

            _currentItem = ItemsListBox.SelectedItem as Item;
            ItemIdTextBox.Text = _currentItem.Id.ToString();
            ItemCostTextBox.Text = _currentItem.Cost.ToString();
            ItemNameTextBox.Text = _currentItem.Name;
            ItemInfoTextBox.Text = _currentItem.Info;
            ItemCategoryComboBox.SelectedItem = _currentItem.Category;

            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;
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
                _currentItem.Name = ItemNameTextBox.Text;
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
            _currentItem.Category = (Category)ItemCategoryComboBox.SelectedItem;
        }
    }
}
