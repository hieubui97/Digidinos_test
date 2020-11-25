using OOP.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DAO
{
    class CategoryDAO
    {
        Database db = Database.geIntance();

        public bool insertCategory(Category category)
        {
            try
            {
                db.insertTable<Category>(Database.CATEGORY, category);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateCategory(Category category)
        {
            try
            {
                db.updateTable<Category>(Database.CATEGORY, category);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public ArrayList selectCategory()
        {
            try
            {
                return db.selectTable(Database.CATEGORY);
            }
            catch
            {
                return null;
            }
        }

        public bool deleteCategory(Category category)
        {
            try
            {
                return db.deleteTable<Category>(Database.CATEGORY, category);
            }
            catch
            {
                return false;
            }
        }
        public bool truncateCategory()
        {
            try
            {
                db.truncateTable(Database.CATEGORY);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
