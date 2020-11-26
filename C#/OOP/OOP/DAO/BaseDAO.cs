using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DAO
{
    public abstract class BaseDAO
    {
        public abstract bool insert<T>(T row);
        public abstract bool update<T>(T row);
        public abstract ArrayList select();
        public abstract bool delete<T>(T row);
        public abstract bool truncate();
    }
}
