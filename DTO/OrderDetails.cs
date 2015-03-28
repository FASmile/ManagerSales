using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectNhom.Class
{
    class OrderDetails
    {
        int orderid;
        int productid;
        int unitprice;
        int quantity;
        int discount;

        public void DetailsOfOrder()
        {
            Console.WriteLine("Order's ID: ", orderid);
            Console.WriteLine("\nProduct's ID: ", productid);
            Console.WriteLine("\nPrice: ", unitprice);
            Console.WriteLine("\nQuantity: ", quantity + " units");
            Console.WriteLine("\nDiscount(%): ", discount + "%");

        }

    }
}
