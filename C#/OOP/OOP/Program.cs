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
            //productDemo.printProduct(product);

            // CategoryDemo
            CategoryDemo categoryDemo = new CategoryDemo();
            var category = categoryDemo.createCategoryTest(1, "Laptop");
            //categoryDemo.printCategoryTest(category);

            // Accessory
            AccessoryDemo accessoryDemo = new AccessoryDemo();
            var accessory = accessoryDemo.createAccessoryTest(1, "USB");
            //accessoryDemo.printAccessoryTest(accessory);




            // DatabaseDemo
            DatabaseDemo databaseDemo = new DatabaseDemo();
            //insert
            //databaseDemo.insertTableTest<Product>(Database.PRODUCT, product);
            //databaseDemo.insertTableTest<Category>(Database.CATEGORY, category);
            //databaseDemo.insertTableTest<Accessory>(Database.ACCESSORY, accessory);

            //init
            databaseDemo.initDatabase();

            //update
            //var update = databaseDemo.updateTableTest<Product>(Database.PRODUCT, product);
            var update = databaseDemo.updateTableTest<Product>(Database.PRODUCT,product.Id, product);

            //delete
            //var delete = databaseDemo.deleteTableTest<Product>(Database.PRODUCT, product);

            //truncate
            databaseDemo.truncateTableTest(Database.ACCESSORY);

            //print
            databaseDemo.printTableTest(Database.PRODUCT);
            //databaseDemo.printTableTest(Database.CATEGORY);
            databaseDemo.printTableTest(Database.ACCESSORY);
            //select
            var productTable = databaseDemo.selectTableTest(Database.PRODUCT);


            //CategoryDaoDemo
            CategoryDaoDemo categoryDaoDemo = new CategoryDaoDemo();
            //categoryDaoDemo.insertTest(category);
            categoryDaoDemo.updateTest(category);
            databaseDemo.printTableTest(Database.CATEGORY);



            Console.ReadKey();
        }
    }
}
