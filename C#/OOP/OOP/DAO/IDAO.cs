using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DAO
{
    interface IDAO
    {
        int insert<T>(T row);
        int update<T>(T row);
        ArrayList select();
        bool delete<T>(T row);
        bool truncate();
    }
}
