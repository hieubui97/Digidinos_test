using Algorithm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Algorithm
{
    class Bai23_printMenus
    {
        private static void printMenu(Menu menu)
        {
            Console.WriteLine(menu.Title);
        }
        public static void printMenus(List<Menu> menus)
        {
            int i;
            for (i = 0; i < menus.Count; i++)
            {
                if (menus[i].Parent_id == 0)
                {
                    printMenu(menus[i]);
                    if (hasSubMenus(menus[i].Id, menus))
                    {
                        printSubMenus(menus[i].Id, 1, menus);
                    }
                }
            }
        }

        private static void printSubMenus(int parentId, int level, List<Menu> menus)
        {
            if (hasSubMenus(parentId, menus))
            {
                int i;
                for (i = 0; i < menus.Count; i++)
                {
                    if (menus[i].Parent_id == parentId)
                    {
                       for(int j = 0; j< level; j++)
                        {
                            Console.Write("--");
                        }
                        printMenu(menus[i]);
                        if (hasSubMenus(menus[i].Id, menus))
                        {
                            printSubMenus(menus[i].Id, level++, menus);
                        }
                    }
                }
            }      
        }

        private static bool hasSubMenus(int parentId, List<Menu> menus)
        {
            var subMenus = menus.FirstOrDefault(x => x.Parent_id == parentId);
            if (subMenus != null)
            {
                return true;
            }
            return false;
        }
    }
}
