using OOP.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DAO
{
    class ProductDAO
    {
        Database db = Database.geIntance();

        public bool insertProduct(Product product)
        {
            try
            {
                db.insertTable<Product>(Database.PRODUCT, product);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateProduct(Product product)
        {
            try
            {
                db.updateTable<Product>(Database.PRODUCT, product);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public ArrayList selectProduct()
        {
            try
            {
                return db.selectTable(Database.PRODUCT);
            }
            catch
            {
                return null;
            }
        }

        public bool deleteProduct(Product product)
        {
            try
            {
                return db.deleteTable<Product>(Database.PRODUCT, product);
            }
            catch
            {
                return false;
            }
        }
        public bool truncateProduct()
        {
            try
            {
                db.truncateTable(Database.PRODUCT);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
