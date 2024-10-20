using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    internal class ItemFactory
    {
        private static int _itemGeneratedCount = 0;

        public static Item Generate()
        {
            Item item = new Item($"Name{_itemGeneratedCount}", $"Information{_itemGeneratedCount}", _itemGeneratedCount);
            _itemGeneratedCount++;
            return item;
        }
    }
}
