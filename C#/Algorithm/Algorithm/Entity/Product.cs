using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Entity
{
    class Product
    {
        private string name;
        private int price;
        private int quality;
        private int categoryId;
        private string categoryName;
        //public virtual Category Category { get; set; }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Quality
        {
            get { return quality; }
            set { quality = value; }
        }
        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }
        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }

        public static void printProduct(Product product)
        {
            Console.WriteLine("Product { name = " + product.Name + ", price = " + product.Price + ", quality = " + product.Quality + ", categotyId = " + product.CategoryId + ", categotyName = " + product.categoryName + "}");
        }

        public static void printProductList(List<Product> products)
        {
            int i;
            for (i = 0; i < products.Count; i++)
            {
                Product.printProduct(products[i]);
            }
        }
    }
}
