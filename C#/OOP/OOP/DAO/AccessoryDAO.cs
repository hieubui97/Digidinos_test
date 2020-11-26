using OOP.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DAO
{
    class AccessoryDAO: BaseDAO, IDAO
    {
        Database db = Database.geIntance();

        public override bool insert<Accessory>(Accessory accessory)
        {
            try
            {
                db.insertTable<Accessory>(Database.ACCESSORY, accessory);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override bool update<Accessory>(Accessory accessory)
        {
            try
            {
                db.updateTable<Accessory>(Database.ACCESSORY, accessory);
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
                return db.selectTable(Database.ACCESSORY);
            }
            catch
            {
                return null;
            }
        }

        public override bool delete<Accessory>(Accessory accessory)
        {
            try
            {
                return db.deleteTable<Accessory>(Database.ACCESSORY, accessory);
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
                db.truncateTable(Database.ACCESSORY);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
