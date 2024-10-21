namespace ObjectOrientedPractics
{
    /// <summary>
    /// Создает товар
    /// </summary>
    internal class ItemFactory
    {
        /// <summary>
        /// Счетчик созданных товаров
        /// </summary>
        private static int _itemGeneratedCount = 0;

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/> и возвращает его значение
        /// </summary>
        /// <returns>Item</returns>
        public static Item Generate()
        {
            Item item = new Item($"Name{_itemGeneratedCount}", $"Information{_itemGeneratedCount}", _itemGeneratedCount, Category.Plumbing);
            _itemGeneratedCount++;
            return item;
        }
    }
}
