using System;
using System.Collections.Generic;
using System.Text;

namespace WiredBrainCoffeeDataAccess.Model
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShop()
        {
            yield return new CoffeeShop { Location = "Frankfurt", BeansInStockInKg = 187 };

        }
    }
}
