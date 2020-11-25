using OOP.DAO;
using OOP.Entity;
using System;
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
            var result = categoryDao.insertCategory(category);

            return result;
        }

        public bool updateTest(Category category)
        {
            CategoryDAO categoryDao = new CategoryDAO();
            var result = categoryDao.updateCategory(category);

            return result;
        }
    }
}
