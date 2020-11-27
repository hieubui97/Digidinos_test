using Algorithm.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Algorithm
{
    class Bai11_SortByPrice
    {
        public static List<Product> sortByPrice(List<Product> products)
        {
            int i, j;
            Product temp;
            for (i = 0; i < products.Count - 1; i++)
            {
                for (j = 0; j < products.Count - 1 - i; j++)
                {
                    if (products[j].Price > products[j + 1].Price)
                    {
                        temp = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = temp;
                    }
                }
            }
            return products;
        }
    }
}
