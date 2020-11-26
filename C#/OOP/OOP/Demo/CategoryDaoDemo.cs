using OOP.DAO;
using OOP.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Demo
{
    class CategoryDaoDemo
    {
        public bool insertTest(Category category)
        {
            CategoryDAO categoryDao = new CategoryDAO();
            var result = categoryDao.insert(category);

            return result;
        }

        public bool updateTest(Category category)
        {
            CategoryDAO categoryDao = new CategoryDAO();
            var result = categoryDao.update(category);

            return result;
        }

        public ArrayList selectTest()
        {
            CategoryDAO categoryDao = new CategoryDAO();
            var result = categoryDao.select();

            return result;
        }
        public bool deleteTest(Category category)
        {
            CategoryDAO categoryDao = new CategoryDAO();
            var result = categoryDao.delete(category);

            return result;
        }
        public bool truncateTest()
        {
            CategoryDAO categoryDao = new CategoryDAO();
            var result = categoryDao.truncate();

            return result;
        }
    }
}
