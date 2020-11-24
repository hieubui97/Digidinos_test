using OOP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Demo
{
    class CategoryDemo
    {
        public Category createCategoryTest(int id, string name)
        {
            Category category = new Category() { id = id, name = name };

            return category;
        }

        public void printCategoryTest(Category category)
        {
            Console.WriteLine("Category");
            Console.WriteLine("id:" + category.id);
            Console.WriteLine("name:" + category.name);
            Console.WriteLine();
        }
    }
}
