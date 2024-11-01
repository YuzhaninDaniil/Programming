namespace ObjectOrientedPractics
{
    /// <summary>
    /// Содержит информацию о заказе.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// 
        /// </summary>
        private readonly DateTime _date;

        /// <summary>
        /// 
        /// </summary>
        private Address _address;

        /// <summary>
        /// 
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// 
        /// </summary>
        private double _cost;

        /// <summary>
        /// 
        /// </summary>
        private OrderStatus _status;

        /// <summary>
        /// 
        /// </summary>
        private OrderStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// 
        /// </summary>
        public DateTime Date { get { return _date; } }

        /// <summary>
        /// 
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="address"></param>
        /// <param name="items"></param>
        /// <param name="cost"></param>
        public Order(Address address, List<Item> items, double cost)
        {
            _id = IdGenerator.GetNextId();
            _date = DateTime.Now;
            Address = address;
            Items = items;
            Cost = cost;
            Status = OrderStatus.New;
        }
    }
}
