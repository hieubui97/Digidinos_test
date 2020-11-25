using OOP.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DAO
{
    class AccessoryDAO
    {
        Database db = Database.geIntance();

        public bool insertAccessory(Accessory accessory)
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

        public bool updateAccessory(Accessory accessory)
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

        public ArrayList selectAccessory()
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

        public bool deleteAccessory(Accessory accessory)
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
        public bool truncateAccessory()
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
