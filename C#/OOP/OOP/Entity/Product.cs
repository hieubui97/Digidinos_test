using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entity
{
    class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int categoryId { get; set; }

        //public int Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}

        public Product(int id, string name, int categoryId)
        {
            this.id = id;
            this.name = name;
            this.categoryId = categoryId;
        }

        public Product()
        {
        }

        public int getId()
        {
            return this.id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
    }
}
