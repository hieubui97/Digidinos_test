using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entity
{
    class Product : BaseRow, IEntity
    {
        private int categoryId;
        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }

        public Product(int id, string name, int categoryId)
        {
            this.id = id;
            this.name = name;
            this.categoryId = categoryId;
        }

        public int getCategoryId()
        {
            return this.categoryId;
        }
        public void setCategoryId(int id)
        {
            this.categoryId = id;
        }
    }
}
