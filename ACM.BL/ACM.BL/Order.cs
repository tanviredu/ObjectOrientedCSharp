using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ACM.BL
{
    public class Order
    {
        // making overloaded constructor
        public Order()
        {
        }
        public Order(int orderid)
        {
            OrderID  = orderid;
        }

        // it can be null we will take care of it in 
        // validate method
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderID { get; private set; }
        // this order id id tie to the orderitem id
        // in the Orderitem class
    
        
        // retrieve the order 

        
        /// validate method
        public bool Validate()
        {
            var isValid = true;

            // validate the order date
            if(OrderDate == null)
            {
                isValid = false;
            }
            return isValid;
        }


    }
}
