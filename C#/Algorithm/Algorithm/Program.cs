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
            List<Product> productList = new List<Product>();
            productList.Add(new Product { Name = "CPU", Price = 750, Quality = 10, CategoryId = 1 });
            productList.Add(new Product { Name = "RAM", Price = 50, Quality = 2, CategoryId = 2 });
            productList.Add(new Product { Name = "RAM", Price = 50, Quality = 2, CategoryId = 2 });
            productList.Add(new Product { Name = "Main", Price = 400, Quality = 3, CategoryId = 1 });
            productList.Add(new Product { Name = "Keyboard", Price = 30, Quality = 8, CategoryId = 4 });
            productList.Add(new Product { Name = "Mouse", Price = 25, Quality = 50, CategoryId = 4 });
            productList.Add(new Product { Name = "VGA", Price = 60, Quality = 35, CategoryId = 3 });
            productList.Add(new Product { Name = "Monitor", Price = 120, Quality = 28, CategoryId = 2 });
            productList.Add(new Product { Name = "Case", Price = 120, Quality = 28, CategoryId = 4 });

            List<Category> categorieList = new List<Category>();
            categorieList.Add(new Category() { Id = 1, Name = "Comuter" });
            categorieList.Add(new Category() { Id = 2, Name = "Memory" });
            categorieList.Add(new Category() { Id = 3, Name = "Card" });
            categorieList.Add(new Category() { Id = 4, Name = "Acsesory" });

            List<Menu> menus = new List<Menu>();
            menus.Add(new Menu() { Id = 1, Title = "Thể thao", Parent_id = 0 });
            menus.Add(new Menu() { Id = 2, Title = "Xã hội", Parent_id = 0 });
            menus.Add(new Menu() { Id = 3, Title = "Thể thao trong nước", Parent_id = 1 });
            menus.Add(new Menu() { Id = 4, Title = "Giao thông", Parent_id = 2 });
            menus.Add(new Menu() { Id = 5, Title = "Môi trường", Parent_id = 2 });
            menus.Add(new Menu() { Id = 6, Title = "Thể thao quốc tế", Parent_id = 1 });
            menus.Add(new Menu() { Id = 7, Title = "Môi trường đô thị", Parent_id = 5 });
            menus.Add(new Menu() { Id = 8, Title = "Giao thông ùn tắc", Parent_id = 4 });
            menus.Add(new Menu() { Id = 9, Title = "Giao thông ùn tắc 2020", Parent_id = 8 });
            menus.Add(new Menu() { Id = 10, Title = "Giao thông ùn tắc 2021", Parent_id = 8 });


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
            //Console.WriteLine("Salary: " + salary);

            //Bai 22
            //int month = Bai22_CalMonth.calMonth(2000, 5);
            int month = Bai22_CalMonth.calMonthRecursion(2000, 5);
            //Console.WriteLine("Month: " + month);

            //Bai 23
            //Bai23_printMenus.printMenus(menus);

            //Bai 24
            Bai24_Queue<int> queue = new Bai24_Queue<int>();
            queue.push(1);
            queue.push(2);
            Console.WriteLine(queue.get());
            Console.WriteLine(queue.get());

            //Bai 25
            Bai25_Stack<int> stack = new Bai25_Stack<int>();
            stack.push(1);
            stack.push(2);
            Console.WriteLine(stack.get());
            Console.WriteLine(stack.get());


            Console.ReadKey();
        }
    }
}
