using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectNhom.Class
{
    class Category
    {
        
        int categoryid;
        string categoryname;
        string description;

        public Category() { }

        public int getcategoryid()
        {
            return this.categoryid;
        }

        public string getcategoryname()
        {
            return this.categoryname;

        }
        public string getdescription()
        {
            return this.description;
        }
    }
}
