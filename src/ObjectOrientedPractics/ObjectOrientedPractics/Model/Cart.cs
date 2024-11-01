namespace ObjectOrientedPractics
{
    /// <summary>
    /// 
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// 
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// 
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
        }

        /// <summary>
        /// 
        /// </summary>
        public double Amount
        {
            get
            {
                double totalCost = 0.0;

                if (_items == null || _items.Count == 0)
                {
                    return totalCost;
                }

                foreach (var item in _items)
                {
                    totalCost += item.Cost;
                }
                return totalCost;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Cart()
        {
            _items = new List<Item>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(Item item)
        {
            if (item != null)
            {
                _items.Add(item);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void RemoveItem(Item item)
        {
            if (item != null)
            {
                _items.Remove(item);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Clear()
        {
            _items = new List<Item>();
        }
    }
}
