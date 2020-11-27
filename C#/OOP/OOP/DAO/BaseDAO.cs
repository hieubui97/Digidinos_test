using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DAO
{
    public abstract class BaseDAO
    {
        protected Database db;
        protected string tableName;

        public BaseDAO()
        {
            db = Database.geIntance();
        }

        public int insert<T>( T row)
        {
            try
            {
                return db.insertTable<T>(tableName, row);
            }
            catch
            {
                return 0;
            }
        }
        
        public int update<T>(T row)
        {
            try
            {
                return db.updateTable<T>(tableName, row);
            }
            catch
            {
                return 0;
            }
        }

        public ArrayList select()
        {
            try
            {
                return db.selectTable(tableName);
            }
            catch
            {
                return null;
            }
        }

        public bool delete<T>(T row)
        {
            try
            {
                return db.deleteTable<T>(tableName, row);
            }
            catch
            {
                return false;
            }
        }

        public bool truncate()
        {
            try
            {
                db.truncateTable(tableName);
                return true;
            }
            catch
            {
                return false;
            }
        }       
    }
}
