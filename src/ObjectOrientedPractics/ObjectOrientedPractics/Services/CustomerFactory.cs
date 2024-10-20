using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    internal class CustomerFactory
    {
        private static int _custumerGeneratedCount = 0;

        public static Customer GetNextCustomer()
        {
            Customer newCustomer = new Customer($"FullName{_custumerGeneratedCount}", $"Address{_custumerGeneratedCount}");
            _custumerGeneratedCount++;
            return newCustomer;
        }
    }
}
