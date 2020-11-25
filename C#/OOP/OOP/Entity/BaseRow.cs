using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entity
{
    public abstract class BaseRow
    {
        protected int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public abstract int getId();
        public abstract void setId(int id);
        public abstract string getName();
        public abstract void setName(string name);
    }
}
