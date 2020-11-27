using Algorithm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Algorithm
{
    class Bai12_SortByName
    {
        public static List<Product> sortByName(List<Product> products)
        {
            int i, holePosition;
            Product valueToInsert;
            for (i = 0; i < products.Count; i++)
            {
                valueToInsert = products[i];
                holePosition = i;

                while (holePosition > 0 && products[holePosition - 1].Name.Length < valueToInsert.Name.Length)
                {
                    products[holePosition] = products[holePosition - 1];
                    holePosition--;
                }
                products[holePosition] = valueToInsert;
            }

            return products;
        }
    }
}
