using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Entity
{
    class Menu
    {
        private int id;
        private string title;
        private int parent_id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
            }
        }
        public int Parent_id
        {
            get { return parent_id; }
            set { parent_id = value; }
        }

        public static List<Menu> init()
        {
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

            return menus;
        }
    }
}
