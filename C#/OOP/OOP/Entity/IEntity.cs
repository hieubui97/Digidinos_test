using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entity
{
    interface IEntity
    {
        int getId();
        void setId(int id);
        string getName();
        void setName(string name);
    }
}
