using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderid)
        {
            // create the object
            Order order = new Order(orderid);
            
            // raw test code
            if(orderid == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));

            }
            return order;
        }

        public bool save(Order order)
        {
            return true;
        }

    }
}
