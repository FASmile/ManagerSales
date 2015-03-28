using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectNhom.Class
{

    class Product
    {
        int ID;
        string proname;
        int supID;
        int cateID;
        double price;
        bool dis;

        Product(int ID, string proname, int supID, int cateID, double price, bool dis)
        {
            this.ID = ID;
            this.proname = proname;
            this.supID = supID;
            this.cateID = cateID;
            this.price = price;
            this.dis = dis;

        }
        public double getprice()
        {
            return this.price;
        }
        public int getID()
        {
            return this.ID;
        }
        public int getsupID()
        {
            return this.supID;
        }
        public int getcateID()
        {
            return this.cateID;
        }
        public bool getdis()
        {
            return this.dis;
        }


    }
}
