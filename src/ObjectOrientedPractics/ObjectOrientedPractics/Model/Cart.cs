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
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public double Amount
        {
            get
            {
                double totalCost = 0.0;
                if(Items.Count <= 0 || Items == null)
                {
                    return 0.0;
                }
                foreach(Item item in Items)
                {
                    totalCost += item.Cost;
                }
                return totalCost;
            }
        }
    }
}
