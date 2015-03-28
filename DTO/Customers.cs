using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectNhom.Class
{
    class Customers
    {
        int custid;
        string companyName;
        string contactName;
        string contactTitle;
        string address;
        string city;
        string region;
        string postalCode;
        string country;
        string phone;
        string fax;

        public Customers() { }

        public int getCustid()
        {
            return this.custid;
        }

        public string getCompanyName()
        {
            return this.companyName;
        }
        public string getContactTitle()
        {
            return this.contactTitle;
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

        public string getPostalCode()
        {
            return this.postalCode;
        }

        public string getCountry()
        {
            return this.country;
        }

        public string getPhone()
        {
            return this.phone;
        }

        public string getFax()
        {
            return this.fax;
        }


        //=========
        public void setCustid(int custid)
        {
            this.custid = custid;
        }

        public void setCompanyName(string companyName)
        {
            this.companyName = companyName;
        }

        public void setContactName(string contactName)
        {
            this.contactName = contactName;
        }

        public void setContactTitle(string contactTitle)
        {
            this.contactTitle = contactTitle;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }

        public void setCity(string city)
        {
            this.city = city;
        }

        public void setRegion(string region)
        {
            this.region = region;
        }

        public void setPostalCode(string postalCode)
        {
            this.postalCode = postalCode;
        }

        public void setCountry(string country)
        {
            this.country = country;
        }

        public void setPhone(string phone)
        {
            this.phone = phone;
        }

        public void setFax(string fax)
        {
            this.fax = fax;
        }
    }
}
