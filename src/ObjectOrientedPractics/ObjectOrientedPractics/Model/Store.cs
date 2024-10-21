namespace ObjectOrientedPractics
{
    internal class Store
    {
        /// <summary>
        /// список всех покупателей.
        /// </summary>
        private List<Customer> _customers;
        /// <summary>
        /// список всех товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Возвращает и задаёт список покупателей. Не должно быть null.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }

            set
            {
                if (_customers == null)
                {
                    throw new ArgumentException("Customers не должно быть null");
                }
                _customers = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт список товаров. Не должно быть null.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                if (_items == null)
                {
                    throw new ArgumentException("Items не должно быть null");
                }
                _items = value;
            }
        }

        public Store()
        {
            _items = new List<Item>();
            _customers = new List<Customer>();
        }
    }
}
