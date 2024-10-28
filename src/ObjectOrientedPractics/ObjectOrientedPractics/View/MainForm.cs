using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// ’ранит в себе список товаров и список покупателей.
        /// </summary>
        private Store _store = new Store();
        public MainForm()
        {
            InitializeComponent();

            _store.Items.Add(new Item());
            _store.Customers.Add(new Customer());

            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;
        }
    }
}
