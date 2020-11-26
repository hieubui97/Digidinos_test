using OOP.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DAO
{
    class ProductDAO: BaseDAO, IDAO
    {
        Database db = Database.geIntance();

        public override bool insert<Product>(Product product)
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

        public override bool update<Product>(Product product)
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

        public override ArrayList select()
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

        public override bool delete<Product>(Product product)
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
        public override bool truncate()
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
