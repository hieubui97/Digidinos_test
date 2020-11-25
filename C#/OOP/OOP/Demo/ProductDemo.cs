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
            Console.WriteLine("id:" + product.Id);
            Console.WriteLine("name:" + product.Name);
            Console.WriteLine("categoryId:" + product.CategoryId);
            Console.WriteLine();
        }
    }
}
