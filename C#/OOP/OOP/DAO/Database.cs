using Newtonsoft.Json;
using OOP.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOP.DAO
{
    class Database
    {
        public const string PRODUCT = "productTable";
        public const string CATEGORY = "categoryTable";
        public const string ACCESSORY = "accessoryTable";

        private static ArrayList productTable = new ArrayList();
        private static List<Category> categoryTable = new List<Category>();
        private static List<Accessory> accessoryTable = new List<Accessory>();

        private static Database instance = new Database();
        private Database() { }
        public static Database geIntance()
        {
            return instance;
        }

        public int insertTable<T>(string name, T row)
        {
            try
            {
                if (name.Equals(PRODUCT))
                {
                    Product product = (Product)Convert.ChangeType(row, typeof(Product));
                    productTable.Add(product);
                    return 1;
                }
                if (name.Equals(CATEGORY))
                {
                    Category category = (Category)Convert.ChangeType(row, typeof(Category));
                    categoryTable.Add(category);

                    return 1;
                }
                if (name.Equals(ACCESSORY))
                {
                    Accessory accessory = (Accessory)Convert.ChangeType(row, typeof(Accessory));
                    accessoryTable.Add(accessory);

                    return 1;
                }


                return 0;
            }
            catch
            {
                return 0;
            }
        }


        public ArrayList selectTable(string name, string where)
        {
            try
            {
                if (name.Equals(PRODUCT))
                {                  
                    return productTable;
                }
                //if (name.Equals(CATEGORY))
                //{
                //    return 
                //}
                //if (name.Equals(ACCESSORY))
                //{
                //    Accessory accessory = (Accessory)Convert.ChangeType(row, typeof(Accessory));
                //    accessoryTable.Add(accessory);

                //    return 1;
                //}


                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
