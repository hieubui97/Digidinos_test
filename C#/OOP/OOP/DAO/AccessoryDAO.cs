using OOP.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DAO
{
    public class AccessoryDAO: BaseDAO, IDAO
    {
        public AccessoryDAO()
        {
            tableName = Database.ACCESSORY;
        }
    }
}
