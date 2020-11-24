using OOP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOP.Demo
{
    class ProductDemo
    {
        public Product createProductTest(int id, string name, int categoryId)
        {
            Product product = new Product(id, name, categoryId);

            return product;
        }

        public void printProduct(Product product)
        {
            Console.WriteLine("Product");
            Console.WriteLine("id:" + product.id);
            Console.WriteLine("name:" + product.name);
            Console.WriteLine("categoryId:" + product.categoryId);
            Console.WriteLine();
        }
    }
}
