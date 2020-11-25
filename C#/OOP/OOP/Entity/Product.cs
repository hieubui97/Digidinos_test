using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entity
{
    class Product : BaseRow
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


        public override int getId()
        {
            return id;
        }

        public override void setId(int id)
        {
            this.id = id;
        }

        public override string getName()
        {
            return name;
        }
        public override void setName(string name)
        {
            this.name = name;
        }
    }
}
