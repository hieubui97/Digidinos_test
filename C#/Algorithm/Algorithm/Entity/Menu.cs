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
    }
}
