using Newtonsoft.Json;
using OOP.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOP.DAO
{
    public class Database
    {
        public const string PRODUCT = "productTable";
        public const string CATEGORY = "categoryTable";
        public const string ACCESSORY = "accessoryTable";

        private static ArrayList productTable = new ArrayList();
        private static ArrayList categoryTable = new ArrayList();
        private static ArrayList accessoryTable = new ArrayList();

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


        public ArrayList selectTable(string name)
        {
            try
            {
                if (name.Equals(PRODUCT))
                {
                    return productTable;
                }

                if (name.Equals(CATEGORY))
                {
                    return categoryTable;
                }

                if (name.Equals(ACCESSORY))
                {
                    return accessoryTable;
                }

                return null;
            }
            catch
            {
                return null;
            }
        }


        public int updateTable<T>(string name, T row)
        {
            try
            {
                if (name.Equals(PRODUCT))
                {
                    Product product = (Product)Convert.ChangeType(row, typeof(Product));

                    //int i = productTable.IndexOf(product);
                    //productTable[i] = row;

                    for (int i = 0; i < productTable.Count; i++)
                    {
                        Product item = (Product)Convert.ChangeType(productTable[i], typeof(Product));
                        if (item.Id == product.Id)
                        {
                            productTable[i] = product;
                            return 1;
                        }
                    }
                    return 0;
                }

                if (name.Equals(CATEGORY))
                {
                    Category category = (Category)Convert.ChangeType(row, typeof(Category));
                    for (int i = 0; i < categoryTable.Count; i++)
                    {
                        Category item = (Category)Convert.ChangeType(categoryTable[i], typeof(Category));
                        if (item.Id == category.Id)
                        {
                            categoryTable[i] = category;
                            return 1;
                        }
                    }
                    return 0;
                }

                if (name.Equals(ACCESSORY))
                {
                    Accessory accessory = (Accessory)Convert.ChangeType(row, typeof(Accessory));
                    for (int i = 0; i < productTable.Count; i++)
                    {
                        Accessory item = (Accessory)Convert.ChangeType(accessoryTable[i], typeof(Accessory));
                        if (item.Id == accessory.Id)
                        {
                            accessoryTable[i] = accessory;
                            return 1;
                        }
                    }
                    return 0;
                }

                return 0;
            }
            catch
            {
                return 0;
            }
        }

        public bool deleteTable<T>(string name, T row)
        {
            try
            {
                if (name.Equals(PRODUCT))
                {
                    Product product = (Product)Convert.ChangeType(row, typeof(Product));
                    productTable.Remove(product);

                    return true;
                }

                if (name.Equals(CATEGORY))
                {
                    Category category = (Category)Convert.ChangeType(row, typeof(Category));
                    categoryTable.Remove(category);

                    return true;
                }

                if (name.Equals(ACCESSORY))
                {
                    Accessory accessory = (Accessory)Convert.ChangeType(row, typeof(Accessory));
                    accessoryTable.Remove(accessory);

                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        public void truncateTable(string name)
        {
            try
            {
                if (name.Equals(PRODUCT))
                {
                    productTable.Clear();
                }

                if (name.Equals(CATEGORY))
                {
                    categoryTable.Clear();
                }

                if (name.Equals(ACCESSORY))
                {
                    accessoryTable.Clear();
                }
            }
            catch
            {
                Console.WriteLine("Truncate error!");
            }
        }

        public int updateTable<T>(string name, int id, T row)
        {
            try
            {
                if (name.Equals(PRODUCT))
                {
                    Product product = (Product)Convert.ChangeType(row, typeof(Product));

                    //int i = productTable.IndexOf(product);
                    //productTable[i] = row;

                    for (int i = 0; i < productTable.Count; i++)
                    {
                        Product item = (Product)Convert.ChangeType(productTable[i], typeof(Product));
                        if (item.Id == id)
                        {
                            productTable[i] = product;
                            return 1;
                        }
                    }
                    return 0;
                }

                if (name.Equals(CATEGORY))
                {
                    Category category = (Category)Convert.ChangeType(row, typeof(Category));
                    for (int i = 0; i < categoryTable.Count; i++)
                    {
                        Category item = (Category)Convert.ChangeType(categoryTable[i], typeof(Category));
                        if (item.Id == id)
                        {
                            categoryTable[i] = category;
                            return 1;
                        }
                    }
                    return 0;
                }

                if (name.Equals(ACCESSORY))
                {
                    Accessory accessory = (Accessory)Convert.ChangeType(row, typeof(Accessory));
                    for (int i = 0; i < productTable.Count; i++)
                    {
                        Accessory item = (Accessory)Convert.ChangeType(accessoryTable[i], typeof(Accessory));
                        if (item.Id == id)
                        {
                            accessoryTable[i] = accessory;
                            return 1;
                        }
                    }
                    return 0;
                }

                return 0;
            }
            catch
            {
                return 0;
            }
        }
    }
}
