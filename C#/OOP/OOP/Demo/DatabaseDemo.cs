using OOP.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOP.Demo
{
    class DatabaseDemo
    {
        public void insertTableTest<T>(string name, T row)
        {
            var db = Database.geIntance();
            db.insertTable(name, row);
        }

        public ArrayList selectTable(string name, string where)
        {
            var db = Database.geIntance();
            var result = db.selectTable(name, where);

            return result;
        }
    }
}
