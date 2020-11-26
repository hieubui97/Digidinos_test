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

        public int getId()
        {
            return this.id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
    }
}
