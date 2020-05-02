using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {
        }


        public OrderItem(int orderid)
        {
            // init the object with the orderid
            OrderItemId = orderid;
        }


        /// setting up the attribute
        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }


        /// adding the retreve method
        // it will return a OrderItemtype bases on the orteritem

        public OrderItem Retrieve(int orderid)
        {
            // this get orderItem with productid,purchageid and quantity
            // of the signle OrderItem
            return new OrderItem();
        }


        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;
            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid; 
        }

    }



   

}
