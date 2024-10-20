using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
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
        public static Customer GetNextCustomer()
        {
            Customer newCustomer = new Customer($"FullName{_custumerGeneratedCount}", $"Address{_custumerGeneratedCount}");
            _custumerGeneratedCount++;
            return newCustomer;
        }
    }
}
