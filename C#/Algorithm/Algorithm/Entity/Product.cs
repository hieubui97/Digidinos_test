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

        public static List<Product> init()
        {
            List<Product> productList = new List<Product>();
            productList.Add(new Product { Name = "CPU", Price = 750, Quality = 10, CategoryId = 1 });
            productList.Add(new Product { Name = "RAM", Price = 50, Quality = 2, CategoryId = 2 });
            productList.Add(new Product { Name = "RAM", Price = 50, Quality = 2, CategoryId = 2 });
            productList.Add(new Product { Name = "Main", Price = 400, Quality = 3, CategoryId = 1 });
            productList.Add(new Product { Name = "Keyboard", Price = 30, Quality = 8, CategoryId = 4 });
            productList.Add(new Product { Name = "Mouse", Price = 25, Quality = 50, CategoryId = 4 });
            productList.Add(new Product { Name = "VGA", Price = 60, Quality = 35, CategoryId = 3 });
            productList.Add(new Product { Name = "Monitor", Price = 120, Quality = 28, CategoryId = 2 });
            productList.Add(new Product { Name = "Case", Price = 120, Quality = 28, CategoryId = 4 });

            return productList;
        }
    }
}
