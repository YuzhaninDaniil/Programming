namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store = new Store();
        public MainForm()
        {
            InitializeComponent();
            _store.Items.Add(ItemFactory.Generate());
            _store.Items.Add(ItemFactory.Generate());
            _store.Items.Add(ItemFactory.Generate());

            _store.Customers.Add(CustomerFactory.Generate());
            _store.Customers.Add(CustomerFactory.Generate());
            _store.Customers.Add(CustomerFactory.Generate());

            customersTab.Customers = _store.Customers;
            itemsTab.Items = _store.Items;
        }
    }
}
