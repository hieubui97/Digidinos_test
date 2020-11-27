using Algorithm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Algorithm
{
    class Bai14_MapProductByCategory
    {
        public static List<Product> mapProductByCategory(List<Product> products, List<Category> categories)
        {
            int i;
            for (i = 0; i < products.Count; i++)
            {
                products[i].CategoryName = Bai13_SortByCategoryName.getNameCategory(products[i].CategoryId, categories);
            }

            return products;
        }
    }
}
