using Algorithm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Algorithm
{
    class Bai16_MaxByPrice
    {
        public static Product maxByPrice(List<Product> products)
        {
            int i, iMax = 0, priceMax = products[0].Price;
            for (i = 1; i < products.Count; i++)
            {
                if (products[i].Price > priceMax)
                {
                    iMax = i;
                    priceMax = products[i].Price;
                }
            }

            return products[iMax];
        }
    }
}
