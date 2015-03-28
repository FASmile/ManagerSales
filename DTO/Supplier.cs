using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectNhom.Class
{
    class Supplier
    {
        
        int supplierid;
        string companyname;
        string contactname;
        string contacttitle;
        string address;
        string city;
        string region;
        string country;
        int postalcode;
        int phone;
        int fax;


        public Supplier() { }
        public int getSupplierId()
        {
            return this.supplierid;
        }

        public string getCompanyName()
        {
            return this.companyname;

        }
        public string getContactName()
        {
            return this.contactname;
        }
        public string getContactTitle()
        {
            return this.contacttitle;
        }
        public string getAddress()
        {
            return this.address;
        }
        public string getCity()
        {
            return this.city;

        }
        public string getRegion()
        {
            return this.region;
        }
        public string getCountry()
        {
            return this.country;
        }
        public int getPostalcode()
        {
            return this.postalcode;
        }
        public int getPhone()
        {
            return this.phone;
        }
        public int getFax()
        {
            return this.fax;
        }
    }
}
