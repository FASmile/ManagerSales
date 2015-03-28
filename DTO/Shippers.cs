using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectNhom.Class
{
    class Shippers
    {
        int shipperId;
        string companyName;
        string phone;

        public Shippers() { }

        public int getShipperId()
        {
            return this.shipperId;
        }

        public string getCompanyName()
        {
            return this.companyName;
        }

        public string getPhone()
        {
            return this.phone;
        }

        public void setShipperId(int shipperId)
        {
            this.shipperId = shipperId;
        }

        public void setCompanyName(string companyName)
        {
            this.companyName = companyName;
        }

        public void setPhone(string phone)
        {
            this.phone = phone;
        }
    }
}
