
using System.Collections.Generic;
using System;

namespace ProjectNhom.DAO
{
    interface IManagerDAO
    {
        List<Object> getAll();
        List<Object> search(int id);
        bool add(Object obj);
        object get(int id);
        bool update(Object obj);
        bool delete(int id);
    }

    
}