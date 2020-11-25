using OOP.DAO;
using OOP.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOP.Demo
{
    class DatabaseDemo
    {
        public void insertTableTest<T>(string name, T row)
        {
            var db = Database.geIntance();
            db.insertTable(name, row);
        }

        public ArrayList selectTableTest(string name)
        {
            var db = Database.geIntance();
            var result = db.selectTable(name);

            return result;
        }

        public int updateTableTest<T>(string name, T row)
        {
            var db = Database.geIntance();
            var result = db.updateTable<T>(name, row);

            return result;
        }
        public int updateTableTest<T>(string name, int id, T row)
        {
            var db = Database.geIntance();
            var result = db.updateTable<T>(name, id, row);

            return result;
        }

        public bool deleteTableTest<T>(string name, T row)
        {
            var db = Database.geIntance();
            var result = db.deleteTable<T>(name, row);

            return result;
        }

        public void truncateTableTest(string name)
        {
            var db = Database.geIntance();
            db.truncateTable(name);
        }

        public void initDatabase()
        {
            var db = Database.geIntance();
            for (int i = 0; i < 10; i++)
            {
                var product = new Product(i, "Product" + i, i % 2);
                var category = new Category(i, "Category" + i);
                var accessory = new Accessory(i, "Accessory" + i);
                db.insertTable<Product>(Database.PRODUCT, product);
                db.insertTable<Category>(Database.CATEGORY, category);
                db.insertTable<Accessory>(Database.ACCESSORY, accessory);
            }
        }

        public void printTableTest(string name)
        {
            var db = Database.geIntance();
            if (name.Equals(Database.PRODUCT))
            {
                var productList = db.selectTable(Database.PRODUCT);
                for (int i = 0; i < productList.Count; i++)
                {
                    Product product = (Product)Convert.ChangeType(productList[i], typeof(Product));

                    Console.WriteLine("Product " + i);
                    Console.WriteLine("Id: " + product.Id);
                    Console.WriteLine("Name: " + product.Name);
                    Console.WriteLine("Category: " + product.CategoryId);
                    Console.WriteLine();
                }
            }
            if (name.Equals(Database.CATEGORY))
            {
                var categoryList = db.selectTable(Database.CATEGORY);
                for (int i = 0; i < categoryList.Count; i++)
                {
                    Category category = (Category)Convert.ChangeType(categoryList[i], typeof(Category));

                    Console.WriteLine("Category " + i);
                    Console.WriteLine("Id: " + category.Id);
                    Console.WriteLine("Name: " + category.Name);

                    Console.WriteLine();
                }
            }
            if (name.Equals(Database.ACCESSORY))
            {
                var accessoryList = db.selectTable(Database.ACCESSORY);
                for (int i = 0; i < accessoryList.Count; i++)
                {
                    Accessory accessory = (Accessory)Convert.ChangeType(accessoryList[i], typeof(Accessory));

                    Console.WriteLine("Accessory " + i);
                    Console.WriteLine("Id: " + accessory.Id);
                    Console.WriteLine("Name: " + accessory.Name);
                    Console.WriteLine();
                }
            }
        }
    }
}
