using Algorithm.Algorithm;
using Algorithm.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> productList = Product.init();
            List<Category> categorieList = Category.init();
            List<Menu> menus = Menu.init();


            //Bai 11
            List<Product> productsSortByPrice = Bai11_SortByPrice.sortByPrice(productList);
            //Product.printProductList(productsSortByPrice);

            //Bai 12
            List<Product> productsSortByName = Bai12_SortByName.sortByName(productList);
            //Product.printProductList(productsSortByName);

            //Bai 13
            List<Product> productsSortByCategoryName = Bai13_SortByCategoryName.sortByCategoryName(productList, categorieList);
            //Product.printProductList(productsSortByCategoryName);

            //Bai 14
            List<Product> productsMapByCategory = Bai14_MapProductByCategory.mapProductByCategory(productList, categorieList);
            //Product.printProductList(productsMapByCategory);

            //Bai 15
            Product minPrice = Bai15_MinByPrice.minByPrice(productList);
            //Product.printProduct(minPrice);

            //Bai 16
            Product maxPrice = Bai16_MaxByPrice.maxByPrice(productList);
            //Product.printProduct(maxPrice);

            //Bai 21
            double salary = Bai21_CalSalary.calSalaryRecursion(2000, 5);
            Console.WriteLine("Salary: " + salary);

            //Bai 22
            //int month = Bai22_CalMonth.calMonth(2000, 5);
            int month = Bai22_CalMonth.calMonthRecursion(2000, 5);
            Console.WriteLine("Month: " + month);

            //Bai 23
            //Bai23_printMenus.printMenus(menus);

            //Bai 24
            Bai24_Queue<int> queue = new Bai24_Queue<int>();
            queue.push(1);
            queue.push(2);
            Console.WriteLine("Queue: ");
            Console.WriteLine(queue.get());
            Console.WriteLine(queue.get());

            //Bai 25
            Bai25_Stack<int> stack = new Bai25_Stack<int>();
            stack.push(1);
            stack.push(2);
            Console.WriteLine("Stack: ");
            Console.WriteLine(stack.get());
            Console.WriteLine(stack.get());


            Console.ReadKey();
        }
    }
}
