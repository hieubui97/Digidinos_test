using OOP.DAO;
using OOP.Demo;
using OOP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // ProductDemo
            ProductDemo productDemo = new ProductDemo();
            var product = productDemo.createProductTest(1, "DELL", 1);
            productDemo.printProduct(product);

            // CategoryDemo
            CategoryDemo categoryDemo = new CategoryDemo();
            var category = categoryDemo.createCategoryTest(1, "Laptop");
            categoryDemo.printCategoryTest(category);

            // Accessory
            AccessoryDemo accessoryDemo = new AccessoryDemo();
            var accessory = accessoryDemo.createAccessoryTest(1, "USB");
            accessoryDemo.printAccessoryTest(accessory);

            // DatabaseDemo
            DatabaseDemo databaseDemo = new DatabaseDemo();
            databaseDemo.insertTableTest<Product>(Database.PRODUCT, product);
            databaseDemo.insertTableTest<Category>(Database.CATEGORY, category);
            databaseDemo.insertTableTest<Accessory>(Database.ACCESSORY, accessory);

            var productTable = databaseDemo.selectTable(Database.PRODUCT, "");
            Console.WriteLine(productTable);

            Console.ReadKey();
        }
    }
}
