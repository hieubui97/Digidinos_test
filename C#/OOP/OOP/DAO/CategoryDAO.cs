using OOP.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DAO
{
    class CategoryDAO : BaseDAO, IDAO
    {
        Database db = Database.geIntance();

        public override bool insert<Category>(Category category)
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

        public override bool update<Category>(Category category)
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

        public override ArrayList select()
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

        public override bool delete<Category>(Category category)
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
        public override bool truncate()
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
