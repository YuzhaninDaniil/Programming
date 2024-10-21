namespace ObjectOrientedPractics
{
    /// <summary>
    /// Генерирует покупателя
    /// </summary>
    internal class CustomerFactory
    {
        /// <summary>
        /// Счетчик созданных покупателей
        /// </summary>
        private static int _custumerGeneratedCount = 0;

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <returns>Customer</returns>
        public static Customer Generate()
        {
            Customer newCustomer = new Customer($"FullName{_custumerGeneratedCount}", new Address());
            _custumerGeneratedCount++;
            return newCustomer;
        }
    }
}
