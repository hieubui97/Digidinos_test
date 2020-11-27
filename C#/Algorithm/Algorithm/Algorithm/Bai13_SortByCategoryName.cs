using Algorithm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Algorithm
{
    class Bai13_SortByCategoryName
    {
        public static string getNameCategory(int id, List<Category> categories)
        {
            var result = categories.FirstOrDefault(x => x.Id == id).Name;
            return result;
        }

        public static List<Product> sortByCategoryName(List<Product> products, List<Category> categories)
        {
            int i, j, min;
            Product temp;
            for (i = 0; i < products.Count - 1; i++)
            {
                min = i;
                for (j = i + 1; j < products.Count; j++)
                {
                    if (string.Compare(getNameCategory(products[j].CategoryId, categories), getNameCategory(products[min].CategoryId, categories)) < 0)
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    temp = products[i];
                    products[i] = products[min];
                    products[min] = temp;
                }
            }

            return products;
        }
    }
}
