using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Entity
{
    class Category
    {
        private int id;
        private string name;
        //public ICollection<Product> products { get; set; }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public static List<Category> init()
        {
            List<Category> categorieList = new List<Category>();
            categorieList.Add(new Category() { Id = 1, Name = "Comuter" });
            categorieList.Add(new Category() { Id = 2, Name = "Memory" });
            categorieList.Add(new Category() { Id = 3, Name = "Card" });
            categorieList.Add(new Category() { Id = 4, Name = "Acsesory" });

            return categorieList;
        }
    }
}
