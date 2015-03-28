using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectNhom.Class
{
    public class Employees
    {
        int empid;
        string lastName;
        string firstName;
        string title;
        string titleOfCourtesy;
        string birthday;
        string hiredate;
        string address;
        string city;
        string region;
        string postcode;
        string country;
        string phone;
        int mgird;

        public int getEmpid()
        {
            return this.empid;
        }

        public string getLastName() {
            return this.lastName;
        }

        public string getFirstName() {
            return this.firstName;

        }

        public string getTitle() {
            return this.title;
        }

        public string getTitleOfCourtesy() {
            return this.titleOfCourtesy;
        }

        public string getBirthday() {
            return this.birthday;
        }

        public string getHiredate()
        {
            return this.hiredate;
        }

        public string getAddress() {
            return this.address;
        }

        public string getCity() {
            return this.city;
        }

        public string getRegion() {
            return this.region;
        }

        public string getPostcode() {
            return this.postcode;
        }

        public string getCountry() {
            return this.country;
        }

        public string getPhone() {
            return this.phone;
        }

        public int getMgird() {
            return this.mgird;
        }

        public void setId(int empid)
        {
            this.empid = empid;
        }

        public void setLastName(string lastName) {
            this.lastName = lastName; ;
        }

        public void setFirstName(string firstName) {
            this.firstName = firstName;
        }

        public void setTitle(string title) {
            this.title = title;
        }
        public void setTitleOfCourtesy(string titleOfCourtesy) {
            this.titleOfCourtesy = titleOfCourtesy;
        }

        public void setBirthday(string birthday)
        {
            this.birthday = birthday;
        }

        public void setHiredate(string hiredate)
        {
            this.hiredate = hiredate;
        }

        public void setAddress(string address) {
            this.address = address;
        }

        public void setCity(string city) {
            this.city = city;
        }

        public void setRegion(string region) {
            this.region = region;
        }

        public void setPostcode(string postcode) {
            this.postcode = postcode;
        }

        public void setCountry(string country) {
            this.country = country;
        }

        public void setPhone(string phone) {
            this.phone = phone;
        }

        public void setMgird(int mgird) {
            this.mgird = mgird;
        }
    }
}
