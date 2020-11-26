using Algorithm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Algorithm
{
    class Bai15_MinByPrice
    {
        public static Product minByPrice(List<Product> products)
        {
            int i, iMin = 0, priceMin = products[0].Price;
            for(i = 1; i < products.Count; i++)
            {
                if (products[i].Price < priceMin)
                {
                    iMin = i;
                    priceMin = products[i].Price;
                }
            }

            return products[iMin];
        }
    }
}
