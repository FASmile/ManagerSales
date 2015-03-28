using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectNhom.DAO
{
    public class ManagerCustomers : IManagerDAO 
    {
        ADOSql sql;

        public ManagerCustomers() { }

        #region IManagerDAO Members

        public List<object> getAll()
        {
            throw new NotImplementedException();
        }

        public List<Object> search(int id)
        {
            throw new NotImplementedException();
        }

        public bool add(object obj)
        {
            throw new NotImplementedException();
        }

        public object get(int id)
        {
            throw new NotImplementedException();
        }

        public bool update(object obj)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
