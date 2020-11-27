using OOP.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DAO
{
    public class ProductDAO: BaseDAO, IDAO
    {
        public ProductDAO()
        {
            tableName = Database.PRODUCT;
        }
    }
}
